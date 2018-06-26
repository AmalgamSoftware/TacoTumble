using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level16 : LevelTemplate {


	protected override void LoadList (){

		int offsetBetween = 20;

		toBeSpawned.Add (new SpawnNode(100,5,0,0.5f));
		toBeSpawned.Add (new SpawnNode(0,6,1,0.5f));
		toBeSpawned.Add (new SpawnNode(0,7,3,0.5f));
		toBeSpawned.Add (new TipNode(0,18));

		int interval1 = 10;
		toBeSpawned.Add (new SpawnNode(150,4,2,0.0f,false));
		toBeSpawned.Add (new SpawnNode(interval1,4,2,0.1f,false));
		toBeSpawned.Add (new SpawnNode(interval1,4,2,0.2f,false));
		toBeSpawned.Add (new SpawnNode(interval1,4,2,0.3f,false));
		toBeSpawned.Add (new SpawnNode(interval1,4,2,0.4f,false));
		toBeSpawned.Add (new SpawnNode(interval1,4,2,0.5f,false));
		toBeSpawned.Add (new SpawnNode(interval1,4,2,0.6f,false));
		toBeSpawned.Add (new SpawnNode(interval1,4,2,0.7f,false));
		toBeSpawned.Add (new SpawnNode(interval1,4,2,0.8f,false));
		toBeSpawned.Add (new SpawnNode(interval1,4,2,0.9f,false));
		toBeSpawned.Add (new SpawnNode(interval1,4,2,1f,false));
		for (int i = 0; i < 10; i++) {
			toBeSpawned.Add (new SpawnNode(interval1,4,1,i * 0.1f + 0.1f,false));
		}


		toBeSpawned.Add (new SpawnNode(150,10,3,0.1f,false));
		toBeSpawned.Add (new SpawnNode(0,10,3,0.3f,false));
		toBeSpawned.Add (new SpawnNode(0,10,3,0.5f,false));
		toBeSpawned.Add (new SpawnNode(30,10,3,0.5f,false));
		toBeSpawned.Add (new SpawnNode(0,4,3,0.3f,false));
		toBeSpawned.Add (new SpawnNode(0,4,3,0.1f,false));
		toBeSpawned.Add (new SpawnNode(15,4,3,0.3f,false));
		toBeSpawned.Add (new SpawnNode(0,4,3,0.1f,false));
		toBeSpawned.Add (new SpawnNode(15,4,3,0.3f,false));
		toBeSpawned.Add (new SpawnNode(0,4,3,0.1f,false));
		toBeSpawned.Add (new SpawnNode(15,4,3,0.3f,false));
		toBeSpawned.Add (new SpawnNode(0,4,3,0.1f,false));
		toBeSpawned.Add (new SpawnNode(15,4,3,0.3f,false));
		toBeSpawned.Add (new SpawnNode(0,4,3,0.1f,false));
		toBeSpawned.Add (new SpawnNode(15,4,3,0.3f,false));
		toBeSpawned.Add (new SpawnNode(0,4,3,0.1f,false));
		toBeSpawned.Add (new SpawnNode(15,4,3,0.3f,false));
		toBeSpawned.Add (new SpawnNode(0,4,3,0.1f,false));
		toBeSpawned.Add (new SpawnNode(30,10,3,0.1f,false));
		toBeSpawned.Add (new SpawnNode(0,10,3,0.3f,false));
		toBeSpawned.Add (new SpawnNode(0,10,3,0.5f,false));

		toBeSpawned.Add (new SpawnNode(200,10,3,0.9f,false));
		toBeSpawned.Add (new SpawnNode(0,10,1,0.1f,false));
		toBeSpawned.Add (new SpawnNode(30,6,3,0.9f,false));
		toBeSpawned.Add (new SpawnNode(0,6,1,0.1f,false));
		toBeSpawned.Add (new SpawnNode(30,10,3,0.9f,false));
		toBeSpawned.Add (new SpawnNode(0,10,1,0.1f,false));

		toBeSpawned.Add (new SpawnNode(100,4,3,0.5f,false));
		toBeSpawned.Add (new SpawnNode(0,4,1,0.5f,false));
		toBeSpawned.Add (new SpawnNode(10,4,3,0.5f,false));
		toBeSpawned.Add (new SpawnNode(0,4,1,0.5f,false));
		toBeSpawned.Add (new SpawnNode(10,4,3,0.5f,false));
		toBeSpawned.Add (new SpawnNode(0,4,1,0.5f,false));
		toBeSpawned.Add (new SpawnNode(10,4,3,0.5f,false));
		toBeSpawned.Add (new SpawnNode(0,4,1,0.5f,false));
		toBeSpawned.Add (new SpawnNode(10,4,3,0.5f,false));
		toBeSpawned.Add (new SpawnNode(0,4,1,0.5f,false));
		toBeSpawned.Add (new SpawnNode(10,4,3,0.5f,false));
		toBeSpawned.Add (new SpawnNode(0,4,1,0.5f,false));

		toBeSpawned.Add (new AffectorNode(0,true,200,0.5f,0.8f));

		toBeSpawned.Add (new SpawnNode(10,4,3,0.5f,false));
		toBeSpawned.Add (new SpawnNode(0,4,1,0.5f,false));
		toBeSpawned.Add (new SpawnNode(10,4,3,0.5f,false));
		toBeSpawned.Add (new SpawnNode(0,4,1,0.5f,false));
		toBeSpawned.Add (new SpawnNode(10,4,3,0.5f,false));
		toBeSpawned.Add (new SpawnNode(0,4,1,0.5f,false));
		toBeSpawned.Add (new SpawnNode(10,4,3,0.5f,false));
		toBeSpawned.Add (new SpawnNode(0,4,1,0.5f,false));
		toBeSpawned.Add (new SpawnNode(10,4,3,0.5f,false));
		toBeSpawned.Add (new SpawnNode(0,4,1,0.5f,false));
		toBeSpawned.Add (new SpawnNode(10,4,3,0.5f,false));
		toBeSpawned.Add (new SpawnNode(0,4,1,0.5f,false));
	
		toBeSpawned.Add (new WaitNode(200));

		for(int i = 0; i < 10; i ++){
			toBeSpawned.Add (new SpawnNode(offsetBetween,4,4,2f,false));
			toBeSpawned.Add (new SpawnNode(offsetBetween,4,4,2f,false));
			toBeSpawned.Add (new SpawnNode(offsetBetween,4,4,2f,false));
			toBeSpawned.Add (new SpawnNode(offsetBetween,4,4,2f,false));
			toBeSpawned.Add (new SpawnNode(10,10,0,0.5f,false));
		}

		toBeSpawned.Add (new SpawnNode(20,7,0,2f,false));
		for (int i = 0; i < 5; i++) {
			toBeSpawned.Add (new SpawnNode(20,7,0,2f,false));
			toBeSpawned.Add (new SpawnNode(20,7,0,2f,false));
			toBeSpawned.Add (new SpawnNode(20,10,Random.Range(0,1) * 2 + 1,2f,false));
		}

		float offsetFromCenter = 0.11f;
		float offsetFromCenter2 = 0.25f;

		toBeSpawned.Add (new SpawnNode(200,10,0,0.5f + offsetFromCenter,false));
		toBeSpawned.Add (new SpawnNode(0,10,0,0.5f - offsetFromCenter,false));
		toBeSpawned.Add (new SpawnNode(0,5,0,0.5f ,false));
		toBeSpawned.Add (new SpawnNode(30,10,0,0.5f + offsetFromCenter,false));
		toBeSpawned.Add (new SpawnNode(0,10,0,0.5f - offsetFromCenter,false));
		toBeSpawned.Add (new SpawnNode(0,5,0,0.5f,false));
		toBeSpawned.Add (new SpawnNode(30,10,0,0.5f + offsetFromCenter,false));
		toBeSpawned.Add (new SpawnNode(0,10,0,0.5f - offsetFromCenter,false));
		toBeSpawned.Add (new SpawnNode(0,0,0,0.5f,false));
		toBeSpawned.Add (new SpawnNode(30,10,0,0.5f + offsetFromCenter,false));
		toBeSpawned.Add (new SpawnNode(0,10,0,0.5f - offsetFromCenter,false));
		toBeSpawned.Add (new SpawnNode(0,0,0,0.5f,false));
		toBeSpawned.Add (new SpawnNode(30,10,0,0.5f + offsetFromCenter,false));
		toBeSpawned.Add (new SpawnNode(0,10,0,0.5f - offsetFromCenter,false));
		toBeSpawned.Add (new SpawnNode(0,0,0,0.5f,false));
		toBeSpawned.Add (new SpawnNode(30,10,0,0.5f + offsetFromCenter,false));
		toBeSpawned.Add (new SpawnNode(0,10,0,0.5f - offsetFromCenter,false));
		toBeSpawned.Add (new SpawnNode(30,10,0,0.5f + offsetFromCenter,false));
		toBeSpawned.Add (new SpawnNode(0,10,0,0.5f - offsetFromCenter,false));
		toBeSpawned.Add (new SpawnNode(0,0,0,0.5f,false));
		toBeSpawned.Add (new SpawnNode(30,10,0,0.5f + offsetFromCenter,false));
		toBeSpawned.Add (new SpawnNode(0,10,0,0.5f - offsetFromCenter,false));
		toBeSpawned.Add (new SpawnNode(30,10,0,0.5f + offsetFromCenter,false));
		toBeSpawned.Add (new SpawnNode(0,10,0,0.5f - offsetFromCenter,false));
		toBeSpawned.Add (new SpawnNode(0,0,0,0.5f,false));
		toBeSpawned.Add (new SpawnNode(30,10,0,0.5f + offsetFromCenter,false));
		toBeSpawned.Add (new SpawnNode(0,10,0,0.5f - offsetFromCenter,false));

		toBeSpawned.Add (new SpawnNode(30,10,0,0.5f + offsetFromCenter,false));
		toBeSpawned.Add (new SpawnNode(0,10,0,0.5f - offsetFromCenter,false));
		toBeSpawned.Add (new SpawnNode(30,10,0,0.5f + offsetFromCenter,false));
		toBeSpawned.Add (new SpawnNode(0,10,0,0.5f - offsetFromCenter,false));
		toBeSpawned.Add (new SpawnNode(30,10,0,0.5f + offsetFromCenter,false));
		toBeSpawned.Add (new SpawnNode(0,10,0,0.5f - offsetFromCenter,false));
		toBeSpawned.Add (new SpawnNode(30,10,0,0.5f + offsetFromCenter,false));
		toBeSpawned.Add (new SpawnNode(0,10,0,0.5f - offsetFromCenter,false));
		toBeSpawned.Add (new SpawnNode(30,10,0,0.5f + offsetFromCenter,false));
		toBeSpawned.Add (new SpawnNode(0,10,0,0.5f - offsetFromCenter,false));

		toBeSpawned.Add (new SpawnNode(30,10,0,0.5f + offsetFromCenter,false));
		toBeSpawned.Add (new SpawnNode(0,10,0,0.5f - offsetFromCenter,false));
		toBeSpawned.Add (new SpawnNode(0,0,0,0.5f + offsetFromCenter2,false));
		toBeSpawned.Add (new SpawnNode(15,0,0,0.5f + offsetFromCenter2,false));
		toBeSpawned.Add (new SpawnNode(15,10,0,0.5f + offsetFromCenter,false));
		toBeSpawned.Add (new SpawnNode(0,10,0,0.5f - offsetFromCenter,false));
		toBeSpawned.Add (new SpawnNode(0,0,0,0.5f + offsetFromCenter2,false));
		toBeSpawned.Add (new SpawnNode(15,0,0,0.5f + offsetFromCenter2,false));
		toBeSpawned.Add (new SpawnNode(15,10,0,0.5f + offsetFromCenter,false));
		toBeSpawned.Add (new SpawnNode(0,10,0,0.5f - offsetFromCenter,false));
		toBeSpawned.Add (new SpawnNode(0,0,0,0.5f + offsetFromCenter2,false));
		toBeSpawned.Add (new SpawnNode(15,0,0,0.5f + offsetFromCenter2,false));

		toBeSpawned.Add (new AffectorNode(0,true,220,0.97f,0.38f));

		toBeSpawned.Add (new SpawnNode(15,10,0,0.5f + offsetFromCenter,false));
		toBeSpawned.Add (new SpawnNode(0,10,0,0.5f - offsetFromCenter,false));
		toBeSpawned.Add (new SpawnNode(0,0,0,0.5f + offsetFromCenter2,false));
		toBeSpawned.Add (new SpawnNode(15,0,0,0.5f + offsetFromCenter2,false));



		toBeSpawned.Add (new SpawnNode(15,10,0,0.5f + offsetFromCenter,false));
		toBeSpawned.Add (new SpawnNode(0,0,0,0.5f,false));
		toBeSpawned.Add (new SpawnNode(0,10,0,0.5f - offsetFromCenter,false));
		toBeSpawned.Add (new SpawnNode(0,5,0,0.5f + offsetFromCenter2,false));
		toBeSpawned.Add (new SpawnNode(15,5,0,0.5f + offsetFromCenter2,false));
		toBeSpawned.Add (new SpawnNode(15,10,0,0.5f + offsetFromCenter,false));
		toBeSpawned.Add (new SpawnNode(0,10,0,0.5f - offsetFromCenter,false));
		toBeSpawned.Add (new SpawnNode(0,0,0,0.5f + offsetFromCenter2,false));
		toBeSpawned.Add (new SpawnNode(15,0,0,0.5f + offsetFromCenter2,false));
		toBeSpawned.Add (new SpawnNode(15,10,0,0.5f + offsetFromCenter,false));
		toBeSpawned.Add (new SpawnNode(0,0,0,0.5f,false));
		toBeSpawned.Add (new SpawnNode(0,10,0,0.5f - offsetFromCenter,false));
		toBeSpawned.Add (new SpawnNode(0,5,0,0.5f + offsetFromCenter2,false));
		toBeSpawned.Add (new SpawnNode(15,5,0,0.5f + offsetFromCenter2,false));

		toBeSpawned.Add (new SpawnNode(15,10,0,0.5f + offsetFromCenter,false));
		toBeSpawned.Add (new SpawnNode(0,10,0,0.5f - offsetFromCenter,false));
		toBeSpawned.Add (new SpawnNode(30,10,0,0.5f + offsetFromCenter,false));
		toBeSpawned.Add (new SpawnNode(0,10,0,0.5f - offsetFromCenter,false));
		toBeSpawned.Add (new SpawnNode(30,10,0,0.5f + offsetFromCenter,false));
		toBeSpawned.Add (new SpawnNode(0,10,0,0.5f - offsetFromCenter,false));
		toBeSpawned.Add (new SpawnNode(30,10,0,0.5f + offsetFromCenter,false));
		toBeSpawned.Add (new SpawnNode(0,10,0,0.5f - offsetFromCenter,false));
		toBeSpawned.Add (new SpawnNode(30,10,0,0.5f + offsetFromCenter,false));
		toBeSpawned.Add (new SpawnNode(0,10,0,0.5f - offsetFromCenter,false));toBeSpawned.Add (new SpawnNode(30,10,0,0.5f + offsetFromCenter,false));
		toBeSpawned.Add (new SpawnNode(0,10,0,0.5f - offsetFromCenter,false));

		toBeSpawned.Add (new SpawnNode(30,10,0,0.5f + offsetFromCenter,false));
		toBeSpawned.Add (new SpawnNode(0,10,0,0.5f - offsetFromCenter,false));
		toBeSpawned.Add (new SpawnNode(0,4,3,2f,false));
		toBeSpawned.Add (new SpawnNode(30,10,0,0.5f + offsetFromCenter,false));
		toBeSpawned.Add (new SpawnNode(0,10,0,0.5f - offsetFromCenter,false));
		toBeSpawned.Add (new SpawnNode(0,4,3,2f,false));
		toBeSpawned.Add (new SpawnNode(0,0,0,0.5f,false));
		toBeSpawned.Add (new SpawnNode(30,10,0,0.5f + offsetFromCenter,false));
		toBeSpawned.Add (new SpawnNode(0,10,0,0.5f - offsetFromCenter,false));
		toBeSpawned.Add (new SpawnNode(0,4,3,2f,false));
		toBeSpawned.Add (new SpawnNode(30,10,0,0.5f + offsetFromCenter,false));
		toBeSpawned.Add (new SpawnNode(0,10,0,0.5f - offsetFromCenter,false));
		toBeSpawned.Add (new SpawnNode(0,4,3,2f,false));
		toBeSpawned.Add (new SpawnNode(0,0,0,0.5f,false));
		toBeSpawned.Add (new SpawnNode(30,10,0,0.5f + offsetFromCenter,false));
		toBeSpawned.Add (new SpawnNode(0,10,0,0.5f - offsetFromCenter,false));
		toBeSpawned.Add (new SpawnNode(0,4,3,2f,false));
		toBeSpawned.Add (new SpawnNode(30,10,0,0.5f + offsetFromCenter,false));
		toBeSpawned.Add (new SpawnNode(0,10,0,0.5f - offsetFromCenter,false));
		toBeSpawned.Add (new SpawnNode(0,4,3,2f,false));
		toBeSpawned.Add (new SpawnNode(0,0,0,0.5f,false));
		toBeSpawned.Add (new SpawnNode(30,10,0,0.5f + offsetFromCenter,false));
		toBeSpawned.Add (new SpawnNode(0,10,0,0.5f - offsetFromCenter,false));
		toBeSpawned.Add (new SpawnNode(0,4,3,2f,false));
		toBeSpawned.Add (new SpawnNode(30,10,0,0.5f + offsetFromCenter,false));
		toBeSpawned.Add (new SpawnNode(0,10,0,0.5f - offsetFromCenter,false));
		toBeSpawned.Add (new SpawnNode(0,4,3,2f,false));
		toBeSpawned.Add (new SpawnNode(0,0,0,0.5f,false));
		toBeSpawned.Add (new SpawnNode(30,10,0,0.5f + offsetFromCenter,false));
		toBeSpawned.Add (new SpawnNode(0,10,0,0.5f - offsetFromCenter,false));
		toBeSpawned.Add (new SpawnNode(0,4,3,2f,false));
		toBeSpawned.Add (new SpawnNode(30,10,0,0.5f + offsetFromCenter,false));
		toBeSpawned.Add (new SpawnNode(0,10,0,0.5f - offsetFromCenter,false));
		toBeSpawned.Add (new SpawnNode(0,4,3,2f,false));
		toBeSpawned.Add (new SpawnNode(0,0,0,0.5f,false));
		toBeSpawned.Add (new SpawnNode(30,10,0,0.5f + offsetFromCenter,false));
		toBeSpawned.Add (new SpawnNode(0,10,0,0.5f - offsetFromCenter,false));


		toBeSpawned.Add (new SpawnNode(30,10,0,0.5f + offsetFromCenter,false));
		toBeSpawned.Add (new SpawnNode(0,10,0,0.5f - offsetFromCenter,false));
		toBeSpawned.Add (new SpawnNode(30,10,0,0.5f + offsetFromCenter,false));
		toBeSpawned.Add (new SpawnNode(0,10,0,0.5f - offsetFromCenter,false));
		toBeSpawned.Add (new SpawnNode(30,10,0,0.5f + offsetFromCenter,false));
		toBeSpawned.Add (new SpawnNode(0,10,0,0.5f - offsetFromCenter,false));

		toBeSpawned.Add (new SpawnNode(0,5,0,0.9f));
		toBeSpawned.Add (new SpawnNode(0,5,0,0.1f));

		toBeSpawned.Add (new SpawnNode(70,10,0,0.5f,false));
		toBeSpawned.Add (new SpawnNode(90,10,0,0.5f,false));
		toBeSpawned.Add (new SpawnNode(90,10,0,0.5f,false));
		toBeSpawned.Add (new SpawnNode(90,10,0,0.5f,false));
		toBeSpawned.Add (new SpawnNode(0,5,0,0.9f));
		toBeSpawned.Add (new SpawnNode(0,5,0,0.1f));

		toBeSpawned.Add (new SpawnNode(90,10,0,0.5f,false));
		toBeSpawned.Add (new SpawnNode(90,10,0,0.5f,false));
		toBeSpawned.Add (new SpawnNode(90,10,0,0.5f,false));
		toBeSpawned.Add (new SpawnNode(0,5,0,0.9f));
		toBeSpawned.Add (new SpawnNode(0,5,0,0.1f));
		toBeSpawned.Add (new SpawnNode(90,10,0,0.5f,false));

		toBeSpawned.Add (new WaitNode (20));
		for (int i = 0; i < 11; i++) {
			toBeSpawned.Add (new SpawnNode(0,9,2,i * 0.1f,false));
		}

		toBeSpawned.Add (new WaitNode (150));

		for(int i = 0; i < 10; i ++){
			toBeSpawned.Add (new SpawnNode(offsetBetween,4,4,2f,false));
			toBeSpawned.Add (new SpawnNode(offsetBetween,4,4,2f,false));
			toBeSpawned.Add (new SpawnNode(offsetBetween,4,4,2f,false));
			toBeSpawned.Add (new SpawnNode(offsetBetween,4,4,2f,false));
			toBeSpawned.Add (new SpawnNode(10,10,0,0.5f,false));
		}


	}

}