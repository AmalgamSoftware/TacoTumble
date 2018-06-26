using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level13 : LevelTemplate {


	protected override void LoadList (){
		toBeSpawned.Add (new SpawnNode(100,5,0,0.5f));
		toBeSpawned.Add (new SpawnNode(0,6,1,0.5f));
		toBeSpawned.Add (new SpawnNode(0,7,3,0.5f));
		//toBeSpawned.Add (new TipNode(0,9));

		for (int i = 0; i < 8; i++) {
			float f = Random.value * 0.75f;
			toBeSpawned.Add(new SpawnNode(150 - i * 12,10,0,f,false));
			toBeSpawned.Add(new SpawnNode(0,4,0,f + 0.1f,false));
			toBeSpawned.Add(new SpawnNode(0,4,0,f+ 0.175f,false));
			toBeSpawned.Add(new SpawnNode(0,10,0,f+ 0.275f,false));
			toBeSpawned.Add(new SpawnNode(30,10,0,f,false));
			toBeSpawned.Add(new SpawnNode(0,4,0,f + 0.1f,false));
			toBeSpawned.Add(new SpawnNode(0,4,0,f+ 0.175f,false));
			toBeSpawned.Add(new SpawnNode(0,10,0,f+ 0.275f,false));
		}

		toBeSpawned.Add(new SpawnNode(100,4,2,2f,false));
		for (int i = 0; i < 20; i++) {
			toBeSpawned.Add(new SpawnNode(20,4,2,2f,false));
		}

		toBeSpawned.Add(new SpawnNode(150,10,0,0.5f,false));
		toBeSpawned.Add(new SpawnNode(0,10,0,0.2f,false));
		toBeSpawned.Add(new SpawnNode(0,10,0,0.8f,false));
		toBeSpawned.Add(new SpawnNode(30,10,0,0.5f,false));
		toBeSpawned.Add(new SpawnNode(0,10,0,0.2f,false));
		toBeSpawned.Add(new SpawnNode(0,10,0,0.8f,false));
		toBeSpawned.Add(new SpawnNode(30,10,0,0.5f,false));
		toBeSpawned.Add(new SpawnNode(0,10,0,0.2f,false));
		toBeSpawned.Add(new SpawnNode(0,10,0,0.8f,false));

		toBeSpawned.Add(new SpawnNode(20,4,1,0.7f,true));
		toBeSpawned.Add(new SpawnNode(0,4,3,0.7f,true));

		toBeSpawned.Add(new SpawnNode(20,4,1,0.5f,true));
		toBeSpawned.Add(new SpawnNode(0,4,3,0.5f,true));

		toBeSpawned.Add(new SpawnNode(20,4,1,0.3f,true));
		toBeSpawned.Add(new SpawnNode(0,4,3,0.3f,true));

		toBeSpawned.Add(new SpawnNode(150,10,3,0.5f,false));
		toBeSpawned.Add(new SpawnNode(0,10,3,0.2f,false));
		toBeSpawned.Add(new SpawnNode(0,10,3,0.8f,false));
		toBeSpawned.Add(new SpawnNode(30,10,3,0.5f,false));
		toBeSpawned.Add(new SpawnNode(0,10,3,0.2f,false));
		toBeSpawned.Add(new SpawnNode(0,10,3,0.8f,false));
		toBeSpawned.Add(new SpawnNode(30,10,3,0.5f,false));
		toBeSpawned.Add(new SpawnNode(0,10,3,0.2f,false));
		toBeSpawned.Add(new SpawnNode(0,10,3,0.8f,false));

		toBeSpawned.Add(new SpawnNode(100,4,2,0.4f,false));
		toBeSpawned.Add(new SpawnNode(15,4,2,0.4f,false));
		toBeSpawned.Add(new SpawnNode(15,4,2,0.4f,false));
		toBeSpawned.Add(new SpawnNode(15,4,2,0.4f,false));
		toBeSpawned.Add(new SpawnNode(15,4,2,0.5f,false));
		toBeSpawned.Add(new SpawnNode(15,4,2,0.6f,false));
		toBeSpawned.Add(new SpawnNode(15,4,2,0.7f,false));
		toBeSpawned.Add(new SpawnNode(15,4,2,0.8f,false));
		toBeSpawned.Add(new SpawnNode(15,4,2,0.9f,false));
		toBeSpawned.Add(new SpawnNode(15,4,2,1f,false));
		toBeSpawned.Add(new SpawnNode(15,4,2,0.0f,false));
		toBeSpawned.Add(new SpawnNode(15,4,2,0.1f,false));
		toBeSpawned.Add(new SpawnNode(15,4,2,0.2f,false));
		toBeSpawned.Add(new SpawnNode(15,4,2,0.3f,false));
		toBeSpawned.Add(new SpawnNode(15,4,2,0.4f,false));
		toBeSpawned.Add(new SpawnNode(15,4,2,0.5f,false));
		toBeSpawned.Add(new SpawnNode(15,4,2,0.5f,false));
		toBeSpawned.Add(new SpawnNode(15,4,2,0.5f,false));

		toBeSpawned.Add(new SpawnNode(150,10,3,0.5f));
		toBeSpawned.Add(new SpawnNode(0,4,3,0.8f));
		toBeSpawned.Add(new SpawnNode(0,10,1,0.5f));
		toBeSpawned.Add(new SpawnNode(0,4,1,0.8f));

		toBeSpawned.Add(new SpawnNode(20,10,3,0.5f));
		toBeSpawned.Add(new SpawnNode(0,4,3,0.8f));
		toBeSpawned.Add(new SpawnNode(0,10,1,0.5f));
		toBeSpawned.Add(new SpawnNode(0,4,1,0.8f));

		toBeSpawned.Add(new SpawnNode(20,10,3,0.5f));
		toBeSpawned.Add(new SpawnNode(0,4,3,0.8f));
		toBeSpawned.Add(new SpawnNode(0,10,1,0.5f));
		toBeSpawned.Add(new SpawnNode(0,4,1,0.8f));

		toBeSpawned.Add(new SpawnNode(20,10,3,0.5f));
		toBeSpawned.Add(new SpawnNode(0,4,3,0.8f));
		toBeSpawned.Add(new SpawnNode(0,10,1,0.5f));
		toBeSpawned.Add(new SpawnNode(0,4,1,0.8f));

		toBeSpawned.Add(new SpawnNode(20,10,3,0.5f));
		toBeSpawned.Add(new SpawnNode(0,4,3,0.8f));
		toBeSpawned.Add(new SpawnNode(0,10,1,0.5f));
		toBeSpawned.Add(new SpawnNode(0,4,1,0.8f));

		for (int i = 0; i < 3; i++) {
			float f = Random.value * 0.75f;
			toBeSpawned.Add(new SpawnNode(150 - i * 12,10,0,f,false));
			toBeSpawned.Add(new SpawnNode(0,4,0,f + 0.1f,false));
			toBeSpawned.Add(new SpawnNode(0,4,0,f+ 0.175f,false));
			toBeSpawned.Add(new SpawnNode(0,10,0,f+ 0.275f,false));
			toBeSpawned.Add(new SpawnNode(30,10,0,f,false));
			toBeSpawned.Add(new SpawnNode(0,4,0,f + 0.1f,false));
			toBeSpawned.Add(new SpawnNode(0,4,0,f+ 0.175f,false));
			toBeSpawned.Add(new SpawnNode(0,10,0,f+ 0.275f,false));
		}

		toBeSpawned.Add(new SpawnNode(150,4,3,1f,false));
		toBeSpawned.Add(new SpawnNode(0,4,3,0f,false));

		toBeSpawned.Add(new SpawnNode(150,4,2,1f,false));
		toBeSpawned.Add(new SpawnNode(0,4,2,0f,false));

		toBeSpawned.Add(new SpawnNode(150,4,0,1f,false));
		toBeSpawned.Add(new SpawnNode(0,4,0,0f,false));

		toBeSpawned.Add(new SpawnNode(150,4,1,1f,false));
		toBeSpawned.Add(new SpawnNode(0,4,1,0f,false));


		toBeSpawned.Add(new SpawnNode(150,4,3,1f,false));
		for (float i = 0f; i < 1f; i += 0.1f) {
			toBeSpawned.Add(new SpawnNode(0,4,3,i,false));
		}
		toBeSpawned.Add(new SpawnNode(150,4,2,1f,false));
		for (float i = 0f; i < 1f; i += 0.1f) {
			toBeSpawned.Add(new SpawnNode(0,4,2,i,false));
		}
		toBeSpawned.Add(new SpawnNode(150,4,0,1f,false));
		for (float i = 0f; i < 1f; i += 0.1f) {
			toBeSpawned.Add(new SpawnNode(0,4,0,i,false));
		}
		toBeSpawned.Add(new SpawnNode(150,4,1,1f,false));
		for (float i = 0f; i < 1f; i += 0.1f) {
			toBeSpawned.Add(new SpawnNode(0,4,1,i,false));
		}

		toBeSpawned.Add (new SpawnNode(200,5,0,0.5f));
		toBeSpawned.Add (new SpawnNode(0,6,1,0.5f));
		toBeSpawned.Add (new SpawnNode(0,7,3,0.5f));
	}

}