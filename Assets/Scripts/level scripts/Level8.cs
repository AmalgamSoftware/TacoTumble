using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level8 : LevelTemplate {


	protected override void LoadList (){
		toBeSpawned.Add (new SpawnNode(100,5,0,0.5f));
		toBeSpawned.Add (new SpawnNode(0,6,1,0.5f));
		toBeSpawned.Add (new SpawnNode(0,7,3,0.5f));
		toBeSpawned.Add (new TipNode(0,9));


		toBeSpawned.Add (new SpawnNode(100,5,2,0f));
		toBeSpawned.Add (new SpawnNode(40,6,2,0.5f));
		toBeSpawned.Add (new SpawnNode(40,7,2,1f));
		toBeSpawned.Add (new SpawnNode(40,0,2,0f));
		toBeSpawned.Add (new SpawnNode(40,1,2,0.5f));
		toBeSpawned.Add (new SpawnNode(40,2,2,1f));
		toBeSpawned.Add (new SpawnNode(40,0,2,0f));
		toBeSpawned.Add (new SpawnNode(40,1,2,0.5f));
		toBeSpawned.Add (new SpawnNode(40,2,2,1f));
		toBeSpawned.Add (new SpawnNode(40,0,2,0f));
		toBeSpawned.Add (new SpawnNode(40,1,2,0.5f));
		toBeSpawned.Add (new SpawnNode(40,2,2,1f));

		toBeSpawned.Add (new SpawnNode(30,0,2,0f));
		toBeSpawned.Add (new SpawnNode(30,1,2,0.5f));
		toBeSpawned.Add (new SpawnNode(30,2,2,1f));

		toBeSpawned.Add (new SpawnNode(30,4,2,0f));
		toBeSpawned.Add (new SpawnNode(30,4,2,0.5f));
		toBeSpawned.Add (new SpawnNode(30,4,2,1f));

		toBeSpawned.Add (new SpawnNode(30,4,2,0f));
		toBeSpawned.Add (new SpawnNode(30,4,2,0.5f));
		toBeSpawned.Add (new SpawnNode(30,4,2,1f));

		toBeSpawned.Add (new SpawnNode(20,4,2,0f));
		toBeSpawned.Add (new SpawnNode(20,4,2,0.5f));
		toBeSpawned.Add (new SpawnNode(20,4,2,1f));

		toBeSpawned.Add (new SpawnNode(20,4,2,1f));
		toBeSpawned.Add (new SpawnNode(20,4,2,0.5f));
		toBeSpawned.Add (new SpawnNode(20,4,2,0f));

		toBeSpawned.Add (new SpawnNode(20,4,2,1f));
		toBeSpawned.Add (new SpawnNode(20,4,2,0.5f));
		toBeSpawned.Add (new SpawnNode(20,4,2,0f));

		toBeSpawned.Add (new SpawnNode(10,4,2,1f));
		toBeSpawned.Add (new SpawnNode(10,4,2,0.5f));
		toBeSpawned.Add (new SpawnNode(10,4,2,0f));

		toBeSpawned.Add (new SpawnNode(10,4,2,1f));
		toBeSpawned.Add (new SpawnNode(10,4,2,0.5f));
		toBeSpawned.Add (new SpawnNode(10,4,2,0f));

		toBeSpawned.Add (new SpawnNode(10,4,2,1f));
		toBeSpawned.Add (new SpawnNode(10,4,2,0.5f));
		toBeSpawned.Add (new SpawnNode(10,4,2,0f));

		toBeSpawned.Add (new SpawnNode(100,4,3,0.5f));
		for (float f = 0f; f < 1f; f += 0.1f) {
			toBeSpawned.Add (new SpawnNode(0,3,2,f));
		}

		toBeSpawned.Add (new SpawnNode(50,true));
		toBeSpawned.Add (new SpawnNode(50,true));
		toBeSpawned.Add (new SpawnNode(50,true));
		toBeSpawned.Add (new SpawnNode(50,true));
		toBeSpawned.Add (new SpawnNode(50,true));
		toBeSpawned.Add (new SpawnNode(50,true));
		toBeSpawned.Add (new SpawnNode(50,true));
		toBeSpawned.Add (new SpawnNode(50,true));
		toBeSpawned.Add (new SpawnNode(50,true));
		toBeSpawned.Add (new SpawnNode(50,true));

		toBeSpawned.Add (new SpawnNode(100,5,0,0.1f));

		for (int i = 0; i < 10; i++) {
			toBeSpawned.Add (new SpawnNode(10,5,0,0.1f));
		}

		toBeSpawned.Add (new SpawnNode(100,7,0,0.5f));

		for (int i = 0; i < 10; i++) {
			toBeSpawned.Add (new SpawnNode(10,7,0,0.5f));
		}

		toBeSpawned.Add (new SpawnNode(100,6,0,0.9f));

		for (int i = 0; i < 10; i++) {
			toBeSpawned.Add (new SpawnNode(10,6,0,0.9f));
		}

		toBeSpawned.Add (new SpawnNode(150,4,3,1f));
		toBeSpawned.Add (new SpawnNode(20,4,1,0.95f));
		toBeSpawned.Add (new SpawnNode(20,4,3,0.9f));
		toBeSpawned.Add (new SpawnNode(20,4,1,0.85f));
		toBeSpawned.Add (new SpawnNode(20,4,3,0.8f));
		toBeSpawned.Add (new SpawnNode(20,4,1,0.75f));
		toBeSpawned.Add (new SpawnNode(20,4,3,0.7f));
		toBeSpawned.Add (new SpawnNode(20,4,1,0.65f));
		toBeSpawned.Add (new SpawnNode(20,4,3,0.6f));
		toBeSpawned.Add (new SpawnNode(20,4,1,0.55f));
		toBeSpawned.Add (new SpawnNode(20,4,3,0.5f));
		toBeSpawned.Add (new SpawnNode(20,4,1,0.45f));
		toBeSpawned.Add (new SpawnNode(20,4,3,0.4f));
		toBeSpawned.Add (new SpawnNode(20,4,1,0.35f));
		toBeSpawned.Add (new SpawnNode(20,4,3,0.3f));
		toBeSpawned.Add (new SpawnNode(20,4,1,0.25f));
		toBeSpawned.Add (new SpawnNode(20,4,3,0.2f));
		toBeSpawned.Add (new SpawnNode(20,4,1,0.15f));
		toBeSpawned.Add (new SpawnNode(20,4,3,0.1f));
		toBeSpawned.Add (new SpawnNode(20,4,1,0.0f));

		toBeSpawned.Add (new SpawnNode(100,0,2,0.1f));

		for (int i = 0; i < 10; i++) {
			toBeSpawned.Add (new SpawnNode(10,0,2,0.1f));
		}

		toBeSpawned.Add (new SpawnNode(100,2,2,0.5f));

		for (int i = 0; i < 10; i++) {
			toBeSpawned.Add (new SpawnNode(10,2,2,0.5f));
		}

		toBeSpawned.Add (new SpawnNode(100,1,2,0.9f));

		for (int i = 0; i < 10; i++) {
			toBeSpawned.Add (new SpawnNode(10,1,2,0.9f));
		}




		for (int i = 0; i < 10; i++) {
			toBeSpawned.Add (new SpawnNode(0,4,1,i * 0.1f));
		}
		for (int i = 0; i < 10; i++) {
			toBeSpawned.Add (new SpawnNode(0,4,3,i * 0.1f));
		}

		for (int i = 0; i < 40; i++) {
			toBeSpawned.Add (new SpawnNode(15,4,4));
		}

		for (float f = 0f; f < 1f; f += 0.1f) {
			toBeSpawned.Add (new SpawnNode(0,3,2,f));
		}

		toBeSpawned.Add (new SpawnNode(200,5,0,0.5f));
		toBeSpawned.Add (new SpawnNode(0,6,1,0.5f));
		toBeSpawned.Add (new SpawnNode(0,7,3,0.5f));



	}

}
