using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level11 : LevelTemplate {


	protected override void LoadList (){
		toBeSpawned.Add (new SpawnNode(100,5,0,0.5f));
		toBeSpawned.Add (new SpawnNode(0,6,1,0.5f));
		toBeSpawned.Add (new SpawnNode(0,7,3,0.5f));
		toBeSpawned.Add (new TipNode(0,13));

		toBeSpawned.Add (new SpawnNode(150,10,0,0.5f));
		toBeSpawned.Add (new SpawnNode(0,0,0,0.5f));

		toBeSpawned.Add (new SpawnNode(50,10,2,0.25f));
		toBeSpawned.Add (new SpawnNode(0,0,2,0.25f));

		toBeSpawned.Add (new SpawnNode(50,10,2,0.75f));
		toBeSpawned.Add (new SpawnNode(0,0,2,0.75f));

		toBeSpawned.Add (new SpawnNode(150,5,2,0.3f));
		toBeSpawned.Add (new SpawnNode(0,10,2,0.4f));
		toBeSpawned.Add (new SpawnNode(30,5,2,0.3f));
		toBeSpawned.Add (new SpawnNode(30,5,2,0.3f));

		toBeSpawned.Add (new SpawnNode(130,10,2,0.3f));
		toBeSpawned.Add (new SpawnNode(20,5,2,0.3f));
		toBeSpawned.Add (new SpawnNode(0,10,2,0.4f));
		toBeSpawned.Add (new SpawnNode(30,5,2,0.3f));
		toBeSpawned.Add (new SpawnNode(30,5,2,0.3f));

		toBeSpawned.Add (new SpawnNode(150,10,0,0.7f));
		toBeSpawned.Add (new SpawnNode(0,10,0,0.5f));
		toBeSpawned.Add (new SpawnNode(20,5,0,0.5f));
		toBeSpawned.Add (new SpawnNode(20,5,0,0.5f));

		toBeSpawned.Add (new SpawnNode(150,true));
		toBeSpawned.Add (new SpawnNode(25,true));
		toBeSpawned.Add (new SpawnNode(25,true));
		toBeSpawned.Add (new SpawnNode(25,true));
		toBeSpawned.Add (new SpawnNode(25,true));

		toBeSpawned.Add (new SpawnNode(25,10,4));
		toBeSpawned.Add (new SpawnNode(25,10,4));
		toBeSpawned.Add (new SpawnNode(25,10,4));

		for (int i = 0; i < 10; i++) {
			toBeSpawned.Add (new SpawnNode(15,false));
		}
		toBeSpawned.Add (new SpawnNode(30,6,4));
		toBeSpawned.Add (new SpawnNode(0,6,4));
		toBeSpawned.Add (new SpawnNode(0,6,4));
		toBeSpawned.Add (new SpawnNode(0,6,4));

		toBeSpawned.Add (new SpawnNode(15,10,0,0.5f));
		toBeSpawned.Add (new SpawnNode(0,10,1,0.5f));
		toBeSpawned.Add (new SpawnNode(0,10,2,0.5f));
		toBeSpawned.Add (new SpawnNode(0,10,3,0.5f));
		toBeSpawned.Add (new SpawnNode(15,10,4,0.5f));

		for (int i = 0; i < 20; i++) {
			toBeSpawned.Add (new SpawnNode(15,4,4,0.5f));
		}

		toBeSpawned.Add (new SpawnNode(150,10,2,0.9f));
		toBeSpawned.Add (new SpawnNode(0,10,2,0.1f));
		toBeSpawned.Add (new SpawnNode(20,3,2,0.9f));
		toBeSpawned.Add (new SpawnNode(0,3,2,0.1f));
		toBeSpawned.Add (new SpawnNode(20,3,2,0.9f));
		toBeSpawned.Add (new SpawnNode(0,3,2,0.1f));
		toBeSpawned.Add (new SpawnNode(20,3,2,0.9f));
		toBeSpawned.Add (new SpawnNode(0,3,2,0.1f));

		//nograv

		toBeSpawned.Add (new SpawnNode(200,10,1,0.6f,false));
		toBeSpawned.Add (new SpawnNode(25,5,1,0.6f,false));
		toBeSpawned.Add (new SpawnNode(25,10,1,0.6f,false));

		toBeSpawned.Add (new SpawnNode(100,10,1,0.2f,false));
		toBeSpawned.Add (new SpawnNode(25,5,1,0.2f,false));
		toBeSpawned.Add (new SpawnNode(25,10,1,0.2f,false));

		toBeSpawned.Add (new SpawnNode(100,10,3,0.8f,false));
		toBeSpawned.Add (new SpawnNode(25,5,3,0.8f,false));
		toBeSpawned.Add (new SpawnNode(25,10,3,0.8f,false));

		toBeSpawned.Add (new SpawnNode(100,10,2,0.5f,false));
		toBeSpawned.Add (new SpawnNode(25,5,2,0.5f,false));
		toBeSpawned.Add (new SpawnNode(25,10,2,0.5f,false));

		toBeSpawned.Add (new SpawnNode(100,10,1,0.6f,false));
		toBeSpawned.Add (new SpawnNode(0,10,1,0.5f,false));
		toBeSpawned.Add (new SpawnNode(0,10,1,0.4f,false));
		toBeSpawned.Add (new SpawnNode(20,1,1,0.4f,false));
		toBeSpawned.Add (new SpawnNode(0,1,1,0.5f,false));
		toBeSpawned.Add (new SpawnNode(0,1,1,0.6f,false));
		toBeSpawned.Add (new SpawnNode(20,1,1,0.4f,false));
		toBeSpawned.Add (new SpawnNode(0,1,1,0.5f,false));
		toBeSpawned.Add (new SpawnNode(0,1,1,0.6f,false));
		toBeSpawned.Add (new SpawnNode(20,1,1,0.4f,false));
		toBeSpawned.Add (new SpawnNode(0,1,1,0.5f,false));
		toBeSpawned.Add (new SpawnNode(0,1,1,0.6f,false));
		toBeSpawned.Add (new SpawnNode(20,5,1,0.4f,false));
		toBeSpawned.Add (new SpawnNode(0,5,1,0.5f,false));
		toBeSpawned.Add (new SpawnNode(0,5,1,0.6f,false));
		toBeSpawned.Add (new SpawnNode(20,10,1,0.4f,false));
		toBeSpawned.Add (new SpawnNode(0,10,1,0.5f,false));
		toBeSpawned.Add (new SpawnNode(0,10,1,0.6f,false));


		toBeSpawned.Add (new SpawnNode(150,10,0,0.5f,false));
		toBeSpawned.Add (new SpawnNode(25,5,0,0.5f,false));
		toBeSpawned.Add (new SpawnNode(25,10,0,0.5f,false));

		toBeSpawned.Add (new SpawnNode(100,10,0,0.9f,false));
		toBeSpawned.Add (new SpawnNode(25,5,0,0.9f,false));
		toBeSpawned.Add (new SpawnNode(25,10,0,0.9f,false));

		toBeSpawned.Add (new SpawnNode(100,10,2,0.1f,false));
		toBeSpawned.Add (new SpawnNode(25,5,2,0.1f,false));
		toBeSpawned.Add (new SpawnNode(25,10,2,0.1f,false));

		toBeSpawned.Add (new SpawnNode(150,10,0,0.5f));
		toBeSpawned.Add (new SpawnNode(0,10,1,0.5f));
		toBeSpawned.Add (new SpawnNode(0,10,3,0.5f));

		toBeSpawned.Add (new SpawnNode(200,5,0,0.5f));
		toBeSpawned.Add (new SpawnNode(0,6,1,0.5f));
		toBeSpawned.Add (new SpawnNode(0,7,3,0.5f));



	}

}