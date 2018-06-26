using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelBasic : MonoBehaviour {
	
	[HideInInspector]
	public List<EventNode> toBeSpawned = new List<EventNode>();
	[HideInInspector]
	public List<Pickup> activePickups = new List<Pickup>();
	[HideInInspector]
	public int total = 0;
	[HideInInspector]
	public int totalPossible = 0;

	private float singleSliderWeight = 0;
	private int counter = 0;
	private float xSpeed = 0.12f;
	private float xSpeedForY = 0.05f;
	private float ySpeed = 0.13f;
	//private float xOffsetMax = 8f, xOffsetMin = -8f;
	//private float yOffsetMax = 3f, yOffsetMin = -2f;
	private float screenOriginX = -8.5f;
	private float screenOriginY = -4.5f;
	private float screenScaleX = 17f;
	private float screenScaleY = 9f;
	public Pickup pickupPrefab;
	public Affector affectorPrefab;
	public Pickup BeefSpecial,CheeseSpecial,LettuceSpecial,Pill,Rock;
	public Material bf, cz, lc, sc;
	//private float funcounter = 0;
	public Slider progressSlider;
	[HideInInspector]
	public GameController gc;
    [HideInInspector]
    public bool levelEnded = true;
	[HideInInspector]
	public bool levelStarted = false;
	public int normalPickupScore = 1;
	public int specialPickupScore = 3;
    public float scoreModifier = 1f;

	[HideInInspector]
	public bool infiniteMode = false;
    //SCORE STUFF

    public Text scoreText;
	[HideInInspector]
	public float score = 0;
    [HideInInspector]
    public float timeElapsed;
	// Use this for initialization
	void Start () {
		GameDataManger.manager.gameController.level = this;
		GameDataManger.manager.gameController.player.level = this;
		gc = GameDataManger.manager.gameController;
        if (infiniteMode) {
            scoreText.gameObject.SetActive(true);
        }
		//count up spawnnodes for total;

	}
	public void LevelSetup(){
		SpawnNode snCheck;
		int c = toBeSpawned.Count;
		for(int i = 0; i < c; i++){
			if (toBeSpawned [i].eventType == SpawnEventType.pickup) {
				snCheck = (SpawnNode)toBeSpawned [i];
				if (snCheck.type > 4 && snCheck.type < 9) {
					totalPossible += specialPickupScore;
				} else if(snCheck.type < 5) {
					totalPossible += normalPickupScore;
				}

			}
		}
		singleSliderWeight = 1f / totalPossible;

	}
	// Update is called once per frame
	void Update () {
        //Debug.Log(score);
		if (!GameController.isPaused && !levelEnded) {
			counter += 1;
			CheckCounter ();
			if (infiniteMode) {
                timeElapsed += Time.deltaTime;
                scoreText.text = (Mathf.Round(timeElapsed*10)/10).ToString();
				InfModeSliderUpdate ();
				if (score <= 0f) {
					EndLevel ();
				}
			} else {
				if (toBeSpawned.Count == 0 && activePickups.Count == 0){
					EndLevel ();
				}
			}

				
		}
	}
	private void EndLevel (){
		levelEnded = true;
		gc.EndLevelCoroutine ();
	}
	public void ChangeScore(int scoreChange){
		if (infiniteMode) {
			score += scoreChange * 0.01f * scoreModifier;
		}
		else {
			total += scoreChange;
			score = total * singleSliderWeight;
            if(total >= totalPossible)
            {
                score = 1f;
            }
			progressSlider.value = score;
			gc.SetScoreText (Mathf.FloorToInt (score * 100f));
		}
	}

	public void InfModeSliderUpdate(){
		progressSlider.value = score;
		gc.SetScoreText (Mathf.FloorToInt (score * 100f));
	}

	void CheckCounter(){
		if (toBeSpawned.Count > 0) {
			if (counter >= toBeSpawned [0].timeOff) {
				counter = 0;
				NextEvent (toBeSpawned [0]);
				toBeSpawned.RemoveAt (0);
				CheckCounter ();
			}
		}
		else{
			//Debug.Log ("Finished, yo");
		}
	}


	void NextEvent(EventNode node){
		//tip handling
		if (node.eventType == SpawnEventType.tip) {
			TipNode tipNode = (TipNode)node;
			GameDataManger.manager.ShowTip (tipNode.tipNumber);
		}
		//spawn handling
		else if (node.eventType == SpawnEventType.pickup) {
			SpawnNode spawnNode = (SpawnNode)node;
			SpawnPickup (spawnNode.type, spawnNode.direction, spawnNode.offset,spawnNode.grav);
		} 
		//wait handling
		else if(node.eventType == SpawnEventType.wait){
			return;
		}
		//Affector Handling
		else if (node.eventType == SpawnEventType.affector) {
			AffectorNode affectorNode = (AffectorNode)node;
			SpawnAffector (affectorNode.type, affectorNode.duration, affectorNode.x, affectorNode.y);
		}

	}

	void SpawnAffector(bool type, int dur, float x, float y){
		Vector3 pos = new Vector3 (screenOriginX + screenScaleX * x, screenOriginY + screenScaleY * y, 0f);
		Affector affec = (Affector)Instantiate (affectorPrefab, pos, Quaternion.identity);
		affec.type = type;
		affec.duration = dur;

	}

	void SpawnPickup (int type, int dir, float offs,bool grav){
		float pos1D = 0f;
		Pickup prefabToUse = pickupPrefab;
		if (offs > 1f) {
			offs = 1f;
		}else if(offs < 0f){
			offs = 0f;
		}
		if (dir == 0 || dir == 2) {
			pos1D = offs * 16f - 8f;
		}
		else if (dir == 1 || dir == 3) {
			pos1D = offs * 5f - 2f;
		}
		Vector3 pos = Vector3.zero;
		Vector3 veloc = Vector3.zero;
		if (!grav) {
			
			if (dir == 0 || dir == 2) {
				pos1D = offs * 16f - 8f;
			}
			else if (dir == 1 || dir == 3) {
				pos1D = offs * 9.5f - 4.75f;
			}

			switch (dir) {
			case 0:
				pos = new Vector3 (pos1D, 6f, 0.0f);
				veloc = new Vector3 (0.0f, -0.06f, 0.0f);
				break;
			case 1:
				pos = new Vector3 (9.5f, pos1D, 0.0f);
				veloc = new Vector3 (-0.06f, 0.0f, 0.0f);
				break;
			case 2:
				pos = new Vector3 (pos1D, -5.5f, 0.0f);
				veloc = new Vector3 (0.0f, 0.06f, 0.0f);
				break;
			case 3:
				pos = new Vector3 (-9.5f, pos1D, 0.0f);
				veloc = new Vector3 (0.06f, 0.0f, 0.0f);
				break;
			}
		} else {

			if (dir == 0 || dir == 2) {
				pos1D = offs * 16f - 8f;
			}
			else if (dir == 1 || dir == 3) {
				pos1D = offs * 5f - 2f;
			}

			switch (dir) {
			case 0:
				pos = new Vector3 (pos1D, 6f, 0.0f);
				veloc = Vector3.zero;
				break;
			case 1:
				pos = new Vector3 (9.5f, pos1D, 0.0f);
				veloc = new Vector3 (-xSpeed, xSpeedForY, 0.0f);
				break;
			case 2:
				pos = new Vector3 (pos1D, -5.5f, 0.0f);
				veloc = new Vector3 (0.0f, ySpeed, 0.0f);
				break;
			case 3:
				pos = new Vector3 (-9.5f, pos1D, 0.0f);
				veloc = new Vector3 (xSpeed, xSpeedForY, 0.0f);
				break;
			}
		}

		//Define which model to use based on taco type.
		int tacoType;
		if (type == 4) {
			tacoType = Random.Range (0, 4);
		} else if (type == 8) {
			tacoType = Random.Range (5, 8);
		} else {
			tacoType = type;
		}
		if (type > 4) {
			switch (tacoType) {
			case 5:
				prefabToUse = BeefSpecial;
				break;
			case 6:
				prefabToUse = CheeseSpecial;
				break;
			case 7:
				prefabToUse = LettuceSpecial;
				break;
			case 9:
				prefabToUse = Pill;
				break;
			case 10:
				prefabToUse = Rock;
				break;
			}
		}
	
		Pickup pickup = (Pickup)Instantiate (prefabToUse, pos, Quaternion.identity);
		pickup.level = this;
		pickup.velocity = veloc;
		pickup.gravity = grav;
		if (tacoType < 4) {
			pickup.value = normalPickupScore;
			pickup.modelTf.position += new Vector3 (0f, 0f, 3f + tacoType);
		} else if (tacoType < 9) {
			pickup.value = specialPickupScore;
			pickup.special = true;
		} else {
			pickup.value = 0;
		}

		if (tacoType >= 0 && tacoType <= 3) {
			switch (tacoType) {
			case 0:
				pickup.type = Type.Beef;
				pickup.GetComponentInChildren<Renderer> ().material = bf;
				break;
			case 1:
				pickup.type = Type.Cheese;
				pickup.GetComponentInChildren<Renderer> ().material = cz;

				break;
			case 2:
				pickup.type = Type.Lettuce;
				pickup.GetComponentInChildren<Renderer> ().material = lc;

				break;
			case 3:
				pickup.type = Type.Cream;
				pickup.GetComponentInChildren<Renderer> ().material = sc;

				break;
			}
		}
		if (type < 10) {
			activePickups.Add (pickup);
		}


	}

}
