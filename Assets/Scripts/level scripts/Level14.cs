using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level14 : LevelTemplate {


	protected override void LoadList (){


		toBeSpawned.Add (new SpawnNode(100,5,0,0.5f,false));
		toBeSpawned.Add (new SpawnNode(0,6,1,0.5f,false));
		toBeSpawned.Add (new SpawnNode(0,7,3,0.5f,false));
		toBeSpawned.Add (new SpawnNode(10,5,0,0.5f,false));
		toBeSpawned.Add (new SpawnNode(0,6,1,0.5f,false));
		toBeSpawned.Add (new SpawnNode(0,7,3,0.5f,false));
		toBeSpawned.Add (new TipNode(0,16));

		toBeSpawned.Add (new SpawnNode(100,1,0,0.5f,false));
		toBeSpawned.Add (new SpawnNode(0,1,0,0.9f,false));
		toBeSpawned.Add (new SpawnNode(0,1,0,0.1f,false));

		toBeSpawned.Add (new SpawnNode(15,1,0,0.5f,false));
		toBeSpawned.Add (new SpawnNode(0,1,0,0.9f,false));
		toBeSpawned.Add (new SpawnNode(0,1,0,0.1f,false));

		toBeSpawned.Add (new SpawnNode(15,1,0,0.5f,false));
		toBeSpawned.Add (new SpawnNode(0,1,0,0.9f,false));
		toBeSpawned.Add (new SpawnNode(0,1,0,0.1f,false));

		for (int i = 0; i < 10; i++) {
			int j = Random.Range (0, 4);
			toBeSpawned.Add (new SpawnNode(75,j,0,2f,false));
			toBeSpawned.Add (new SpawnNode(0,j,0,2f,true));
		}
		for (int i = 0; i < 3; i++) {
			int j = Random.Range (5, 8);
			toBeSpawned.Add (new SpawnNode(75,j,0,2f,false));
			toBeSpawned.Add (new SpawnNode(0,j,0,2f,true));
		}
		toBeSpawned.Add (new SpawnNode(150,6,3,0.5f,false));
		toBeSpawned.Add (new SpawnNode(15,6,3,0.4f,false));
		toBeSpawned.Add (new SpawnNode(0,6,3,0.6f,false));
		toBeSpawned.Add (new SpawnNode(15,6,3,0.3f,false));
		toBeSpawned.Add (new SpawnNode(0,5,3,0.5f,false));
		toBeSpawned.Add (new SpawnNode(0,10,3,0.85f,false));
		toBeSpawned.Add (new SpawnNode(0,10,3,0.15f,false));
		toBeSpawned.Add (new SpawnNode(0,6,3,0.7f,false));
		toBeSpawned.Add (new SpawnNode(15,6,3,0.4f,false));
		toBeSpawned.Add (new SpawnNode(0,6,3,0.6f,false));
		toBeSpawned.Add (new SpawnNode(15,6,3,0.5f,false));

		toBeSpawned.Add(new SpawnNode(150,9,0,1f,false));
		for (float i = 0f; i < 1f; i += 0.2f) {
			toBeSpawned.Add(new SpawnNode(0,9,0,i,false));
		}

		Bridge (150, 0, 0.5f);
		Bridge (30, 0, 0.5f);
		Bridge (30, 0, 0.5f);
		Bridge (30, 0, 0.55f);
		Bridge (30, 0, 0.6f);
		Bridge (30, 0, 0.6f);
		Bridge (30, 0, 0.6f);
		Bridge (30, 0, 0.55f);
		Bridge (30, 0, 0.5f);
		Bridge (30, 0, 0.45f);
		Bridge (30, 0, 0.4f);
		Bridge (30, 0, 0.4f);
		Bridge (30, 0, 0.4f);

		toBeSpawned.Add (new SpawnNode(150,10,3,0.9f,false));
		toBeSpawned.Add (new SpawnNode(0,10,1,0.1f,false));
		toBeSpawned.Add (new SpawnNode(20,5,3,0.9f,false));
		toBeSpawned.Add (new SpawnNode(0,5,1,0.1f,false));

		toBeSpawned.Add (new SpawnNode(150,10,1,0.9f,false));
		toBeSpawned.Add (new SpawnNode(0,10,3,0.1f,false));
		toBeSpawned.Add (new SpawnNode(20,6,1,0.9f,false));
		toBeSpawned.Add (new SpawnNode(0,6,3,0.1f,false));

		toBeSpawned.Add (new SpawnNode(150,4,3,0.1f,false));
		for (int i = 0; i < 20; i++) {
			toBeSpawned.Add (new SpawnNode(15,4,3,2f,false));
		}

		
		Bridge (150, 1, 0.5f);
		Bridge (30, 1, 0.55f);
		Bridge (30, 1, 0.6f);

		Bridge (30, 1, 0.65f);

		Bridge (30, 1, 0.7f);

		Bridge (30, 1, 0.75f);

		Bridge (30, 1, 0.8f);

		Bridge (30, 1, 0.85f);

		Bridge (30, 1, 0.15f);

		Bridge (30, 1, 0.20f);

		Bridge (30, 1, 0.25f);

		Bridge (30, 1, 0.3f);
		Bridge (30, 1, 0.35f);
		Bridge (30, 1, 0.3f);
		Bridge (30, 1, 0.25f);
		Bridge (30, 1, 0.2f);
		Bridge (30, 1, 0.15f);
		Bridge (30, 1, 0.85f);
		Bridge (30, 1, 0.80f);
		Bridge (30, 1, 0.75f);
		Bridge (30, 1, 0.7f);
		Bridge (30, 1, 0.65f);
		Bridge (30, 1, 0.6f);
		Bridge (30, 1, 0.55f);

		toBeSpawned.Add (new WaitNode(90));

		for (int i = 0; i < 10; i++) {
			int dir = Random.Range (0, 4);
			float offs = Random.value;
			toBeSpawned.Add (new SpawnNode(40,10,dir,offs,false));
			toBeSpawned.Add (new SpawnNode(20,4,dir,offs,false));
			toBeSpawned.Add (new SpawnNode(20,4,dir,offs,false));

		}

		toBeSpawned.Add (new SpawnNode(100,5,0,0.5f,false));
		toBeSpawned.Add (new SpawnNode(0,6,1,0.5f,false));
		toBeSpawned.Add (new SpawnNode(0,7,3,0.5f,false));
		toBeSpawned.Add (new SpawnNode(0,10,2,0.5f,false));


	}


	void Bridge(int timeOff, int pickuptype, float startOffset){
			//float f = Random.value * 0.725f;
		toBeSpawned.Add (new SpawnNode (timeOff, 10, 0, startOffset + 0.1375f, false));
		toBeSpawned.Add (new SpawnNode (0, pickuptype, 0, startOffset + 0.0375f, false));
		toBeSpawned.Add (new SpawnNode (0, pickuptype, 0, startOffset - 0.0375f, false));
		toBeSpawned.Add (new SpawnNode (0, 10, 0, startOffset - 0.1375f, false));

	}

}