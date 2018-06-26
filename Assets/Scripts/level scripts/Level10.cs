using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level10 : LevelTemplate {


	protected override void LoadList (){
		toBeSpawned.Add(new SpawnNode(100,7,0,0.2f));
		toBeSpawned.Add (new TipNode(0,12));
		for (int i = 0; i < 10; i++) {
			toBeSpawned.Add (new SpawnNode (15, 7, 0, 0.2f));
		}
		toBeSpawned.Add (new SpawnNode (50, 9, 0, 0.8f));

		toBeSpawned.Add (new SpawnNode (150, 2, 2, 0.05f));
		for (int i = 0; i < 20; i++) {
			toBeSpawned.Add (new SpawnNode (10, 2, 2, i * 0.05f));
		}
		for (int i = 0; i < 20; i++) {
			toBeSpawned.Add (new SpawnNode (10, 2, 2, 1f - i * 0.05f));
		}

		toBeSpawned.Add (new SpawnNode (150, 1, 0, 0.05f));
		toBeSpawned.Add (new SpawnNode (0, 1, 0, 0.1f));

		toBeSpawned.Add (new SpawnNode (30, 1, 0, 0.05f));
		toBeSpawned.Add (new SpawnNode (0, 1, 0, 0.1f));

		toBeSpawned.Add (new SpawnNode (30, 1, 0, 0.95f));
		toBeSpawned.Add (new SpawnNode (0, 1, 0, 0.9f));

		toBeSpawned.Add (new SpawnNode (30, 1, 0, 0.95f));
		toBeSpawned.Add (new SpawnNode (0, 1, 0, 0.9f));

		toBeSpawned.Add (new SpawnNode (30, 1, 0, 0.47f));
		toBeSpawned.Add (new SpawnNode (0, 1, 0, 0.53f));

		toBeSpawned.Add (new SpawnNode (30, 1, 0, 0.47f));
		toBeSpawned.Add (new SpawnNode (0, 1, 0, 0.53f));

		toBeSpawned.Add (new SpawnNode (30, 1, 3, 0.9f));
		toBeSpawned.Add (new SpawnNode (0, 1, 3, 0.8f));

		toBeSpawned.Add (new SpawnNode (30, 1, 3, 0.9f));
		toBeSpawned.Add (new SpawnNode (0, 1, 3, 0.8f));

		toBeSpawned.Add (new SpawnNode (30, 1, 1, 0.1f));
		toBeSpawned.Add (new SpawnNode (0, 1, 1, 0.2f));

		toBeSpawned.Add (new SpawnNode (30, 1, 1, 0.1f));
		toBeSpawned.Add (new SpawnNode (0, 1, 1, 0.2f));

		toBeSpawned.Add (new SpawnNode (45, 5, 0, 0.8f));



		for (int i = 0; i < 10; i++) {
			toBeSpawned.Add (new SpawnNode (15, 5, 0, 0.8f));
		}

		toBeSpawned.Add (new SpawnNode (15, 9, 1, 0.5f));
		toBeSpawned.Add (new SpawnNode (15, 9, 3, 0.5f));

		for (int i = 0; i < 30; i++) {
			toBeSpawned.Add (new SpawnNode (20, 4, 4, 0.5f));
		}

		for (int i = 0; i < 6; i++) {
			toBeSpawned.Add (new SpawnNode (15, 0, 0, i * 0.2f));
			toBeSpawned.Add (new SpawnNode (15, 0, 0, i * 0.2f));
			toBeSpawned.Add (new SpawnNode (15, 0, 0, i * 0.2f));
			toBeSpawned.Add (new SpawnNode (15, 0, 0, i * 0.2f));
			toBeSpawned.Add (new SpawnNode (15, 0, 0, i * 0.2f));
		}

		for (int i = 0; i < 10; i++) {
			toBeSpawned.Add (new SpawnNode (15, 7, 0, 0.2f));
		}

		for (int i = 0; i < 10; i++) {
			toBeSpawned.Add (new SpawnNode (15, 6, 0, 0.5f + i * 0.05f));
		}
		toBeSpawned.Add (new SpawnNode (15, 9, 3, 0.5f));

		toBeSpawned.Add (new SpawnNode (150, 6, 4, 0.5f));
		for (int i = 0; i < 10; i++) {
			toBeSpawned.Add (new SpawnNode (15, 6, 4, 0.5f + i * 0.05f));
		}

		toBeSpawned.Add (new SpawnNode (150, 9, 2, 0.3f));
		toBeSpawned.Add (new SpawnNode (0, 9, 2, 0.7f));

		toBeSpawned.Add (new SpawnNode (200, false));

		for (int i = 0; i < 100; i++) {
			toBeSpawned.Add (new SpawnNode (15, false));
		}
		for (int i = 0; i < 5; i++) {
			toBeSpawned.Add (new SpawnNode (15, true));
			toBeSpawned.Add (new SpawnNode (15, true));
			toBeSpawned.Add (new SpawnNode (15, true));
			toBeSpawned.Add (new SpawnNode (15, true));
			toBeSpawned.Add (new SpawnNode (15,9,4));
		}

		toBeSpawned.Add (new SpawnNode (200, 9, 0,0.5f));
		toBeSpawned.Add (new SpawnNode (0, 8, 2,0.5f));
		toBeSpawned.Add (new SpawnNode (0, 8, 2,0.6f));
		toBeSpawned.Add (new SpawnNode (0, 8, 2,0.4f));
	}

}