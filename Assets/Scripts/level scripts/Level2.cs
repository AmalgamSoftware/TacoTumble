using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2 : LevelTemplate {


	protected override void LoadList (){
		toBeSpawned.Add (new SpawnNode(100,1,2,0.3f));
		toBeSpawned.Add (new TipNode(0,3));
		toBeSpawned.Add (new SpawnNode(50,1,1,0.5f));
		toBeSpawned.Add (new SpawnNode(0,0,3,0.5f));
		toBeSpawned.Add (new SpawnNode(30,1,0,0.5f));
		toBeSpawned.Add (new SpawnNode(30,1,1,0.5f));
		toBeSpawned.Add (new SpawnNode(30,0,2,0.5f));
		toBeSpawned.Add (new SpawnNode(30,1,3,0.5f));
		toBeSpawned.Add (new SpawnNode(30,0,0,0.5f));
		toBeSpawned.Add (new SpawnNode(30,1,1,0.5f));
		toBeSpawned.Add (new SpawnNode(30,0,2,0.5f));
		toBeSpawned.Add (new SpawnNode(30,0,3,0.5f));
		toBeSpawned.Add (new SpawnNode(30,0,0,0.5f));
		toBeSpawned.Add (new SpawnNode(30,1,1,0.5f));
		toBeSpawned.Add (new SpawnNode(30,0,2,0.5f));
		toBeSpawned.Add (new SpawnNode(30,1,3,0.5f));
		toBeSpawned.Add (new SpawnNode(15,0,0,0.5f));
		toBeSpawned.Add (new SpawnNode(15,1,1,0.5f));
		toBeSpawned.Add (new SpawnNode(15,0,2,0.5f));
		toBeSpawned.Add (new SpawnNode(15,1,3,0.5f));

        toBeSpawned.Add(new TipNode(100, 22));

        toBeSpawned.Add (new SpawnNode(100,1,0,1f));
		toBeSpawned.Add (new SpawnNode(40,1,0,0f));
		toBeSpawned.Add (new SpawnNode(40,1,0,1f));
		toBeSpawned.Add (new SpawnNode(40,1,0,0f));
		toBeSpawned.Add (new SpawnNode(40,1,0,1f));
		toBeSpawned.Add (new SpawnNode(40,1,0,0f));
		toBeSpawned.Add (new SpawnNode(100,1,2,1f));
		toBeSpawned.Add (new SpawnNode(0,1,2,0f));
		toBeSpawned.Add (new SpawnNode(50,1,2,0.8f));
		toBeSpawned.Add (new SpawnNode(0,1,2,0.2f));
		toBeSpawned.Add (new SpawnNode(50,1,2,0.6f));
		toBeSpawned.Add (new SpawnNode(0,1,2,0.4f));

		toBeSpawned.Add (new SpawnNode(70,1,1,0.9f));
		toBeSpawned.Add (new SpawnNode(30,1,1,0.9f));
		toBeSpawned.Add (new SpawnNode(30,1,1,0.9f));
		toBeSpawned.Add (new SpawnNode(70,1,1,0.9f));
		toBeSpawned.Add (new SpawnNode(30,1,1,0.9f));
		toBeSpawned.Add (new SpawnNode(30,1,1,0.9f));
		toBeSpawned.Add (new SpawnNode(70,1,3,0.9f));
		toBeSpawned.Add (new SpawnNode(30,1,3,0.9f));
		toBeSpawned.Add (new SpawnNode(30,1,3,0.9f));
		toBeSpawned.Add (new SpawnNode(70,1,3,0.9f));
		toBeSpawned.Add (new SpawnNode(30,1,3,0.9f));
		toBeSpawned.Add (new SpawnNode(30,1,3,0.9f));

		toBeSpawned.Add (new SpawnNode(70,1,3,0.5f));
		toBeSpawned.Add (new SpawnNode(0,1,1,0.5f));
		toBeSpawned.Add (new SpawnNode(30,1,3,0.5f));
		toBeSpawned.Add (new SpawnNode(0,1,1,0.5f));
		toBeSpawned.Add (new SpawnNode(30,1,3,0.5f));
		toBeSpawned.Add (new SpawnNode(0,1,1,0.5f));
	}

}
