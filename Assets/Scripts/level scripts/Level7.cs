using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level7 : LevelTemplate {


	protected override void LoadList (){
		toBeSpawned.Add (new SpawnNode(100,7,0,0.5f));
		toBeSpawned.Add (new TipNode(0,8));
		toBeSpawned.Add (new SpawnNode(150,7,2,0f));
		toBeSpawned.Add (new SpawnNode(0,7,2,1f));

		toBeSpawned.Add (new SpawnNode(20,2,2,0f));
		toBeSpawned.Add (new SpawnNode(0,2,2,1f));

		toBeSpawned.Add (new SpawnNode(20,2,2,0f));
		toBeSpawned.Add (new SpawnNode(0,2,2,1f));

		toBeSpawned.Add (new SpawnNode(150,7,3,0.7f));
		toBeSpawned.Add (new SpawnNode(30,7,3,0.7f));
		toBeSpawned.Add (new SpawnNode(30,7,3,0.7f));

		toBeSpawned.Add (new SpawnNode(100,7,1,0.7f));
		toBeSpawned.Add (new SpawnNode(30,7,1,0.7f));
		toBeSpawned.Add (new SpawnNode(30,7,1,0.7f));

		toBeSpawned.Add (new SpawnNode(100,2,1,0.4f));
		toBeSpawned.Add (new SpawnNode(0,2,3,0.4f));

		toBeSpawned.Add (new SpawnNode(20,2,1,0.4f));
		toBeSpawned.Add (new SpawnNode(0,2,3,0.4f));

		toBeSpawned.Add (new SpawnNode(20,2,1,0.5f));
		toBeSpawned.Add (new SpawnNode(0,2,3,0.5f));

		toBeSpawned.Add (new SpawnNode(20,2,1,0.6f));
		toBeSpawned.Add (new SpawnNode(0,2,3,0.6f));

		toBeSpawned.Add (new SpawnNode(20,2,1,0.7f));
		toBeSpawned.Add (new SpawnNode(0,2,3,0.7f));

		toBeSpawned.Add (new SpawnNode(20,2,1,0.8f));
		toBeSpawned.Add (new SpawnNode(0,2,3,0.8f));

		toBeSpawned.Add (new SpawnNode(20,7,1,1f));
		toBeSpawned.Add (new SpawnNode(0,7,3,1f));


		toBeSpawned.Add (new SpawnNode(50,6,0,0.65f));
		toBeSpawned.Add (new SpawnNode(50,6,0,0.35f));
		toBeSpawned.Add (new SpawnNode(50,6,0,0.65f));
		toBeSpawned.Add (new SpawnNode(50,6,0,0.35f));
		toBeSpawned.Add (new SpawnNode(50,6,0,0.65f));
		toBeSpawned.Add (new SpawnNode(50,6,0,0.35f));
		toBeSpawned.Add (new SpawnNode(50,6,0,0.65f));

		toBeSpawned.Add (new SpawnNode(100,7,0,0.35f));
		for (float i = 0.9f; i > 0; i -= 0.1f) {
			toBeSpawned.Add (new SpawnNode(10,2,1,i));
			toBeSpawned.Add (new SpawnNode(0,2,3,i));
		}

		toBeSpawned.Add (new SpawnNode(150,7,0,0.35f));
		toBeSpawned.Add (new SpawnNode(0,7,0,0.65f));

		for (int i = 0; i < 30; i++) {
			toBeSpawned.Add (new SpawnNode(30,2,4));
		}
		for (int i = 0; i < 10; i++) {
			toBeSpawned.Add (new SpawnNode(15,2,0));
		}

		toBeSpawned.Add (new SpawnNode(150,7,2,0.5f));

		for (int i = 0; i < 5; i++) {
			toBeSpawned.Add (new SpawnNode(20,2,2,0.5f + (i+1) * 0.1f));
			toBeSpawned.Add (new SpawnNode(0,2,2,0.5f - (i+1) * 0.1f));
		}

		toBeSpawned.Add (new SpawnNode(150,7,1,0.5f));
		toBeSpawned.Add (new SpawnNode(0,7,3,0.5f));

		toBeSpawned.Add (new SpawnNode(40,7,2,0.5f));
		toBeSpawned.Add (new SpawnNode(0,7,0,0.5f));

		toBeSpawned.Add (new SpawnNode(100,2,2,0.5f));

		for (int i = 0; i < 9; i++) {
			toBeSpawned.Add (new SpawnNode(0,2,2));
		}
	
	}

}
