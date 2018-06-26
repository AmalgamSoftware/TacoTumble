using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level4 : LevelTemplate {


	protected override void LoadList (){
		toBeSpawned.Add (new SpawnNode(100,3,0,0.5f));
		toBeSpawned.Add (new TipNode(0,5));
		toBeSpawned.Add (new SpawnNode(50,3,0,0.75f));
		toBeSpawned.Add (new SpawnNode(0,3,0,0.25f));
		toBeSpawned.Add (new SpawnNode(50,3,0,0.0f));
		toBeSpawned.Add (new SpawnNode(0,3,0,0.0f));
		toBeSpawned.Add (new SpawnNode(50,3,0,0.75f));
		toBeSpawned.Add (new SpawnNode(0,3,0,0.25f));
		toBeSpawned.Add (new SpawnNode(50,3,0,0.40f));
		toBeSpawned.Add (new SpawnNode(0,3,0,0.60f));

		toBeSpawned.Add (new SpawnNode(70,3,2,0.5f));
		toBeSpawned.Add (new SpawnNode(10,3,2,0.5f));
		toBeSpawned.Add (new SpawnNode(10,3,2,0.5f));
		toBeSpawned.Add (new SpawnNode(10,3,2,0.5f));
		toBeSpawned.Add (new SpawnNode(10,3,2,0.5f));
		toBeSpawned.Add (new SpawnNode(10,3,2,0.5f));
		toBeSpawned.Add (new SpawnNode(10,3,2,0.5f));
		toBeSpawned.Add (new SpawnNode(10,3,2,0.4f));
		toBeSpawned.Add (new SpawnNode(10,3,2,0.3f));
		toBeSpawned.Add (new SpawnNode(10,3,2,0.2f));
		toBeSpawned.Add (new SpawnNode(10,3,2,0.1f));
		toBeSpawned.Add (new SpawnNode(10,3,2,0.0f));
		toBeSpawned.Add (new SpawnNode(10,3,2,0.1f));
		toBeSpawned.Add (new SpawnNode(10,3,2,0.2f));
		toBeSpawned.Add (new SpawnNode(10,3,2,0.3f));
		toBeSpawned.Add (new SpawnNode(10,3,2,0.4f));
		toBeSpawned.Add (new SpawnNode(10,3,2,0.5f));
		toBeSpawned.Add (new SpawnNode(10,3,2,0.6f));
		toBeSpawned.Add (new SpawnNode(10,3,2,0.7f));
		toBeSpawned.Add (new SpawnNode(10,3,2,0.8f));
		toBeSpawned.Add (new SpawnNode(10,3,2,0.9f));
		toBeSpawned.Add (new SpawnNode(10,3,2,1f));
		toBeSpawned.Add (new SpawnNode(10,3,2,0.9f));
		toBeSpawned.Add (new SpawnNode(10,3,2,0.8f));
		toBeSpawned.Add (new SpawnNode(10,3,2,0.7f));
		toBeSpawned.Add (new SpawnNode(10,3,2,0.6f));
		toBeSpawned.Add (new SpawnNode(10,3,2,0.58f));
		toBeSpawned.Add (new SpawnNode(10,3,2,0.56f));
		toBeSpawned.Add (new SpawnNode(10,3,2,0.54f));
		toBeSpawned.Add (new SpawnNode(10,3,2,0.52f));
		toBeSpawned.Add (new SpawnNode(10,3,2,0.5f));

		toBeSpawned.Add (new SpawnNode(10,3,2,0.5f));
		for (int i = 0; i < 20; i++) {
			toBeSpawned.Add (new SpawnNode(2,4,2));
		}
		for (int i = 0; i < 25; i++) {
			toBeSpawned.Add (new SpawnNode(30,false));
		}
			
		toBeSpawned.Add (new SpawnNode(10,3,2,0.5f));
		toBeSpawned.Add (new SpawnNode(10,4,2,0.6f));
		toBeSpawned.Add (new SpawnNode(10,4,2,0.7f));
		toBeSpawned.Add (new SpawnNode(10,4,2,0.8f));
		toBeSpawned.Add (new SpawnNode(10,4,2,0.9f));
		toBeSpawned.Add (new SpawnNode(10,4,2,1f));
		toBeSpawned.Add (new SpawnNode(10,4,2,0.9f));
		toBeSpawned.Add (new SpawnNode(10,4,2,0.8f));
		toBeSpawned.Add (new SpawnNode(10,4,2,0.7f));
		toBeSpawned.Add (new SpawnNode(10,4,2,0.6f));
		toBeSpawned.Add (new SpawnNode(10,4,2,0.5f));
		toBeSpawned.Add (new SpawnNode(10,4,2,0.4f));
		toBeSpawned.Add (new SpawnNode(10,4,2,0.3f));
		toBeSpawned.Add (new SpawnNode(10,4,2,0.2f));
		toBeSpawned.Add (new SpawnNode(10,4,2,0.1f));
		toBeSpawned.Add (new SpawnNode(10,4,2,0.0f));
		toBeSpawned.Add (new SpawnNode(10,4,2,0.1f));
		toBeSpawned.Add (new SpawnNode(10,4,2,0.2f));
		toBeSpawned.Add (new SpawnNode(10,4,2,0.3f));
		toBeSpawned.Add (new SpawnNode(10,4,2,0.4f));
		toBeSpawned.Add (new SpawnNode(10,4,2,0.5f));
		for (float i = 0.4f; i < 0.6f; i+= 0.1f) {
			toBeSpawned.Add (new SpawnNode(5,4,2,i));
		}
		toBeSpawned.Add (new SpawnNode(100,0,0,0.5f));
		toBeSpawned.Add (new SpawnNode(0,1,1,0.5f));
		toBeSpawned.Add (new SpawnNode(0,2,2,0.5f));
		toBeSpawned.Add (new SpawnNode(0,3,3,0.5f));

	}

}
