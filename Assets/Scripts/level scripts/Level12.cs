using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level12 : LevelTemplate {


	protected override void LoadList (){
		
		toBeSpawned.Add (new SpawnNode(100,0,0,0.5f));
		toBeSpawned.Add (new SpawnNode(0,1,1,0.5f));
		toBeSpawned.Add (new SpawnNode(0,2,3,0.5f));
		toBeSpawned.Add (new SpawnNode(0,3,2,0.5f));
		toBeSpawned.Add (new TipNode(0,9));

		for (int i = 0; i < 5; i++) {
			float f = Random.value;
			toBeSpawned.Add (new SpawnNode(100,10,0,f,false));
			toBeSpawned.Add (new SpawnNode(30,0,0,f,false));
		}
		for (int i = 0; i < 5; i++) {
			float f = Random.value;
			toBeSpawned.Add (new SpawnNode(100,10,2,f,false));
			toBeSpawned.Add (new SpawnNode(30,1,2,f,false));
			toBeSpawned.Add (new SpawnNode(30,10,2,f,false));
		}
		toBeSpawned.Add (new SpawnNode(100,10,0,0.5f,false));
		toBeSpawned.Add (new SpawnNode(30,2,0,0.5f,false));
		toBeSpawned.Add (new SpawnNode(0,10,0,0.6f,false));
		toBeSpawned.Add (new SpawnNode(30,10,0,0.5f,false));

		toBeSpawned.Add (new SpawnNode(100,10,0,0.2f,false));
		toBeSpawned.Add (new SpawnNode(30,2,0,0.2f,false));
		toBeSpawned.Add (new SpawnNode(0,10,0,0.1f,false));
		toBeSpawned.Add (new SpawnNode(30,10,0,0.2f,false));

		toBeSpawned.Add (new SpawnNode(100,10,0,0.8f,false));
		toBeSpawned.Add (new SpawnNode(30,2,0,0.8f,false));
		toBeSpawned.Add (new SpawnNode(0,10,0,0.9f,false));
		toBeSpawned.Add (new SpawnNode(30,10,0,0.8f,false));

		toBeSpawned.Add (new SpawnNode(100,10,0,0.5f,false));
		toBeSpawned.Add (new SpawnNode(30,2,0,0.5f,false));
		toBeSpawned.Add (new SpawnNode(0,10,0,0.6f,false));
		toBeSpawned.Add (new SpawnNode(30,10,0,0.5f,false));

		toBeSpawned.Add (new SpawnNode(100,10,0,0.5f,false));
		toBeSpawned.Add (new SpawnNode(30,2,0,0.5f,false));
		toBeSpawned.Add (new SpawnNode(0,10,0,0.4f,false));
		toBeSpawned.Add (new SpawnNode(30,10,0,0.5f,false));


		toBeSpawned.Add (new SpawnNode(200,10,0,0.5f,false));
		toBeSpawned.Add (new SpawnNode(30,10,0,0.5f,false));
		toBeSpawned.Add (new SpawnNode(0,3,0,0.8f,true));
		toBeSpawned.Add (new SpawnNode(30,10,0,0.5f,false));
		toBeSpawned.Add (new SpawnNode(30,10,0,0.5f,false));
		toBeSpawned.Add (new SpawnNode(30,10,0,0.5f,false));
		toBeSpawned.Add (new SpawnNode(30,10,0,0.5f,false));
		toBeSpawned.Add (new SpawnNode(30,10,0,0.5f,false));
		toBeSpawned.Add (new SpawnNode(30,10,0,0.5f,false));
		toBeSpawned.Add (new SpawnNode(0,10,1,0.5f,false));
		toBeSpawned.Add (new SpawnNode(0,3,0,0.7f,true));
		toBeSpawned.Add (new SpawnNode(30,10,0,0.5f,false));
		toBeSpawned.Add (new SpawnNode(0,10,1,0.5f,false));
		toBeSpawned.Add (new SpawnNode(30,10,0,0.5f,false));
		toBeSpawned.Add (new SpawnNode(0,10,1,0.5f,false));
		toBeSpawned.Add (new SpawnNode(30,10,0,0.5f,false));
		toBeSpawned.Add (new SpawnNode(0,10,1,0.5f,false));
		toBeSpawned.Add (new SpawnNode(30,10,0,0.5f,false));
		toBeSpawned.Add (new SpawnNode(0,10,1,0.5f,false));
		toBeSpawned.Add (new SpawnNode(0,3,0,0.7f,true));
		toBeSpawned.Add (new SpawnNode(30,10,0,0.5f,false));
		toBeSpawned.Add (new SpawnNode(0,10,1,0.5f,false));
		toBeSpawned.Add (new SpawnNode(30,10,0,0.5f,false));
		toBeSpawned.Add (new SpawnNode(0,10,1,0.5f,false));
		toBeSpawned.Add (new SpawnNode(30,10,0,0.5f,false));
		toBeSpawned.Add (new SpawnNode(0,10,1,0.5f,false));
		toBeSpawned.Add (new SpawnNode(30,10,0,0.5f,false));
		toBeSpawned.Add (new SpawnNode(0,10,1,0.5f,false));
		toBeSpawned.Add (new SpawnNode(30,10,1,0.5f,false));
		toBeSpawned.Add (new SpawnNode(30,10,1,0.5f,false));
		toBeSpawned.Add (new SpawnNode(0,3,0,0.3f,true));
		toBeSpawned.Add (new SpawnNode(30,10,1,0.5f,false));
		toBeSpawned.Add (new SpawnNode(0,3,0,0.3f,true));
		toBeSpawned.Add (new SpawnNode(0,3,0,0.4f,true));
		toBeSpawned.Add (new SpawnNode(30,10,0,0.5f,false));
		toBeSpawned.Add (new SpawnNode(0,10,1,0.5f,false));
		toBeSpawned.Add (new SpawnNode(30,10,0,0.5f,false));
		toBeSpawned.Add (new SpawnNode(0,10,1,0.5f,false));
		toBeSpawned.Add (new SpawnNode(30,10,0,0.5f,false));
		toBeSpawned.Add (new SpawnNode(0,10,1,0.5f,false));
		toBeSpawned.Add (new SpawnNode(30,10,0,0.5f,false));
		toBeSpawned.Add (new SpawnNode(0,10,1,0.5f,false));
		toBeSpawned.Add (new SpawnNode(30,10,0,0.5f,false));
		toBeSpawned.Add (new SpawnNode(0,10,1,0.5f,false));
		toBeSpawned.Add (new SpawnNode(30,10,0,0.5f,false));
		toBeSpawned.Add (new SpawnNode(0,10,1,0.5f,false));
		toBeSpawned.Add (new SpawnNode(30,10,0,0.5f,false));
		toBeSpawned.Add (new SpawnNode(30,10,0,0.5f,false));



		for (int i = 0; i<6; i ++) {
			toBeSpawned.Add (new SpawnNode(0,3,1,i * 0.2f,false));
		}

		toBeSpawned.Add (new SpawnNode(30,10,0,0.5f,false));
		toBeSpawned.Add (new SpawnNode(30,10,0,0.5f,false));
		toBeSpawned.Add (new SpawnNode(30,10,0,0.5f,false));
		toBeSpawned.Add (new SpawnNode(30,10,0,0.5f,false));
		toBeSpawned.Add (new SpawnNode(30,10,0,0.5f,false));
		toBeSpawned.Add (new SpawnNode(30,10,0,0.5f,false));
		toBeSpawned.Add (new SpawnNode(30,10,0,0.5f,false));
		toBeSpawned.Add (new SpawnNode(30,10,0,0.5f,false));
		toBeSpawned.Add (new SpawnNode(30,10,0,0.5f,false));

		toBeSpawned.Add (new SpawnNode(30,10,0,0.5f,false));
		toBeSpawned.Add (new SpawnNode(0,10,0,0.2f,false));
		toBeSpawned.Add (new SpawnNode(30,10,0,0.5f,false));
		toBeSpawned.Add (new SpawnNode(0,2,0,0.2f,false));
		toBeSpawned.Add (new SpawnNode(0,10,0,0.3f,false));
		toBeSpawned.Add (new SpawnNode(30,10,0,0.5f,false));
		toBeSpawned.Add (new SpawnNode(0,10,0,0.2f,false));

		toBeSpawned.Add (new SpawnNode(30,10,0,0.5f,false));
		toBeSpawned.Add (new SpawnNode(0,10,0,0.2f,false));
		toBeSpawned.Add (new SpawnNode(30,10,0,0.5f,false));
		toBeSpawned.Add (new SpawnNode(0,2,0,0.2f,false));
		toBeSpawned.Add (new SpawnNode(0,10,0,0.1f,false));
		toBeSpawned.Add (new SpawnNode(30,10,0,0.5f,false));
		toBeSpawned.Add (new SpawnNode(0,10,0,0.2f,false));

		toBeSpawned.Add (new SpawnNode(30,10,0,0.5f,false));
		toBeSpawned.Add (new SpawnNode(30,10,0,0.5f,false));

		toBeSpawned.Add (new SpawnNode(200,10,0,0.3f,false));
		toBeSpawned.Add (new SpawnNode(0,10,0,0.7f,false));
		toBeSpawned.Add (new SpawnNode(30,10,0,0.4f,false));
		toBeSpawned.Add (new SpawnNode(0,10,0,0.6f,false));
		toBeSpawned.Add (new SpawnNode(0,10,0,0.2f,false));
		toBeSpawned.Add (new SpawnNode(0,10,0,0.8f,false));
		toBeSpawned.Add (new SpawnNode(0,0,0,0.3f,false));
		toBeSpawned.Add (new SpawnNode(0,0,0,0.7f,false));

		toBeSpawned.Add (new SpawnNode(100,10,0,0.3f,false));
		toBeSpawned.Add (new SpawnNode(0,10,0,0.7f,false));
		toBeSpawned.Add (new SpawnNode(30,10,0,0.4f,false));
		toBeSpawned.Add (new SpawnNode(0,10,0,0.6f,false));
		toBeSpawned.Add (new SpawnNode(0,10,0,0.2f,false));
		toBeSpawned.Add (new SpawnNode(0,10,0,0.8f,false));
		toBeSpawned.Add (new SpawnNode(0,1,0,0.3f,false));
		toBeSpawned.Add (new SpawnNode(0,1,0,0.7f,false));

		toBeSpawned.Add (new SpawnNode(200,10,2,0.3f,false));
		toBeSpawned.Add (new SpawnNode(0,10,2,0.7f,false));
		toBeSpawned.Add (new SpawnNode(30,10,2,0.4f,false));
		toBeSpawned.Add (new SpawnNode(0,10,2,0.6f,false));
		toBeSpawned.Add (new SpawnNode(0,10,2,0.2f,false));
		toBeSpawned.Add (new SpawnNode(0,10,2,0.8f,false));
		toBeSpawned.Add (new SpawnNode(0,1,2,0.3f,false));
		toBeSpawned.Add (new SpawnNode(0,1,2,0.7f,false));

		toBeSpawned.Add (new SpawnNode(100,0,0,0.5f,false));
		toBeSpawned.Add (new SpawnNode(0,1,1,0.5f,false));
		toBeSpawned.Add (new SpawnNode(0,2,3,0.5f,false));
		toBeSpawned.Add (new SpawnNode(0,10,2,0.5f,false));


	}

}