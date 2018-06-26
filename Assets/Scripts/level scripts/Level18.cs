using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level18 : MonoBehaviour {

	public List<EventNode> toBeSpawned;
	public LevelBasic level;

	//infinite mode variables
	//private float timeSinceLast = 0.0f;
	private float decayRateAlt = 0.01f;
	public bool started = false;
    private int tier = 1;

	private int tierCounter = 0;

	//private float tier1DecayRateAlt = 0.01f;
	private float tier1DecayRateFactor = 1f;
	private float tier2DecayRateAlt = 0.013f;
	private float tier2DecayRateFactor = 1.3f;
	private float tier3DecayRateAlt = 0.017f;
	private float tier3DecayRateFactor = 1.7f;
	//private float tier4DecayRate = 0.02f;
	//private float tier4DecayRateFactor = 2f;
	private float currentTierDecayRate;

    //Adjust quickness scale to control speed of game proportionately;
    //Should be 4f
    private float quicknessScale = 4f;

    //private float tier1offset = 3f;
    //private float tier2offset = 2.5f;
    //private float tier3offset = 2f;
    //private float tier4offset = 2f;
    //private float currentTierOffset;

    //private float pointPerTime;
	// Use this for initialization
	protected virtual void Start () {
       
       
		level = gameObject.GetComponent<LevelBasic> ();
		toBeSpawned = level.toBeSpawned;
		level.score = 1f;
        level.scoreModifier = quicknessScale;
		//currentTierOffset = tier1offset;
		currentTierDecayRate = tier1DecayRateFactor;
        GameDataManger.manager.ShowTip(19);
		NextSpawn ();
	}
	void Update(){
		if (started) {
			ApplyDecay ();
            //Debug.Log(level.score);
				

		} else {
			if (!level.levelEnded) {
				started = true;
			}
		}
	}
	void CheckTime(){
		/*timeSinceLast += Time.deltaTime;
		if (timeSinceLast > currentTierOffset) {
			toBeSpawned.Add (new SpawnNode (0, 4, 4, 2f));
			timeSinceLast = 0f;
		}*/

	}
	void ApplyDecay(){
		level.score -= Time.deltaTime * decayRateAlt * quicknessScale;
	}

	void NextSpawn(){
		//Debug.Log (Time.time);
		//Debug.Log (tier);
		//select Tier;
		if (tierCounter == 20) {
			tier = 2;
            currentTierDecayRate = tier2DecayRateFactor;
            decayRateAlt = tier2DecayRateAlt;
		} else if (tierCounter == 40) {
			tier = 3;
            currentTierDecayRate = tier3DecayRateFactor;
            decayRateAlt = tier3DecayRateAlt;
        } else if (tierCounter == 80) {
			//tier = 4;
		}
		tierCounter += 1;
		int tierSelect = Random.Range (1, tier + 1);

		if (tierSelect == 1) {
			int setSelect = Random.Range (0, 4);
			if (setSelect == 0) {
				StartCoroutine (Tier1_1());
			}
			else if (setSelect == 1) {
				StartCoroutine (Tier1_2());
			}
			else if (setSelect == 2) {
				StartCoroutine (Tier1_3());
			}
			else if (setSelect == 3) {
				StartCoroutine (Tier1_4());
			}
		}
		if (tierSelect == 2) {
			int setSelect = Random.Range (0, 4);
			//Debug.Log (setSelect);
			if (setSelect == 0) {
				StartCoroutine (Tier2_1());
			}
			else if (setSelect == 1) {
				StartCoroutine (Tier2_2());
			}
			else if (setSelect == 2) {
				StartCoroutine (Tier2_3());
			}
			else if (setSelect == 3) {
				StartCoroutine (Tier2_4());
			}
		}
		if (tierSelect == 3) {
			int setSelect = Random.Range (0, 4);
			//Debug.Log (setSelect);
			if (setSelect == 0) {
				StartCoroutine (Tier3_1());
			}
			else if (setSelect == 1) {
				StartCoroutine (Tier3_2());
			}
			else if (setSelect == 2) {
				StartCoroutine (Tier3_3());
			}
			else if (setSelect == 3) {
				StartCoroutine (Tier3_4());
			}
		}
	}

	private IEnumerator Tier1_1(){
		//3 in one second
		int dir = Random.Range (0, 4);
		int typ = Random.Range (0, 5);
		float offs = Random.Range (0f, 1f);
		yield return new WaitForSeconds (0.33f);
		toBeSpawned.Add(new SpawnNode(0,typ,dir,offs));
		yield return new WaitForSeconds (0.33f);
		toBeSpawned.Add(new SpawnNode(0,typ,dir,offs));
		yield return new WaitForSeconds (0.33f);
		toBeSpawned.Add(new SpawnNode(0,typ,dir,offs));

		yield return new WaitForSeconds (3.5f - currentTierDecayRate * 1.5f);

		NextSpawn ();

		yield break;
	}
	private IEnumerator Tier1_2(){
		//3 in one second
		int dir = Random.Range (0, 4);
		int typ = Random.Range (0, 5);
		float offs = Random.Range (0.1f, 0.9f);
		yield return new WaitForSeconds (1f);
		toBeSpawned.Add(new SpawnNode(0,typ,dir,offs + 0.1f));
		toBeSpawned.Add(new SpawnNode(0,typ,dir,offs));
		toBeSpawned.Add(new SpawnNode(0,typ,dir,offs - 0.1f));

		yield return new WaitForSeconds (3.5f - currentTierDecayRate * 1.5f);

		NextSpawn ();

		yield break;
	}
	private IEnumerator Tier1_3(){
		//3 in one second
		int dir = Random.Range (1, 3);
		int typ = Random.Range (0, 5);
		float offs = 0.5f;
		yield return new WaitForSeconds (1f);
		toBeSpawned.Add(new SpawnNode(0,typ,0,offs));
		toBeSpawned.Add(new SpawnNode(0,typ,0 + dir,offs));
		toBeSpawned.Add(new SpawnNode(0,typ,0 + dir + 1,offs));

		yield return new WaitForSeconds (3.5f - currentTierDecayRate * 1.5f);

		NextSpawn ();

		yield break;
	}
	private IEnumerator Tier1_4(){
		//3 in one second
		int dir = Random.Range (0, 4);
		int typ = Random.Range (0, 5);
		//float offs = Random.Range (0f, 1f);
		yield return new WaitForSeconds (0.33f);
		toBeSpawned.Add(new SpawnNode(0,typ,dir,0.5f));
		yield return new WaitForSeconds (0.33f);
		toBeSpawned.Add(new SpawnNode(0,typ,dir,0.9f));
		yield return new WaitForSeconds (0.33f);
		toBeSpawned.Add(new SpawnNode(0,typ,dir,0.1f));

		yield return new WaitForSeconds (3.5f - currentTierDecayRate * 1.5f);

		NextSpawn ();

		yield break;
	}
	private IEnumerator Tier2_1(){
		//3 in one second
		//float offs = Random.Range (0f, 1f);
		yield return new WaitForSeconds (1f);
		toBeSpawned.Add(new SpawnNode(0,8,4,2f));
		if (Random.value > 0.8f) {
			toBeSpawned.Add(new SpawnNode(0,9,4,2f));
		}

		yield return new WaitForSeconds (3.5f - currentTierDecayRate * 1.5f);

		NextSpawn ();

		yield break;
	}
	private IEnumerator Tier2_2(){
		//5 in one second

		int dir = Random.Range (0, 4);
		int typ = Random.Range (0, 5);
		yield return new WaitForSeconds (0.2f);
		float adjust = 0.75f * Random.Range (-1, 2);
		toBeSpawned.Add(new SpawnNode(0,typ,dir,0.5f + adjust * 2,false));

		yield return new WaitForSeconds (0.2f);
		toBeSpawned.Add(new SpawnNode(0,typ,dir,0.5f + adjust,false));

		yield return new WaitForSeconds (0.2f);
		toBeSpawned.Add(new SpawnNode(0,typ,dir,0.5f,false));

		yield return new WaitForSeconds (0.2f);
		toBeSpawned.Add(new SpawnNode(0,typ,dir,0.5f - adjust,false));

		yield return new WaitForSeconds (0.2f);
		toBeSpawned.Add(new SpawnNode(0,typ,dir,0.5f - adjust * 2,false));

		yield return new WaitForSeconds (6.5f - currentTierDecayRate * 2.5f);

		NextSpawn ();

		yield break;
	}
	private IEnumerator Tier2_3(){
		//5 in one second

		int dir = Random.Range (0, 4);
		int typ = Random.Range (0, 5);
		yield return new WaitForSeconds (0.33f);
		float adjust = 0.75f * Random.Range (-1, 2);
		toBeSpawned.Add(new SpawnNode(0,typ,dir,0.5f,false));

		yield return new WaitForSeconds (0.33f);
		toBeSpawned.Add(new SpawnNode(0,typ,dir,0.5f + adjust,false));
		toBeSpawned.Add(new SpawnNode(0,typ,dir,0.5f - adjust,false));

		yield return new WaitForSeconds (0.33f);

		toBeSpawned.Add(new SpawnNode(0,typ,dir,0.5f + adjust * 2,false));
		toBeSpawned.Add(new SpawnNode(0,typ,dir,0.5f - adjust * 2,false));


		yield return new WaitForSeconds (6.5f - currentTierDecayRate * 2.5f);

		NextSpawn ();

		yield break;
	}
	private IEnumerator Tier2_4(){
		//5 in one second
		int dir = Random.Range (0, 4);
		int typ = Random.Range (0, 5);
		float offs = Random.Range (0f, 1f);
		yield return new WaitForSeconds (0.33f);
		toBeSpawned.Add(new SpawnNode(0,typ,dir,offs));
		yield return new WaitForSeconds (0.33f);
		toBeSpawned.Add(new SpawnNode(0,8,dir,offs));
		yield return new WaitForSeconds (0.33f);
		toBeSpawned.Add(new SpawnNode(0,typ,dir,offs));

		yield return new WaitForSeconds (6.5f - currentTierDecayRate * 2.5f);

		NextSpawn ();

		yield break;
	}
	private IEnumerator Tier3_1(){
		//3 in one second
		int dir = Random.Range (0, 4);
		int typ = Random.Range (0, 5);
		float offs = Random.Range (0f, 1f);
		toBeSpawned.Add(new SpawnNode(0,10,dir,offs,false));
		yield return new WaitForSeconds (0.33f);
		toBeSpawned.Add(new SpawnNode(0,typ,dir,offs,false));
		yield return new WaitForSeconds (0.33f);
		toBeSpawned.Add(new SpawnNode(0,typ,dir,offs,false));
		yield return new WaitForSeconds (0.33f);
		toBeSpawned.Add(new SpawnNode(0,typ,dir,offs,false));


		yield return new WaitForSeconds (3.5f - currentTierDecayRate * 1.5f);

		NextSpawn ();

		yield break;
	}
	private IEnumerator Tier3_2(){
		//3 in one second
		int dir = Random.Range (0, 4);
		//int typ = Random.Range (0, 5);
		float offs = Random.Range (0f, 1f);
		toBeSpawned.Add(new SpawnNode(0,10,dir,offs,false));
		yield return new WaitForSeconds (0.5f);
		toBeSpawned.Add(new SpawnNode(0,8,dir,offs,false));
		yield return new WaitForSeconds (0.5f);
		toBeSpawned.Add(new SpawnNode(0,10,dir,offs,false));


		yield return new WaitForSeconds (3.5f - currentTierDecayRate * 1.5f);

		NextSpawn ();

		yield break;
	}
	private IEnumerator Tier3_3(){
		//3 in one second
		int dir = Random.Range (0, 4);
		int typ = Random.Range (0, 5);
		yield return new WaitForSeconds (1f);
		toBeSpawned.Add(new SpawnNode(0,10,dir,0.8f,false));
		toBeSpawned.Add(new SpawnNode(0,typ,dir,0.65f,false));
		toBeSpawned.Add(new SpawnNode(0,typ,dir,0.5f,false));
		toBeSpawned.Add(new SpawnNode(0,typ,dir,0.35f,false));
		toBeSpawned.Add(new SpawnNode(0,10,dir,0.2f,false));


		yield return new WaitForSeconds (3.5f - currentTierDecayRate * 1.5f);

		NextSpawn ();

		yield break;
	}
	private IEnumerator Tier3_4(){
		//6 in two seconds
		int dir = Random.Range (0, 4);
		int typ = Random.Range (0, 5);
		float offs = Random.Range (0.6f, 0.4f);
		yield return new WaitForSeconds (0.4f);
		toBeSpawned.Add(new SpawnNode(0,10,dir,offs+0.1f,false));
		toBeSpawned.Add(new SpawnNode(0,10,dir,offs - 0.1f,false));
		yield return new WaitForSeconds (0.4f);
		toBeSpawned.Add(new SpawnNode(0,typ,dir,offs+0.1f,false));
		toBeSpawned.Add(new SpawnNode(0,typ,dir,offs - 0.1f,false));
		yield return new WaitForSeconds (0.4f);
		toBeSpawned.Add(new SpawnNode(0,typ,dir,offs+0.1f,false));
		toBeSpawned.Add(new SpawnNode(0,typ,dir,offs - 0.1f,false));
		yield return new WaitForSeconds (0.4f);
		toBeSpawned.Add(new SpawnNode(0,typ,dir,offs+0.1f,false));
		toBeSpawned.Add(new SpawnNode(0,typ,dir,offs - 0.1f,false));
		yield return new WaitForSeconds (0.4f);
		toBeSpawned.Add(new SpawnNode(0,10,dir,offs+0.1f,false));
		toBeSpawned.Add(new SpawnNode(0,10,dir,offs - 0.1f,false));



		yield return new WaitForSeconds (7f - currentTierDecayRate * 3f);

		NextSpawn ();

		yield break;
	}
}
