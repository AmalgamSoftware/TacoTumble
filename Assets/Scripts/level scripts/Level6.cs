using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level6 : LevelTemplate {


	protected override void LoadList (){
		toBeSpawned.Add (new SpawnNode(100,6,0,0.5f));
		toBeSpawned.Add (new TipNode(0,7));
		toBeSpawned.Add (new SpawnNode(70,1,3,0.5f));
		toBeSpawned.Add (new SpawnNode(30,1,1,0.5f));
		toBeSpawned.Add (new SpawnNode(30,1,3,0.5f));
		toBeSpawned.Add (new SpawnNode(30,1,1,0.6f));
		toBeSpawned.Add (new SpawnNode(30,1,3,0.6f));
		toBeSpawned.Add (new SpawnNode(30,1,1,0.7f));
		toBeSpawned.Add (new SpawnNode(30,1,3,0.7f));
		toBeSpawned.Add (new SpawnNode(30,1,1,0.8f));
		toBeSpawned.Add (new SpawnNode(30,1,3,0.8f));
		toBeSpawned.Add (new SpawnNode(30,1,1,0.9f));
		toBeSpawned.Add (new SpawnNode(30,1,3,0.9f));
		toBeSpawned.Add (new SpawnNode(30,1,1,1f));
		toBeSpawned.Add (new SpawnNode(30,1,3,1f));

		toBeSpawned.Add (new SpawnNode(100,6,3,0.7f));
		toBeSpawned.Add (new SpawnNode(12,1,3,0.75f));
		toBeSpawned.Add (new SpawnNode(0,1,3,0.65f));

		toBeSpawned.Add (new SpawnNode(100,6,1,0.7f));
		toBeSpawned.Add (new SpawnNode(12,1,1,0.75f));
		toBeSpawned.Add (new SpawnNode(0,1,1,0.65f));

		toBeSpawned.Add (new SpawnNode(100,6,0,0.3f));
		toBeSpawned.Add (new SpawnNode(12,1,0,0.35f));
		toBeSpawned.Add (new SpawnNode(0,1,0,0.25f));

		toBeSpawned.Add (new SpawnNode(50,6,2,0.7f));
		toBeSpawned.Add (new SpawnNode(12,1,2,0.75f));
		toBeSpawned.Add (new SpawnNode(0,1,2,0.65f));

		toBeSpawned.Add (new SpawnNode(150,6,1,0.75f));
		toBeSpawned.Add (new SpawnNode(0,6,3,0.75f));
		toBeSpawned.Add (new SpawnNode(0,6,1,0.1f));
		toBeSpawned.Add (new SpawnNode(0,6,3,0.1f));

		toBeSpawned.Add (new SpawnNode(150,1,1,0.9f));
		toBeSpawned.Add (new SpawnNode(0,1,3,0.9f));
		toBeSpawned.Add (new SpawnNode(0,1,1,0.1f));
		toBeSpawned.Add (new SpawnNode(0,1,3,0.1f));

		toBeSpawned.Add (new SpawnNode(20,1,1,0.9f));
		toBeSpawned.Add (new SpawnNode(0,1,3,0.9f));
		toBeSpawned.Add (new SpawnNode(0,1,1,0.1f));
		toBeSpawned.Add (new SpawnNode(0,1,3,0.1f));

		toBeSpawned.Add (new SpawnNode(20,1,1,0.7f));
		toBeSpawned.Add (new SpawnNode(0,1,3,0.7f));
		toBeSpawned.Add (new SpawnNode(0,1,1,0.3f));
		toBeSpawned.Add (new SpawnNode(0,1,3,0.3f));

		toBeSpawned.Add (new SpawnNode(20,1,1,0.6f));
		toBeSpawned.Add (new SpawnNode(0,1,3,0.6f));
		toBeSpawned.Add (new SpawnNode(0,1,1,0.4f));
		toBeSpawned.Add (new SpawnNode(0,1,3,0.4f));

		toBeSpawned.Add (new SpawnNode(20,1,1,5.5f));
		toBeSpawned.Add (new SpawnNode(0,1,3,5.5f));
		toBeSpawned.Add (new SpawnNode(0,1,1,4.5f));
		toBeSpawned.Add (new SpawnNode(0,1,3,4.5f));

		toBeSpawned.Add (new SpawnNode(20,6,1,5.5f));
		toBeSpawned.Add (new SpawnNode(0,6,3,5.5f));

		toBeSpawned.Add (new SpawnNode(150,1,0,0f));
		for (int i = 1; i < 9; i++) {
			toBeSpawned.Add (new SpawnNode (10, 1, 0, i * 0.1f));
		}
		for (int i = 0; i < 10; i++) {
			toBeSpawned.Add (new SpawnNode (10, 1, 1, 1f - (i * 0.1f)));
		}
		for (int i = 0; i < 10; i++) {
			toBeSpawned.Add (new SpawnNode (10, 1, 2, 1f - i * 0.1f));
		}
		for (int i = 0; i < 10; i++) {
			toBeSpawned.Add (new SpawnNode (10, 1, 3, i * 0.1f));
		}

		toBeSpawned.Add (new SpawnNode (150, 6, 0, 0.5f));
		toBeSpawned.Add (new SpawnNode (0, 6, 1, 0.5f));
		toBeSpawned.Add (new SpawnNode (0, 6, 2, 0.5f));
		toBeSpawned.Add (new SpawnNode (0, 6, 3, 0.5f));

		toBeSpawned.Add (new SpawnNode (150, 6, 0, 1f));
		toBeSpawned.Add (new SpawnNode (150, 6, 0, 0f));
	}

}
