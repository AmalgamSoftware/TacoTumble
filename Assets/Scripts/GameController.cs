using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	[HideInInspector]
	public static bool isPaused = false;
	public Player playerPrefab;
	[HideInInspector]
	public Transform playerTf;
	[HideInInspector]
	public Player player;
	private Transform camTF;
	public GameObject pausePanel;
	public GameObject pauseButton;
	private Vector3 camStartPos;
	public Slider progressSlider;

	public ParticleSystem dusterRing;
	public Animator dustAnim;
	//public RectTransform duster, dustHolder;
	//SCORE
	[HideInInspector]
	//public float score;
	public Text scoreText;
	public Image scoreSlider;
	[HideInInspector]
	public int levelNumber = 11;
	[HideInInspector]
	public LevelBasic level;
	[HideInInspector]
	public PhysicParticlePool ppp;
	public Image fadePanel;

	public GameObject countDowns;
	private Text[] countDownTexts;

	//Player/Taco setup stuff
	//public List<GameObject> playerModels;
	public GameObject currentPlayerModel;
	//public List<Material> playerMats;
	public Material currentPlayerMat;

	private Animator playerAnim;
	//private Vector3 playerStartPosition = Vector3.zero;
	private Vector3 playerAnimStartPos = new Vector3 (0f, -2.54f, 0f);
	private Vector3 playerAnimStartRot = new Vector3(-6.51f,26.04f,0f);
	private Vector3 playerAnimStartScale = new Vector3 (5f, 5f, 5f);

    //EndofLevel UI STUFF
    #region EndPanelStuff
    public Gradient scoreGrad;
	private float scorePercent;
	private float scoreEnd;
	//public Text scoreEndText;
	public List<Text> CompleteText;
	public List<Text> EndScoreText;
	public GameObject endPanel;
	public GameObject image1,image2,image3,image4,star1,star2,star3;
    public Image star1Image, star2Image, star3Image;
	public List<ParticleSystem> endConfetti;
    public Sprite whiteFire;
    public ParticleSystem starConfetti;
    #endregion


    //Background stuff
    public MaterialTintController mtc;
	public GameObject[] backgrounds;
	private GameObject backgroundToUse;
	public Transform backgroundHolder;
	public Animator endScoreAnim;

	//UIBorders
	public RectTransform borderLeft,borderRight,borderTop,borderBottom;
    public RectTransform sliderRect;
	private float borderWidth = 500f;

    //ScoreThresholds

    private float scoreThresh1Star = 0.7f;
    private float scoreThresh2Star = 0.8f;
    private float scoreThresh3Star = 0.9f;
    private float scoreThresh4Star = 1f;

    private float scoreThresh1StarInf = 60f;
    private float scoreThresh2StarInf = 80f;
    private float scoreThresh3StarInf = 130f;
    private float scoreThresh4StarInf = 150f;

    //BackGroundButton
    public GameObject backGroundButton;

    //HighScore stuff
    //private bool waitForHighScoreSubmission = false;
    private float scoreToSubmit;




    //private Vector2 camRatio = new Vector2 (16f,9f);

    // Use this for initialization
    void Awake(){
		GameDataManger.manager.gameController = this;
		endPanel.SetActive (false);
	}
    /*void Update()
    {
        SetBorders();
    }*/
	void Start(){
		GameDataManger.manager.fadePanel = fadePanel;
		camTF = Camera.main.transform;
		camStartPos = camTF.position;
		levelNumber = GameDataManger.manager.currentLevel;
		GameDataManger.manager.FadeToBlack (false, null);
		ppp = GetComponent<PhysicParticlePool> ();
		UnPause ();
        GameDataManger.manager.ClearMessageQueue();
        //Player initialization
        player = (Player)Instantiate (playerPrefab,playerAnimStartPos,Quaternion.Euler(playerAnimStartRot));
		playerTf = player.transform;

		//playermodel/material setup
		if (!GameDataManger.manager.unlockData.modelUnlocks [GameDataManger.manager.settings.currentModel]) {
			GameDataManger.manager.settings.currentModel = 0;
			GameDataManger.manager.settings.SaveSettings ();
		} 
		currentPlayerModel = GameDataManger.manager.assetManager.models[GameDataManger.manager.settings.currentModel];
		if (currentPlayerModel == null) {
			currentPlayerModel =  GameDataManger.manager.assetManager.models[0];
		}
		Instantiate(currentPlayerModel,playerTf,false);
		if (!GameDataManger.manager.unlockData.matUnlocks [GameDataManger.manager.settings.currentMat]) {
			GameDataManger.manager.settings.currentMat = 0;
			GameDataManger.manager.settings.SaveSettings ();
		} 
		currentPlayerMat = GameDataManger.manager.assetManager.mats[GameDataManger.manager.settings.currentMat];
		if (currentPlayerMat != null) {
			MeshRenderer[] rends = playerTf.GetComponentsInChildren<MeshRenderer>();
			foreach (MeshRenderer rend in rends) {
				rend.material = currentPlayerMat;
			}
		}
		//Custom model setups
		if(GameDataManger.manager.settings.currentMat == 5 && GameDataManger.manager.settings.currentModel == 5){
			playerTf.GetComponentInChildren<ParticleSystem> (true).transform.parent.gameObject.SetActive (true);
            
		}

		player.GetComponent<Rigidbody> ().isKinematic = true;
		playerAnim = player.GetComponent<Animator> ();
		playerAnim.enabled = false;
		playerTf.position = playerAnimStartPos;
		playerTf.eulerAngles = playerAnimStartRot;
		playerTf.localScale = playerAnimStartScale;

		player.dustAnim = dustAnim;
		//player.dusterHolder = dustHolder;
		//player.duster = duster;
		player.dusterRing = dusterRing;
		player.gc = this;
		player.level = level;

		SpawnBackground ();
		StartCoroutine (CountDown ());
		SetBorders ();
	}
	private IEnumerator CountDown(){
        //playerTf.localScale = playerAnimStartScale;
        GameDataManger.manager.soundManager.LoadLevelMusic();
		LevelSetup ();
		countDownTexts = countDowns.GetComponentsInChildren<Text> ();
		yield return new WaitForSeconds (1f);
		countDowns.SetActive (true);
		string setter;
		for (int i = 3; i >= 1; i--) {
			setter = i.ToString();
			SetCountDowns (setter);
            GameDataManger.manager.soundManager.PlayCountdownLow();
            yield return new WaitForSeconds (1f);
            
		}
		SetCountDowns ("GO");
        GameDataManger.manager.soundManager.PlayCountdownHigh();
        StartCoroutine (PlayerStartAnim());
		yield return new WaitForSeconds (1f);
        GameDataManger.manager.soundManager.PlayMusicLevel();
        GameDataManger.manager.EnableMessageQueue();
		countDowns.SetActive (false);
		level.levelEnded = false;
		if (levelNumber == 17) {
			level.infiniteMode = true;
		}

	}
	private void LevelSetup(){
		string LevelType ="Level" + (levelNumber + 1).ToString();
		if (levelNumber == 17) {
			gameObject.AddComponent<Level18>();
		} else {
			try{
				gameObject.AddComponent(System.Type.GetType(LevelType,true));
			}
			catch(System.Exception){
				gameObject.AddComponent<Level1>();

			}
		}

	}
	private IEnumerator PlayerStartAnim(){
		playerAnim.enabled = true;
		playerAnim.Play ("PlayerStart");
		yield return new WaitForSeconds (1.1f);
		player.dusterEnabled = true;
		playerAnim.enabled = false;
	}
	public void EndLevelCoroutine(){
		StartCoroutine (EndOfLevel ());
	}
	private IEnumerator EndOfLevel (){
        GameDataManger.manager.DisableMessageQueue();
        GameDataManger.manager.soundManager.FadeOutMusic(2f);
		yield return new WaitForSeconds (2f);
        GameDataManger.manager.soundManager.PlayMusicScore();
		pauseButton.GetComponent<Button> ().interactable = false;
		player.GetComponent<Rigidbody> ().isKinematic = true;
		player.dusterEnabled = false;
		for (int i = 0; i < 45; i++) {
			playerTf.position = Vector3.Lerp (playerTf.position, playerAnimStartPos,0.1f);
			playerTf.localScale = Vector3.Lerp (playerTf.localScale, playerAnimStartScale,0.1f);
			playerTf.rotation = Quaternion.Lerp (playerTf.rotation, Quaternion.Euler(playerAnimStartRot),0.1f);
			yield return null;
		}
		StartCoroutine (EndTacoRotate ());
		yield return new WaitForSeconds (0.1f);
		endPanel.SetActive (true);
		image2.SetActive (false);
		image3.SetActive (false);
		image4.SetActive (false);
        star1.SetActive(false);
        star2.SetActive(false);
        star3.SetActive(false);

        

        image1.SetActive (true);
		foreach (Text t in CompleteText) {
			t.text = "Level " + (levelNumber + 1).ToString () + " Complete!";
		}
		yield return new WaitForSeconds (1f);
		scorePercent = level.score * 100f;
		image2.SetActive (true);
		scoreEnd = 0f;
		Color gradColor = Color.black;
		gradColor = scoreGrad.Evaluate (scoreEnd * 0.01f);
		EndScoreText [0].color = gradColor;
        StartCoroutine(CompleteTextShrink());
        bool star1Revealed = false, star2Revealed = false, star3Revealed = false;
        int rustleCounter = 0,rustleCounterMax = 1;

        if (level.infiniteMode) {
            

            float timeElapsed = level.timeElapsed;
            scorePercent = timeElapsed;
            if (scorePercent < 75) {
                scorePercent = 75;
            }
            while (scoreEnd < timeElapsed) {
                scoreEnd += 1.11f;

                rustleCounter += 1;
                if (rustleCounter > rustleCounterMax)
                {
                    GameDataManger.manager.soundManager.PlayCashRustle();
                    rustleCounter = 0;
                }


                if (scoreEnd > timeElapsed) {
                    scoreEnd = timeElapsed;
                }
                if (!star1Revealed)
                {
                    if (scoreEnd > scoreThresh1StarInf)
                    {
                        star1.SetActive(true);
                        star1Revealed = true;
                        starConfetti.transform.position = new Vector3(-2.626f, -2.034f, -7.5f);
                        starConfetti.Emit(40);
                        GameDataManger.manager.soundManager.PlayConfettiPuff();

                    }
                }
                if (!star2Revealed)
                {
                    if (scoreEnd > scoreThresh2StarInf)
                    {
                        star2.SetActive(true);
                        star2Revealed = true;
                        starConfetti.transform.position = new Vector3(-0, -2.034f, -7.5f);
                        starConfetti.Emit(40);
                        GameDataManger.manager.soundManager.PlayConfettiPuff();
                    }
                }
                if (!star3Revealed)
                {
                    if (scoreEnd > scoreThresh3StarInf)
                    {
                        star3.SetActive(true);
                        star3Revealed = true;
                        starConfetti.transform.position = new Vector3(2.626f, -2.034f, -7.5f);
                        starConfetti.Emit(40);
                        GameDataManger.manager.soundManager.PlayConfettiPuff();
                    }
                }
                else
                {
                    if (scoreEnd >= scoreThresh4StarInf)
                    {
                        star1Image.sprite = whiteFire;
                        star2Image.sprite = whiteFire;
                        star3Image.sprite = whiteFire;
                    }
                }
                for (int i = 0; i < 2; i++) {
                    EndScoreText[i].text = (Mathf.Round(scoreEnd * 100f) / 100f).ToString() + " sec";
                }
                gradColor = scoreGrad.Evaluate(scoreEnd / 50f);
                EndScoreText[0].color = gradColor;



                yield return null;
            }
        }
        else
        {
            while (scoreEnd < scorePercent)
            {
                rustleCounter += 1;
                if (rustleCounter > rustleCounterMax)
                {
                    GameDataManger.manager.soundManager.PlayCashRustle();
                    rustleCounter = 0;
                }

                scoreEnd += 1f;
                if (scoreEnd > scorePercent)
                {
                    scoreEnd = scorePercent;
                }
                for (int i = 0; i < 2; i++)
                {
                    EndScoreText[i].text = Mathf.FloorToInt(scoreEnd).ToString();
                }
                gradColor = scoreGrad.Evaluate(scoreEnd * 0.01f);
                EndScoreText[0].color = gradColor;

                if (!star1Revealed)
                {
                    if (scoreEnd > scoreThresh1Star * 100)
                    {
                        star1.SetActive(true);
                        star1Revealed = true;
                        starConfetti.transform.position = new Vector3(-2.626f, -2.034f, -7.5f);
                        starConfetti.Emit(40);
                        GameDataManger.manager.soundManager.PlayConfettiPuff();

                    }
                }
                if (!star2Revealed)
                {
                    if (scoreEnd > scoreThresh2Star * 100)
                    {
                        star2.SetActive(true);
                        star2Revealed = true;
                        starConfetti.transform.position = new Vector3(-0, -2.034f, -7.5f);
                        starConfetti.Emit(40);
                        GameDataManger.manager.soundManager.PlayConfettiPuff();
                    }
                }
                if (!star3Revealed)
                {
                    if (scoreEnd > scoreThresh3Star * 100)
                    {
                        star3.SetActive(true);
                        star3Revealed = true;
                        starConfetti.transform.position = new Vector3(2.626f, -2.034f, -7.5f);
                        starConfetti.Emit(40);
                        GameDataManger.manager.soundManager.PlayConfettiPuff();
                    }
                }
                else {
                    if (scoreEnd >= scoreThresh4Star * 100) {
                        star1Image.sprite = whiteFire;
                        star2Image.sprite = whiteFire;
                        star3Image.sprite = whiteFire;
                    }
                }



                yield return null;
            }
        }
		endScoreAnim.Play ("run");
		image3.SetActive(true);
		/*for (int i = 0; i < 2; i++) {
			ParticleSystem.MainModule m = endConfetti [i].main;
			m.startColor = gradColor;
			m.maxParticles = Mathf.FloorToInt (scorePercent);
			endConfetti [i].Play();
		}*/
		if (scorePercent >= 90f) {
			ParticleSystem.EmissionModule em = endConfetti [2].emission;
			em.enabled = true;
		}

        yield return new WaitForSeconds(1.0f);
        GameDataManger.manager.EnableMessageQueue();
        if(scorePercent <  scoreThresh1Star * 100f)
        {
            GameDataManger.manager.ShowTip(23);
        }
        EndLevel();


        //Debug.Log(GameDataManger.manager.messageQueueCount);
        yield return new WaitForSeconds(0.1f);
        while(GameDataManger.manager.messageQueueCount > 0)
        {
            yield return null;
        }
        backGroundButton.SetActive(true);
        
        yield return new WaitForSeconds(1.0f);
        GameDataManger.manager.ClearMessageQueue();
        image4.SetActive(true);
	}

    public void BackGroundButtonExit()
    {
        ToMenu();
    }

	private IEnumerator EndTacoRotate(){
		while (this) {
			playerTf.Rotate (new Vector3(0.0f,1.4f,0.0f),Space.Self);
			yield return null;
		}
	}
    private IEnumerator CompleteTextShrink() {
        yield return new WaitForSeconds(1f);
        float ctsScalex = 1f;
        while (ctsScalex > 0) {
            ctsScalex -= 0.03f;
            
            if (ctsScalex < 0) {
                ctsScalex = 0;
            }
            image1.transform.localScale = new Vector3(ctsScalex, ctsScalex, 1);
            yield return null;
        }
        
    }
	public void QuitButton(){
		System.Action act = () => ToMenu ();
        GameDataManger.manager.ClearMessageQueue();
        GameDataManger.manager.ShowYesOrNoBox(act,"Level progress is only saved upon level completion. Are you sure you want to quit?");

	}
    public void QueryHighScoreSubmission() {
        System.Action act = () => SubmitInfiniteModeHighScore();
        System.Action actCancel = () => QueryHighScoreSubmissionCancel();
        GameDataManger.manager.ShowYesAndNoBox(act,actCancel, "Submit your high score?");
    }
    private void QueryHighScoreSubmissionCancel() {
        System.Action act = () => QueryHighScoreSubmission();
        GameDataManger.manager.ShowNoBox(act,"Are you sure you don't want to submit your high score?");
    }
    public void SubmitInfiniteModeHighScore() {
        //waitForHighScoreSubmission = true;
        GameDataManger.manager.socialPlat.SubmitHighScoreInfiniteMode(scoreToSubmit);
        GameDataManger.manager.socialPlat.ShowLeaderBoard();

    }
	public void TogglePause(){
		if (isPaused) {
			UnPause ();
		} else {
			Pause ();
		}
	}
	public void Pause(){
		Time.timeScale = 0;
        isPaused = true;
		pausePanel.SetActive (true);
		//pauseButton.SetActive (false);
	}
	public void UnPause(){
		Time.timeScale = 1;
		isPaused = false;
		pausePanel.SetActive (false);
		//pauseButton.SetActive (true);
	}
	public void StartScreenShake(int frames, float mag){
		StartCoroutine (ScreenShake (frames, mag));
	}
	public IEnumerator ScreenShake(int frames,float mag){
		for (int i = 0; i < frames; i++) {
			Vector2 offset = Random.insideUnitCircle;
			Vector3 newPos = new Vector3 (offset.x * mag, offset.y * mag, camTF.position.z);
			camTF.position = newPos;
			yield return null;
		}
		camTF.position = camStartPos;
	}
	public void ToMenu(){
		UnPause ();
		GameDataManger.manager.FadeToBlack (true, "MenuScene");
	}
	public void SetScoreText (int s){
		//scoreText.text = s.ToString ();
		if (level.score < 1f) {
			scoreSlider.color = scoreGrad.Evaluate (level.score);
		}
		else{
            if(!level.infiniteMode)
			scoreSlider.color = Color.white;
		}
	}

	private void SetCountDowns(string s){
		for (int i = 0; i < countDownTexts.Length; i++) {
			countDownTexts [i].text = s;
		}
	}
	public void EndLevel(){
        //This does scoring and score submission;
		IndLevel lev = GameDataManger.manager.levelData.levels [levelNumber];
		float score = level.score;
		//Debug.Log (level.score);
        if (level.infiniteMode)
        {
            score = level.timeElapsed;
            int potentialStars = 0;
            if (score > lev.score)
            {
                if (score >= scoreThresh3StarInf)
                {
                    potentialStars = 3;
                }
                else if (score >= scoreThresh2StarInf)
                {
                    potentialStars = 2;
                }
                else if (score >= scoreThresh1StarInf)
                {
                    potentialStars = 1;
                }
                else
                {
                    potentialStars = 0;
                }
                scoreToSubmit = score;
                QueryHighScoreSubmission();
            }
            if(potentialStars > lev.amountOfStars)
            {
                lev.amountOfStars = potentialStars;
            }
            if(lev.amountOfStars > 0)
            {
                GameDataManger.manager.ShowTip(20);
            }
            
        }
        else
        {
            
            if (score > lev.score)
            {
                lev.score = score;
                if (score >= scoreThresh4Star)
                {
                    lev.amountOfStars = 4;
                }
                else if (score >= scoreThresh3Star)
                {
                    lev.amountOfStars = 3;
                }
                else if (score >= scoreThresh2Star)
                {
                    lev.amountOfStars = 2;
                }
                else if (score >= scoreThresh1Star)
                {
                    lev.amountOfStars = 1;
                }
                else
                {
                    lev.amountOfStars = 0;
                }
               
            }
            if (score == 0f)
            {

                if (GameDataManger.manager.settings.currentMat == 5)
                {
                    GameDataManger.manager.UnlockWithMessage(0, 5, GameDataManger.manager.modelUnlockText, "Again...? For your tenacity, you've been awarded the 'Void' playermodel. Head over to the 'Models' tab to enjoy your 'success'...");
                }
                GameDataManger.manager.UnlockWithMessage(1, 5, GameDataManger.manager.matUnlockText, "You beat a level with 0 score... That's actually kind of hard to pull off. You've been awarded the 'Void' skin.");
            }
            else if (score == 1f)
            {
                if (GameDataManger.manager.unlockData.modelUnlocks[1])
                {
                    GameDataManger.manager.UnlockWithMessage(0, 2, GameDataManger.manager.matUnlockText, "What an overachiever! For recieving a 100% score AGAIN, you've been awarded the Eggplant playermodel");
                }
                GameDataManger.manager.UnlockWithMessage(0, 1, GameDataManger.manager.modelUnlockText, "Baller! For beating a level with a 100% score, you've unlocked the Banana playermodel. Head over to the 'models' tab of the 'extras' menu to equip it");
            }
        }
		if (lev.amountOfStars > 0 && levelNumber < 17) {
			GameDataManger.manager.levelData.levels [levelNumber + 1].unlocked = true;
		}
		GameDataManger.manager.SaveLevelData ();
        CheckForUnlocks();
	}
    private void CheckForUnlocks() {
        int lowest = 3;
        for (int i = 0; i < 17; i++) {
            int strs = GameDataManger.manager.levelData.levels[i].amountOfStars;
            if (strs < lowest) lowest = strs;
        }
        if (lowest == 4) {
            GameDataManger.manager.UnlockWithMessage(2, 0, "GEEZ", "Get a life......");
        }
        if (lowest >= 3)
        {
            GameDataManger.manager.UnlockWithMessage(1, 3, GameDataManger.manager.matUnlockText, "Congrats! Your unrivaled effort has unlocked the GOLD playermodel! Visit the 'Models' tab in the 'Extras' menu to equip it... Thanks for playing, and also... take a break, maybe?");

        }
        if (lowest >= 2)
        {
            GameDataManger.manager.UnlockWithMessage(1, 2, GameDataManger.manager.matUnlockText, "Achieving two stars on every level has earned you the SILVER skin! Visit the 'Models' tab to equip it.");

        }
        if (lowest >= 1)
        {
            GameDataManger.manager.UnlockWithMessage(1, 1, GameDataManger.manager.matUnlockText, "You beat the game with a minimum of one star on every level, earning the BRONZE skin! Visit the 'Models' tab to equip it.");

        }
        
    }
	public void SpawnBackground(){
		if (levelNumber == 0) {
			SetBackGround (0);
		} else if (levelNumber == 1) {
			SetBackGround (1);
		} else if (levelNumber == 2){
			SetBackGround (2);
		}
        else if (levelNumber == 3)
        {
            SetBackGround(3);
        }
        else if(levelNumber == 4 || levelNumber == 5)
        {
            SetBackGround(8);
        }
        else if (levelNumber == 6 || levelNumber == 7)
        {
            SetBackGround(9);
        }
        else if (levelNumber == 8 || levelNumber == 9)
        {
            SetBackGround(10);
        }
        else if (levelNumber == 10 || levelNumber == 11)
        {
            SetBackGround(4);
        }
        else if (levelNumber == 12 || levelNumber == 13)
        {
            SetBackGround(11);
        }
        else if (levelNumber == 14 || levelNumber == 15)
        {
            SetBackGround(5);
        }
        else if (levelNumber == 16)
        {
            SetBackGround(6);
        }
        else if (levelNumber == 17)
        {
            SetBackGround(7);
        }
    }
	private void SetBackGround(int num){
		if (backgrounds [num] != null) {
			backgroundToUse = backgrounds [num];
			GameObject bkg = (GameObject)Instantiate (backgroundToUse,backgroundHolder,false);
			ReferenceColor rfc = bkg.GetComponent<ReferenceColor> ();
			if (rfc != null) {
				Color col = rfc.col;
				mtc.SetColors (col);
			} else {
				mtc.SetColors(Color.grey);
			}
		}
	}

	public void SetBorders(){
		float height = Screen.height;
		float width = Screen.width;
        
        float orthoDelta = (height / width - 9f / 16f);
        float orthoDeltaW = (width / height - 16f / 9f);
        float orthoCamSize = 5f + orthoDelta * 9f;
        //float orthoCamSizeW = 11.43f + orthoDeltaW * 16f;
		//Debug.Log (orthoDeltaW);
        //Debug.Log(orthoDelta);
        if (orthoDelta > 0.01f)
        {
            Camera.main.orthographicSize = orthoCamSize;
            height = 5f / orthoCamSize * height;
        }
        if(orthoDeltaW > 0.01f) {
            Camera.main.orthographicSize = 5f;
            width = height * 1.77777f;
            
            //width = (1 - orthoDeltaW) * width;
        }

        //Debug.Log(width / height);
        //width = (1 - orthoDeltaW) * width;

        //top
        borderTop.sizeDelta = new Vector2(width * 1.5f,borderWidth);
		borderTop.anchoredPosition = new Vector2(0f,height* 0.5f + borderWidth * 0.5f);
		//bottom
		borderBottom.sizeDelta = new Vector2(width * 1.5f,borderWidth);
		borderBottom.anchoredPosition = new Vector2(0f,- height* 0.5f - borderWidth * 0.5f);
		//left
		borderLeft.sizeDelta = new Vector2(borderWidth,height * 1.5f);
		borderLeft.anchoredPosition = new Vector2(- width* 0.5f - borderWidth * 0.5f,0f);
		//Right
		borderRight.sizeDelta = new Vector2(borderWidth,height * 1.5f);
		borderRight.anchoredPosition = new Vector2( width* 0.5f + borderWidth * 0.5f,0f);

        sliderRect.sizeDelta = new Vector2(height * 0.8f, width * 0.03f);
        sliderRect.anchoredPosition = new Vector2(width * 0.025f -width/2f, 0f);

        scoreText.rectTransform.anchoredPosition = new Vector2(width * 0.025f - width / 2f,height * 0.45f);

        /*star1.GetComponent<RectTransform>().sizeDelta = new Vector2(width * 0.5f, width * 0.1f);
        star2.GetComponent<RectTransform>().sizeDelta = new Vector2(width * 0.5f, width * 0.1f);
        star3.GetComponent<RectTransform>().sizeDelta = new Vector2(width * 0.5f, width * 0.1f);*/

        star1.GetComponent<RectTransform>().anchoredPosition = new Vector2(-width * 0.15f, height * 0.25f - height * 0.5f);
        star2.GetComponent<RectTransform>().anchoredPosition = new Vector2(0f, height * 0.25f - height * 0.5f);
        star3.GetComponent<RectTransform>().anchoredPosition = new Vector2(width * 0.15f, height * 0.25f - height * 0.5f);


    }

}
