using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

    private bool inputPrevent = true;
    private bool lpActivated = false;
    private bool spActivated = false;
    public RectTransform levelPanel, optionsPanel, storePanel;
    public AnimationCurve animCurve;
    public GameObject levelButtonPrime;
    public GameObject storeModelButtonPrime, storeMatButtonPrime;
    private List<StoreButton> modelButtons;
    private List<StoreButton> matButtons;
    public Transform levelButtonParent, modelButtonParent, matButtonParent, storeFrontButtonParent;
    public Image OptionsSound, OptionsGame, OptionsDisplay;
    public GameObject OptionsSoundPanel, OptionsGamePanel, OptionsDisplayPanel;
    public Image StoreModel, StoreMat, StoreFront;
    public GameObject StoreModelPanel, StoreMatPanel, StoreFrontPanel;
    public Color selected, deselected, highLighted, nonhighLighted;
    public List<Button> buttons;
    private LevelButton[] lvlbtns;
    private Image[] starImages;
    public Image fadePanel;
    public InputField passwordInput;
    public GameObject creditsPanel;

    public Sprite fireTexture;
    public Sprite fireTextureBlue;

    private bool levelStarFull = true;
    private int starScrollIndex = 0;
    private float timeSinceLastStarScroll = 0f;
    private float timeBetweenScrolls = 0.05f;
    public ParticleSystem starParticles;

    private bool panelOpen = false;

    private float width;
    private float height;

    public ScrollRect levelContentScrollRect;

    public GameObject levelLeftArrow, levelRightArrow;
    public ImageGradientScroller levelLeftArrowGrad, levelRightArrowGrad;
    [HideInInspector]
    public bool levelLeftArrowEnabled = false, levelRightArrowEnabled = false;
    private Vector2 levelArrowScrollVelocity;

    public GameObject modelCam;
    public Transform modelHolder;
    private Vector3 modelHolderRotation;
    private float modelCamShowTime = 5f;
    private float modelCamTimeRemaining = 0f;

    public ConfettiPosition confettiPosition;


    //Sound Stuff

    //backerbuttons
    public GameObject devPanel;
    private int[] devInts;
    private float timeSinceLastDevInt;

    int adsThisSession = 0;
    int maxAdsThisSession = 2;

    void Start() {
        modelCam.SetActive(false);
        modelHolderRotation = new Vector3(0.0f, 1.4f, 0.0f);
        modelButtons = new List<StoreButton>();
        matButtons = new List<StoreButton>();
        GameDataManger.manager.ClearMessageQueue();
        GameDataManger.manager.EnableMessageQueue();
        Time.timeScale = 1;
        GameDataManger.manager.fadePanel = fadePanel;
        height = Screen.height;
        width = Screen.width;
        //Debug.Log (Input.touchCount);
        if (Input.touchCount > 0) {
            SetMenuButtons(false);
            inputPrevent = true;
        }
        ButtonOptionsGame();
        ButtonStoreFront();
        InitializeLevelButtons();
        InitializeStoreButtons();
        ButtonStoreModelSelect(modelButtons[GameDataManger.manager.settings.currentModel]);
        ButtonStoreMatSelect(matButtons[GameDataManger.manager.settings.currentMat]);

        levelPanel.gameObject.SetActive(false);
        levelLeftArrow.SetActive(false);
        levelRightArrow.SetActive(false);
        levelArrowScrollVelocity = new Vector2(1500f, 0f);
        GameDataManger.manager.FadeToBlack(false, null);

        devInts = new int[8];
        //Play Music
        if (!GameDataManger.manager.soundManager.musicMainPlaying) {

            GameDataManger.manager.soundManager.FadeInMusic(1.5f);
            GameDataManger.manager.soundManager.PlayMusicMain();
            
            GameDataManger.manager.soundManager.musicMainPlaying = true;
        }

    }
    void InitializeStoreButtons() {
        modelButtons.Add(storeModelButtonPrime.GetComponent<StoreButton>());
        int modelButtonCount = 6;
        if (GameDataManger.manager.unlockData.modelUnlocks[6])
        {
            modelButtonCount = 7;
        }
        for (int i = 1; i < modelButtonCount; i++) {
            GameObject sbg = Instantiate(storeModelButtonPrime, modelButtonParent);
            StoreButton sb = sbg.GetComponent<StoreButton>();
            modelButtons.Add(sb);
            sb.index = i;
            //Debug.Log (GameDataManger.manager.unlockData.modelUnlocks.Length);
            bool unlocked = GameDataManger.manager.unlockData.modelUnlocks[i];
            sb.GetComponent<Button>().interactable = unlocked;
            if (unlocked) {
                switch (i) {
                    case 1:
                        sb.title.text = "Banana";
                        sb.description.text = "Now you know how big things really are!";
                        break;
                    case 2:
                        sb.title.text = "Eggplant";
                        sb.description.text = "Not quite as meaty as a taco.";
                        break;
                    case 3:
                        sb.title.text = "Guac";
                        sb.description.text = "The tastiest green goo imaginable.";
                        break;
                    case 4:
                        sb.title.text = "Money";
                        sb.description.text = "Papers and papers and 'papes'...";
                        break;
                    case 5:
                        sb.title.text = "Void";
                        sb.description.text = "I guess you deserve this...";
                        break;
                    case 6:
                        sb.title.text = "Dachie!";
                        sb.description.text = "Mah Bois!!";
                        break;
                }
            } else {
                sb.title.text = "???";
                sb.description.text = "???";
            }
        }
        matButtons.Add(storeMatButtonPrime.GetComponent<StoreButton>());
        for (int i = 1; i < 6; i++) {
            GameObject sbg = Instantiate(storeMatButtonPrime, matButtonParent);
            StoreButton sb = sbg.GetComponent<StoreButton>();
            matButtons.Add(sb);
            sb.index = i;
            //Debug.Log (GameDataManger.manager.unlockData.matUnlocks.Length);
            bool unlocked = GameDataManger.manager.unlockData.matUnlocks[i];
            sb.GetComponent<Button>().interactable = unlocked;
            if (unlocked) {
                switch (i) {
                    case 1:
                        sb.title.text = "Bronze";
                        sb.description.text = "You beat the game. Not bad.";
                        break;
                    case 2:
                        sb.title.text = "Silver";
                        sb.description.text = "You overcame the odds. Well done!";
                        break;
                    case 3:
                        sb.title.text = "Gold";
                        sb.description.text = "You've worked hard. Now, reap the rewards.";
                        break;
                    case 4:
                        sb.title.text = "Supporter";
                        sb.description.text = "You know a good deal when you see it.";
                        break;
                    case 5:
                        sb.title.text = "Void";
                        sb.description.text = "You did the unthinkable...";
                        break;
                }
            } else {
                sb.title.text = "???";
                sb.description.text = "???";
            }
        }
    }
    public void ReinitStoreButtons() {
        int count = modelButtons.Count;
        for (int i = 1; i < count; i++)
        {
            Destroy(modelButtons[i].gameObject);
        }
        count = matButtons.Count;
        for (int i = 1; i < count; i++)
        {
            Destroy(matButtons[i].gameObject);
        }

        modelButtons.Clear();
        matButtons.Clear();
        InitializeStoreButtons();
        ButtonStoreModelSelect(modelButtons[GameDataManger.manager.settings.currentModel]);
        ButtonStoreMatSelect(modelButtons[GameDataManger.manager.settings.currentMat]);
        modelCamTimeRemaining = 0f;
        
    }
    void InitializeLevelButtons() {
        lvlbtns = new LevelButton[18];
        lvlbtns[0] = levelButtonPrime.GetComponent<LevelButton>();


        for (int i = 2; i < 19; i++)
        {
            LevelButton lvlbtn;
            GameObject newButton = (GameObject)Instantiate(levelButtonPrime, levelButtonParent);
            lvlbtn = newButton.GetComponent<LevelButton>();
            lvlbtn.levelNumber = i;
            lvlbtn.levelText.text = i.ToString();
            lvlbtns[i - 1] = lvlbtn;
        }
        for (int i = 0; i < 18; i++) {
            LevelButton lvlbtn = lvlbtns[i];
            int stars = GameDataManger.manager.levelData.levels[i].amountOfStars;
            lvlbtn.unlocked = GameDataManger.manager.levelData.levels[i].unlocked;
            if (stars > 3)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (j < stars)
                    {
                        lvlbtn.fires[j].sprite = fireTextureBlue;
                        lvlbtn.fires[j].color = Color.white;
                    }
                }
            }
            else
            {
                for (int j = 0; j < 3; j++)
                {
                    if (j < stars)
                    {
                        lvlbtn.fires[j].sprite = fireTexture;
                        lvlbtn.fires[j].color = Color.white;
                    }
                }
            }
            if (stars < 3) {
                levelStarFull = false;
            }
            if (!lvlbtn.unlocked)
            {
                lvlbtn.btn.interactable = false;
                lvlbtn.lockedImage.SetActive(true);
                lvlbtn.levelText.text = "";
            }
            ///WIP
            //buttons.Add (lvlbtn.btn);
        }
        if (levelStarFull) {
            starImages = new Image[54];
            for (int i = 0; i < 18; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    starImages[i * 3 + j] = lvlbtns[i].fires[j];
                }
            }
        }

    }
    void Update() {
        modelHolder.Rotate(modelHolderRotation, Space.Self);
        if (inputPrevent == true) {
            if (Input.touchCount == 0) {
                inputPrevent = false;
                SetMenuButtons(true);
            }

        }
        if (spActivated)
        {
            modelCamTimeRemaining -= Time.deltaTime;
            if(modelCamTimeRemaining <= 0f)
            {
                modelCam.SetActive(false);
            }
            else
            {
                modelCam.SetActive(true);
            }
        }
        if (lpActivated) {


            float horizPos = levelContentScrollRect.horizontalNormalizedPosition;
            //Debug.Log(levelContentScrollRect.velocity);

            if (horizPos > 0.9f) {
                if (!levelLeftArrowEnabled)
                {
                    levelLeftArrowEnabled = true;
                    levelLeftArrow.SetActive(true);
                    levelLeftArrowGrad.counter = 0f;
                }
            }
            else {
                if (levelLeftArrowEnabled)
                {
                    levelLeftArrowEnabled = false;
                    levelLeftArrow.SetActive(false);
                }
            }
            if (horizPos < 0.1f)
            {
                if (!levelRightArrowEnabled)
                {
                    levelRightArrowEnabled = true;
                    levelRightArrow.SetActive(true);
                    levelRightArrowGrad.counter = 0f;
                }
            }
            else
            {
                if (levelRightArrowEnabled)
                {
                    levelRightArrowEnabled = false;
                    levelRightArrow.SetActive(false);
                }
            }

            /*timeSinceLastStarScroll += Time.deltaTime;
            if (timeSinceLastStarScroll > timeBetweenScrolls)
            {
                starScrollIndex = FormatToStarNumber(starScrollIndex);
                starImages[starScrollIndex].sprite = fireTextureBlue;
                starImages[FormatToStarNumber(starScrollIndex - 3)].sprite = fireTexture;
                starScrollIndex += 1;
                if (starScrollIndex > 53) {
                    starScrollIndex -= 54;
                }
                timeSinceLastStarScroll = 0;

            }*/
        }
    }
    public static Rect RectTransformToScreenSpace(RectTransform transform)
    {
        Vector2 size = Vector2.Scale(transform.rect.size, transform.lossyScale);
        return new Rect((Vector2)transform.position - (size * 0.5f), size);
    }
    int FormatToStarNumber(int i) {
        if (i > 53)
        {
            i -= 54;
        }
        else if (i < 0) {
            i += 54;
        }
        return i;
    }
    public void StartGameFromButton(LevelButton btn) {
        GameDataManger.manager.soundManager.FadeOutMusic(3f);
        GameDataManger.manager.soundManager.musicMainPlaying = false;
        int levelToLoad = btn.levelNumber - 1;
        //Random.value produces a random floating point number between 0 and 1.
        //If the random number falls between 1 and 0.667 (33.3% chance), start game with ad.
        if (Random.value > 0.667f) {
            if(adsThisSession < maxAdsThisSession)
            {
                StartCoroutine(GameDataManger.manager.StartGameAfterAd(levelToLoad));
                adsThisSession += 1;
            }
        } else {
            //If the random number is between 0 and 0.667 (66.7% chance), start the game without ad.
            GameDataManger.manager.StartGame(levelToLoad);
        }
    }

    public void ButtonStoreModelSelect(StoreButton sb)
    {
        if (!GameDataManger.manager.unlockData.modelUnlocks[sb.index])
        {
            return;
        }
        GameDataManger.manager.settings.currentModel = sb.index;
        int count = modelButtons.Count;
        for (int i = 0; i < count; i++)
        {
            if (i == sb.index)
            {
                modelButtons[i].image.color = highLighted;
            }
            else
            {
                modelButtons[i].image.color = nonhighLighted;
            }
        }
        if (spActivated) { 
                 SetupModelHolder();
        }
    }
    public void ButtonStoreMatSelect(StoreButton sb) {
        if (!GameDataManger.manager.unlockData.matUnlocks[sb.index]) {
            return;
        }
        GameDataManger.manager.settings.currentMat = sb.index;
        int count = matButtons.Count;
        for (int i = 0; i < count; i++) {
            if (i == sb.index) {
                matButtons[i].image.color = highLighted;
            } else {
                matButtons[i].image.color = nonhighLighted;
            }
        }
        if (spActivated)
        {
            SetupModelHolder();
        }
    }


    private void SetMenuButtons(bool cond) {
        foreach (Button b in buttons) {
            b.interactable = cond;
        }
    }
    #region buttonstuff
    public void ButtonShowLeaderboards() {
        GameDataManger.manager.socialPlat.ShowLeaderBoard();
    }
    public void ButtonStart() {
        StartCoroutine(ButtonTransition(30, levelPanel, Vector2.zero, true));
        lpActivated = true;
    }
    public void ButtonLevelBack() {
        StartCoroutine(ButtonTransition(30, levelPanel, new Vector2(width * 1.3f, 0.0f), false));
        lpActivated = false;
    }
    public void ButtonOptions() {
        
        if(devInts[0] == 2)
        {
            if (devInts[1] == 4)
            {
                if (devInts[2] == 3)
                {
                    if (devInts[3] == 1)
                    {
                        if (devInts[4] == 3)
                        {
                            if (devInts[5] == 1)
                            {
                                if (devInts[6] == 2)
                                {
                                    if (devInts[7] == 4)
                                    {
                                        if (Time.time - timeSinceLastDevInt < 1f)
                                        {
                                            if (GameDataManger.manager.settings.gameTips == 0)
                                            {
                                               
                                                DevPanelButton();
                                                return;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        
        StartCoroutine(ButtonTransition(30, optionsPanel, Vector2.zero, true));
    }
    public void ButtonDevInts()
    {
        if (devInts[0] == 4)
        {
            if (devInts[1] == 3)
            {
                if (devInts[2] == 2)
                {
                    if (devInts[3] == 1)
                    {
                        if (devInts[4] == 4)
                        {
                            if (devInts[5] == 3)
                            {
                                if (devInts[6] == 2)
                                {
                                    if (devInts[7] == 1)
                                    {
                                        if (Time.time - timeSinceLastDevInt < 1f)
                                        {
                                            GameDataManger.manager.UnlockWithMessage(0, 6, GameDataManger.manager.modelUnlockText, "WHATTUP");
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
    public void ButtonOptionsBack() {
        StartCoroutine(ButtonTransition(30, optionsPanel, new Vector2(-width * 1.3f, 0.0f), false));
        GameDataManger.manager.settings.SaveSettings();
    }
    public void ButtonStore() {
        StartCoroutine(ButtonTransition(30, storePanel, Vector2.zero, true));
        spActivated = true;
    }
    public void ButtonStoreBack() {
        StartCoroutine(ButtonTransition(30, storePanel, new Vector2(0.0f, height * 1.3f), false));
        GameDataManger.manager.settings.SaveSettings();
        modelCamTimeRemaining = 0f;
        modelCam.SetActive(false);
        spActivated = false;
    }
    public void FButtonTransition(int frames, RectTransform rt, Vector2 endPos, bool enableOrDisable) {
        StartCoroutine(ButtonTransition(frames, rt, endPos, enableOrDisable));
    }
    public void ButtonOptionsSound() {
        OptionsGame.color = deselected;
        OptionsDisplay.color = deselected;
        OptionsSound.color = selected;

        OptionsDisplayPanel.SetActive(false);
        OptionsGamePanel.SetActive(false);
        OptionsSoundPanel.SetActive(true);
    }
    public void ButtonOptionsDisplay() {
        OptionsGame.color = deselected;
        OptionsDisplay.color = selected;
        OptionsSound.color = deselected;

        OptionsDisplayPanel.SetActive(true);
        OptionsGamePanel.SetActive(false);
        OptionsSoundPanel.SetActive(false);
    }
    public void ButtonOptionsGame() {
        OptionsGame.color = selected;
        OptionsDisplay.color = deselected;
        OptionsSound.color = deselected;

        OptionsDisplayPanel.SetActive(false);
        OptionsGamePanel.SetActive(true);
        OptionsSoundPanel.SetActive(false);
    }
    public void ButtonStoreModel() {
        StoreModel.color = selected;
        StoreMat.color = deselected;
        StoreFront.color = deselected;

        StoreModelPanel.SetActive(true);
        StoreMatPanel.SetActive(false);
        StoreFrontPanel.SetActive(false);

        ReinitStoreButtons();
    }
    public void ButtonStoreMat() {
        StoreModel.color = deselected;
        StoreMat.color = selected;
        StoreFront.color = deselected;

        StoreModelPanel.SetActive(false);
        StoreMatPanel.SetActive(true);
        StoreFrontPanel.SetActive(false);

        ReinitStoreButtons();
    }
    public void ButtonStoreFront() {
        StoreModel.color = deselected;
        StoreMat.color = deselected;
        StoreFront.color = selected;

        StoreModelPanel.SetActive(false);
        StoreMatPanel.SetActive(false);
        StoreFrontPanel.SetActive(true);
    }
    public void ButtonLevelLeftArrow() {
        levelContentScrollRect.velocity = levelArrowScrollVelocity;
    }
    public void ButtonLevelRightArrow()
    {
        levelContentScrollRect.velocity = -levelArrowScrollVelocity;
    }
    #endregion
    public void ButtonResetGameData() {
        System.Action act = () => ResetGameDataDoubleSure();

        GameDataManger.manager.ShowYesOrNoBox(act, "Are you sure you want to delete all game data? You will lose all level progress.");

       
    }
    public void ButtonResetUnlockData()
    {
        System.Action act = () => ResetUnlockDataDoubleSure();

        GameDataManger.manager.ShowYesOrNoBox(act, "Are you sure you want to delete all unlock data? You will lose all unlocked skins and models.");

       
    }
    public void ResetGameDataDoubleSure() {
        System.Action act = () => ResetGameData();
        GameDataManger.manager.ShowYesOrNoBox(act, "Are you double-sure? Seriously?");
    }
    private void ResetGameData() {
        
        GameDataManger.manager.DeleteLevelData();
    }
    public void ResetUnlockDataDoubleSure()
    {
        System.Action act = () => ResetUnlockData();
        GameDataManger.manager.ShowYesOrNoBox(act, "These are your hard-earned unlocks... Seriously? Are you double-sure?");
    }
    private void ResetUnlockData()
    {
        GameDataManger.manager.DeleteUnlockData();
        
    }
    public void DevPanelButton()
    {

        devPanel.SetActive(true);
        GameDataManger.manager.soundManager.PlayCountdownHigh();
    }
    public void DevPanelButtonBack()
    {
        devPanel.SetActive(false);
    }
    public void BackgroundButton() {
        //Debug.Log ("fun");
        if (panelOpen) {
            ButtonOptionsBack();
            ButtonLevelBack();
            ButtonStoreBack();
            CreditsButtonBack();
            DevPanelButtonBack();
        }
    }
    public void BackerButton1()
    {
        BackgroundButton();
        AddToDevInts(1);
    }
    public void BackerButton2()
    {
        BackgroundButton();
        AddToDevInts(2);
    }
    public void BackerButton3()
    {
        BackgroundButton();
        AddToDevInts(3);
    }
    public void BackerButton4()
    {
        BackgroundButton();
        AddToDevInts(4);
    }
    private void AddToDevInts(int num)
    {
        int count = devInts.Length;
        
        if (Time.time - timeSinceLastDevInt > 1f)
        {
            
            for (int i = 0; i < count; i++)
            {
                devInts[i] = 0;
            }
        }
        
        for(int i = count - 1; i > -1; i--)
        {
            if(i == 0)
            {
                
                devInts[i] = num;
            }
            else
            {
                
                devInts[i] = devInts[i - 1];
            }
        }
        timeSinceLastDevInt = Time.time;
       // string funtime = devInts[0].ToString() + devInts[1].ToString() + devInts[2].ToString() + devInts[3].ToString() + devInts[4].ToString() + devInts[5].ToString() + devInts[6].ToString() + devInts[7].ToString();
      // Debug.Log(funtime);
    }
    #region password
    public void PasswordEnter() {
        string inputText = passwordInput.text.ToLower();
        if (inputText == "scale")
        {
            GameDataManger.manager.UnlockWithMessage(0, 1, GameDataManger.manager.modelUnlockText, "Cheater Cheater, Banana Eater! You should be ashamed...");
        }
        else if (inputText == "lewd")
        {
            GameDataManger.manager.UnlockWithMessage(0, 2, GameDataManger.manager.matUnlockText, "Eggplant incoming, good job cheating!");
        }
        else if (inputText == "bestyoutuber")
        {
            GameDataManger.manager.UnlockWithMessage(0, 6, GameDataManger.manager.modelUnlockText, "WHATTUP");
            ReinitStoreButtons();
        }
        else if (inputText == "fuck" || inputText == "shit" || inputText == "bitch" || inputText == "cunt" || inputText == "ass")
        {
            GameDataManger.manager.UnlockWithMessage(2, 0, "HEY!", "Watch your mouth! :(");
        }
        else if (inputText == "password" || inputText == "admin")
        {
            GameDataManger.manager.UnlockWithMessage(2, 0, "LOL", "Nice try, bud.");
        }
        else if (inputText == "steve")
        {
            GameDataManger.manager.UnlockWithMessage(2, 0, "Uhh", "The Developer suddenly feels a tingle on the back of his neck...");
        }
        else if (inputText == "jerome")
        {
            GameDataManger.manager.UnlockWithMessage(2, 0, "YEAH", "Current owner and operator of Comic Fridge. It's high noon.");
        }
        else if (inputText == "mikey")
        {
            GameDataManger.manager.UnlockWithMessage(2, 0, "WOOHOO", "Android owner and experienced game tester. Makes swords.");
        }
        else if (inputText == "andy")
        {
            GameDataManger.manager.UnlockWithMessage(2, 0, "Sniffle", "SniffleSniffleSniffleSniffle");
        }
        else if (inputText == "mark")
        {
            GameDataManger.manager.UnlockWithMessage(2, 0, "Welp", "'I can watch feature length movies and shows on Youtube...'");
        }
        else if (inputText == "amalgamsoftware")
        {
            GameDataManger.manager.UnlockWithMessage(2, 0, "NICE", "Greatest company in the worlddddddddddd.");
        }
        else if (inputText == "tesu" || inputText == "tesc")
        {
            GameDataManger.manager.UnlockWithMessage(2, 0, "TESU", "College for adults!");
        }
        else if (inputText == "tony horton" || inputText == "tonyhorton")
        {
            GameDataManger.manager.UnlockWithMessage(2, 0, "Ab Ripper X", "I hate it, but I love it.");
        }
        else if (inputText == "ticklemetaco" || inputText == "tickle me taco")
        {
            GameDataManger.manager.UnlockWithMessage(2, 0, "Yep", "That was the working title.");
        }
        else if (inputText == "siri")
        {
            GameDataManger.manager.UnlockWithMessage(2, 0, "Heyyyy", "'Let me Bing that for you...'");
        }
        else if (inputText == "google" || inputText == "okgoogle" || inputText == "ok google")
        {
            GameDataManger.manager.UnlockWithMessage(2, 0, "DEHHH", "They're definitely not watching... *Looks over shoulder* Pretty sure they're not watching.");
        }
        else if (inputText == "sam")
        {
            GameDataManger.manager.UnlockWithMessage(2, 0, "Dad?", "The only real dad.");
        }
        else if (inputText == "duckduckgo")
        {
            GameDataManger.manager.UnlockWithMessage(2, 0, "DEHHHH", "Slightly better than GooseGooseCome.");
        }
        else if (inputText == "hots")
        {
            GameDataManger.manager.UnlockWithMessage(2, 0, "Freal", "That matchmaking tho.");
        }
        else if (inputText == "dashie" || inputText == "dachie")
        {
            GameDataManger.manager.UnlockWithMessage(2, 0, "Whattup", "Tina?");
        }
        else if (inputText == "taco")
        {
            GameDataManger.manager.UnlockWithMessage(2, 0, "What?", "You can already play as the taco... go away.");
        }
        else if (inputText == "pickle")
        {
            GameDataManger.manager.UnlockWithMessage(2, 0, "Seriously?", "What's the dill with you?");
        }
        else if (inputText == "cat")
        {
            GameDataManger.manager.UnlockWithMessage(2, 0, "meow", "meow meow meow");
        }
        else if (inputText == "dog")
        {
            GameDataManger.manager.UnlockWithMessage(2, 0, "bork", "bork bork bork");
        }
        else if (inputText == "godmode" || inputText == "god")
        {
            GameDataManger.manager.UnlockWithMessage(2, 0, "UNLOCKED", "GOD MODE unlocked! You are now invincible while on the menu screen!");
        }
        else if (inputText == "tickle")
        {
            GameDataManger.manager.UnlockWithMessage(2, 0, "Nope", "We don't do that here!");
        }
        else if (inputText == "oliver")
        {
            GameDataManger.manager.UnlockWithMessage(2, 0, "Well,", "Technically it should be 'scooter'.");
        }
        else if (inputText == "scooter")
        {
            GameDataManger.manager.UnlockWithMessage(2, 0, "YES", "The correct name for a cat.");
        }
        else if (inputText == "lugosi")
        {
            GameDataManger.manager.UnlockWithMessage(2, 0, "...", "PULL DA STRINK");
        }
        else if (inputText == "symmetra" || inputText == "moira" || inputText == "junkrat" || inputText == "winston" || inputText == "McCree")
        {
            GameDataManger.manager.UnlockWithMessage(2, 0, "BZZZZ", "Aiming? What's that?");
        }
        else if (inputText == "roadhog")
        {
            GameDataManger.manager.UnlockWithMessage(2, 0, "Rides!", "The combo lives on.");
        }
        else if (inputText == "hanzo")
        {
            GameDataManger.manager.UnlockWithMessage(2, 0, "Hmmph", "I am not the Turd!");
        }
        else if (inputText == "genji")
        {
            GameDataManger.manager.UnlockWithMessage(2, 0, "Brother...", "*Unsheathes Katana* 'Neutrogena Kills Cats!'");
        }
        else if (inputText == "mei")
        {
            GameDataManger.manager.UnlockWithMessage(2, 0, "Is Bae", "Push It Out!");
        }
        else if (inputText == "mercy")
        {
            GameDataManger.manager.UnlockWithMessage(2, 0, "Mercy Me", "Things ain't what they used to be... *presses q* UPDATE: *presses e*");
        }
        else if (inputText == "julian")
        {
            GameDataManger.manager.UnlockWithMessage(2, 0, "yo", "please make art for me");
        }
        else if (inputText == "bored" || inputText == "boring")
        {
            GameDataManger.manager.UnlockWithMessage(2, 0, "Bored?", "Get 3 stars on every level or something. Try one of our other games? Go outside? Get a job? Do something constructive? Or send me a fun message at amalgamsoftwaretester@gmail.com");
        }
        else if (inputText == "sombra")
        {
            GameDataManger.manager.UnlockWithMessage(2, 0, "Quiet", "Screaming at top of lungs: 'BEEN HERE ALL ALONG!'");
        }
        else if (inputText == "bastion")
        {
            GameDataManger.manager.UnlockWithMessage(2, 0, "beep", "*murders 5 people* 'BEEP BOOP BEEB :D :D :D'");
        }
        else if (inputText == "kevin")
        {
            GameDataManger.manager.UnlockWithMessage(2, 0, "Uhh", "The good one or the bad one?");
        }
        else if (inputText == "straub")
        {
            GameDataManger.manager.UnlockWithMessage(2, 0, "HUT", "Good man");
        }
        else if (inputText == "darcy")
        {
            GameDataManger.manager.UnlockWithMessage(2, 0, "well", "'Can you edit models directly in Unity?' Roast Beef and Mayo");
        }
        else if (inputText == "scoob" || inputText == "suzanne" || inputText == "sue")
        {
            GameDataManger.manager.UnlockWithMessage(2, 0, "park?", "park?.... park?.... PARK?.... PARK....?");
        }
        else if (inputText == "this game sucks" || inputText == "thisgamesucks")
        {
            GameDataManger.manager.UnlockWithMessage(2, 0, "???", "Uh, no, you suck!");
        }
        else if (inputText == "jesus")
        {
            GameDataManger.manager.UnlockWithMessage(2, 0, "+", "He's watching ;)");
        }
        else if (inputText == "apple")
        {
            GameDataManger.manager.UnlockWithMessage(2, 0, ":)", "Tons of fun ;)");
        }
        else if (inputText == "ketan")
        {
            GameDataManger.manager.UnlockWithMessage(2, 0, "...", "This guy is a straight up savage.");
        }
        else if (inputText == "vareth")
        {
            GameDataManger.manager.UnlockWithMessage(2, 0, "cool name!", "Stop trying to steal it!");
        }
        else if (inputText == "the__hunt")
        {
            GameDataManger.manager.UnlockWithMessage(2, 0, "Whoa", "Who the heck are you? How do you know this handle?");
        }
        else if (inputText == "imgur")
        {
            GameDataManger.manager.UnlockWithMessage(2, 0, "Cool", "95% reposts. 5% fresh, dank memes. 100% more fresh than anywhere else tbh.");
        }
        else if (inputText == "unity" || inputText == "unity3d")
        {
            GameDataManger.manager.UnlockWithMessage(2, 0, "U3D", "Who doesn't love free, professional quality software?");
        }
        else if (inputText == "blender" || inputText == "blender3d")
        {
            GameDataManger.manager.UnlockWithMessage(2, 0, "Blend", "Insanely good software. I highly recommend it.");
        }
        else if (inputText == "iphone" || inputText == "ios") 
        {
            GameDataManger.manager.UnlockWithMessage(2, 0, "ios", "What this game was designed for.");
        }
        else if (inputText == "android")
        {
            GameDataManger.manager.UnlockWithMessage(2, 0, "TBH", "Our android build was sort-of last minute... can you tell?");
        }
        else if (inputText == "noclip")
        {
            GameDataManger.manager.UnlockWithMessage(2, 0, "UNLOCKED", "You can now ignore collision in the menu screen!");
        }
        else if (inputText == "supermariomaker" || inputText == "smm" || inputText == "mariomaker")
        {
            GameDataManger.manager.UnlockWithMessage(2, 0, "SMM", "Special thanks to the current and previous members of the Super Mario Maker community on twitch.tv for keeping me entertained.");
        }
        else if (inputText == "beetle" || inputText == "beetles")
        {
            GameDataManger.manager.UnlockWithMessage(2, 0, "Hmm", "Can you see the future?");
        }
        else if (inputText == "future")
        {
            GameDataManger.manager.UnlockWithMessage(2, 0, "Well", "You'll just have to wait and see!");
        }
        else if (inputText == "zerg")
        {
            GameDataManger.manager.UnlockWithMessage(2, 0, "...", "'For the Swarm!'");
        }
        else if (inputText == "penisland" || inputText == "penis" || inputText == "dick" || inputText == "balls" || inputText == "cock" || inputText == "vagina")
        {
            GameDataManger.manager.UnlockWithMessage(2, 0, "Wow", "Pen Island? I love that place.");
        }
        else if (inputText == "cardel")
        {
            GameDataManger.manager.UnlockWithMessage(2, 0, "Hey", "Play GTAV with me?");
        }
        else if (inputText == "wow" || inputText == "warcraft" || inputText == "worldofwarcraft")
        {
            GameDataManger.manager.UnlockWithMessage(2, 0, "WoW", "Gnomes rule.");
        }
        else if (inputText == "poof" || inputText == "poofdog" || inputText == "poofclaw")
        {
            GameDataManger.manager.UnlockWithMessage(2, 0, "POOF", "Once a poof, always a poof<3");
        }
        else if (inputText == "void")
        {
            GameDataManger.manager.UnlockWithMessage(2, 0, "NULL", "Survive unscathed for a reward...");
        }
        else if (inputText == "null")
        {
            GameDataManger.manager.UnlockWithMessage(2, 0, "VOID", "Think of it like golf...");
        }
        else if (inputText == "golf")
        {
            GameDataManger.manager.UnlockWithMessage(2, 0, "ahem", "You know, golf? Do I really have to say it?");
        }
        else if (inputText == "secret" || inputText == "secrets" || inputText == "hidden" || inputText == "unlock")
        {
            GameDataManger.manager.UnlockWithMessage(2, 0, "Secrets", "They are no fun...");
        }
        else
        {
            
        }

    }
#endregion
    public void CreditsButton() {
        creditsPanel.SetActive(true);
    }
    public void CreditsButtonBack() {
        creditsPanel.SetActive(false);
    }
    public IEnumerator ButtonTransition(int frames, RectTransform rt, Vector2 endPos, bool enableOrDisable) {
        SetMenuButtons(false);
        if (enableOrDisable) {
            rt.gameObject.SetActive(true);
            GameDataManger.manager.soundManager.PlayMenuSlide();
            panelOpen = true;
        } else {
            GameDataManger.manager.soundManager.PlayMenuSlideBack();
            panelOpen = false;

        }
        Vector2 startPos = new Vector2(rt.localPosition.x, rt.localPosition.y);
        Vector2 movement = endPos - startPos;
        for (int i = 1; i <= frames; i++) {
            float evalPoint = (float)i / (float)frames;
            float eval = animCurve.Evaluate(evalPoint);
            rt.localPosition = new Vector3(startPos.x + movement.x * eval, startPos.y + movement.y * eval, 0.0f);
            yield return null;

        }
        SetMenuButtons(true);
        if (!enableOrDisable) {
            
            rt.gameObject.SetActive(false);

        }
    }

    public void EnableModelCam(){
        modelCamTimeRemaining = modelCamShowTime;
        modelCam.SetActive(true);
    }
    void SetupModelHolder() {
        
        EnableModelCam();
        modelHolder.position = modelCam.GetComponent<Camera>().ScreenToWorldPoint(new Vector3(Screen.width * 0.5f, Screen.height * 0.15f, 5f));
        GameObject childToDestroy;
        int count = modelHolder.childCount;
        if (count > 0)
        {
            for (int i = 0; i < count; i++)
            {
                childToDestroy = modelHolder.GetChild(i).gameObject;
                if (childToDestroy != null)
                {
                    Destroy(childToDestroy);
                }
            }
        }
        
        GameDataManger gm = GameDataManger.manager;
        if (gm.assetManager.models[gm.settings.currentModel] != null)
        {
            GameObject newModel = (GameObject)Instantiate(gm.assetManager.models[gm.settings.currentModel], modelHolder, false);
            SetChildLayerRecursively(newModel, 12);
            Material currentPlayerMat = GameDataManger.manager.assetManager.mats[GameDataManger.manager.settings.currentMat];
            if (currentPlayerMat != null)
            {
                MeshRenderer[] rends = newModel.GetComponentsInChildren<MeshRenderer>();
                foreach (MeshRenderer rend in rends)
                {
                    rend.material = currentPlayerMat;
                }
            }
            if (GameDataManger.manager.settings.currentMat == 5 && GameDataManger.manager.settings.currentModel == 5)
            {
                newModel.GetComponentInChildren<ParticleSystem>(true).transform.parent.gameObject.SetActive(true);
            }
        }

       
    }
    void SetChildLayerRecursively(GameObject obj,int layerNumber) {
        obj.layer = layerNumber;
        foreach(Transform t in obj.transform)
        {
            SetChildLayerRecursively(t.gameObject, layerNumber);
        }
    }
    public void MenuButtonPressed()
    {
        //GameDataManger.manager.soundManager.PlayMenuClick();
    }

}
