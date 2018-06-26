using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level5 : LevelTemplate {


	protected override void LoadList (){
		
		toBeSpawned.Add (new SpawnNode(100,5,0,0.5f));
		toBeSpawned.Add (new TipNode(0,6));

		toBeSpawned.Add (new SpawnNode(50,0,2,0.1f));
		toBeSpawned.Add (new SpawnNode(50,0,2,0.9f));

		toBeSpawned.Add (new SpawnNode(50,0,2,0.2f));
		toBeSpawned.Add (new SpawnNode(15,0,2,0.1f));
		toBeSpawned.Add (new SpawnNode(0,0,2,0.3f));

		toBeSpawned.Add (new SpawnNode(50,0,2,0.8f));
		toBeSpawned.Add (new SpawnNode(15,0,2,0.7f));
		toBeSpawned.Add (new SpawnNode(0,0,2,0.9f));

		toBeSpawned.Add (new SpawnNode(50,5,1,1f));
		toBeSpawned.Add (new SpawnNode(0,5,3,1f));
		toBeSpawned.Add (new SpawnNode(0,0,4));

		toBeSpawned.Add (new SpawnNode(70,5,1,0.5f));
		toBeSpawned.Add (new SpawnNode(0,5,3,0.5f));
		toBeSpawned.Add (new SpawnNode(0,0,4));

		toBeSpawned.Add (new SpawnNode(70,5,4));
		toBeSpawned.Add (new SpawnNode(0,5,4));
		toBeSpawned.Add (new SpawnNode(0,0,4));

		for (int i = 0; i < 7; i++) {
			toBeSpawned.Add (new SpawnNode(30,0,4));
			toBeSpawned.Add (new SpawnNode(30,5,4));
			toBeSpawned.Add (new SpawnNode(30,0,4));
			toBeSpawned.Add (new SpawnNode(30,5,4));
		}
		toBeSpawned.Add (new SpawnNode(100,5,2,0.5f));
		for (int i = 0; i < 5; i++) {
			int j = 0;
			if (i % 2 == 0) {
				j = 5;
			}
			toBeSpawned.Add (new SpawnNode(20,j,2,0.5f + (i+1) * 0.1f));
			toBeSpawned.Add (new SpawnNode(0,j,2,0.5f - (i+1) * 0.1f));
		}
		for (int i = 0; i < 30; i++) {
			
			toBeSpawned.Add (new SpawnNode(20,0,2,0.5f));

			toBeSpawned.Add (new SpawnNode(0,0,0,0.5f));
		}
		toBeSpawned.Add (new SpawnNode(20,5,1,0.5f));
		toBeSpawned.Add (new SpawnNode(0,5,2,0.5f));
		toBeSpawned.Add (new SpawnNode(0,5,3,0.5f));
		toBeSpawned.Add (new SpawnNode(0,5,0,0.5f));
		for (int i = 0; i < 20; i++) {
			toBeSpawned.Add (new SpawnNode(20,0,1,0.5f));
			toBeSpawned.Add (new SpawnNode(0,0,3,0.5f));
		}
		toBeSpawned.Add (new SpawnNode(250,5,0,0.5f));

	}

}
