using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level3 : LevelTemplate {


	protected override void LoadList (){
		toBeSpawned.Add (new SpawnNode(100,2,0,0.5f));
		toBeSpawned.Add (new TipNode(0,4));
		toBeSpawned.Add(new SpawnNode(100,2,0,0.3f));
		toBeSpawned.Add(new SpawnNode(15,2,0,0.5f));
		toBeSpawned.Add(new SpawnNode(15,2,0,0.8f));

		toBeSpawned.Add(new SpawnNode(100,2,1,0.8f));
		toBeSpawned.Add(new SpawnNode(15,2,1,0.3f));
		toBeSpawned.Add(new SpawnNode(15,2,1,0.5f));

		toBeSpawned.Add(new SpawnNode(100,2,2,0.8f));
		toBeSpawned.Add(new SpawnNode(15,2,2,0.3f));
		toBeSpawned.Add(new SpawnNode(15,2,2,0.5f));

		toBeSpawned.Add(new SpawnNode(100,2,3,0.3f));
		toBeSpawned.Add(new SpawnNode(15,2,3,0.5f));
		toBeSpawned.Add(new SpawnNode(15,2,3,0.8f));

		toBeSpawned.Add(new SpawnNode(100,2,3,0.3f));
		toBeSpawned.Add(new SpawnNode(0,2,1,0.3f));
		toBeSpawned.Add(new SpawnNode(15,2,3,0.5f));
		toBeSpawned.Add(new SpawnNode(0,2,1,0.5f));
		toBeSpawned.Add(new SpawnNode(15,2,3,0.8f));
		toBeSpawned.Add(new SpawnNode(0,2,1,0.8f));

		toBeSpawned.Add(new SpawnNode(100,2,4));
		toBeSpawned.Add(new SpawnNode(30,2,4));
		toBeSpawned.Add(new SpawnNode(30,2,4));
		toBeSpawned.Add(new SpawnNode(30,2,4));

		toBeSpawned.Add(new SpawnNode(100,2,4));
		toBeSpawned.Add(new SpawnNode(30,2,4));
		toBeSpawned.Add(new SpawnNode(30,2,4));
		toBeSpawned.Add(new SpawnNode(30,2,4));
		toBeSpawned.Add(new SpawnNode(30,2,4));
		toBeSpawned.Add(new SpawnNode(30,2,4));

		toBeSpawned.Add(new SpawnNode(100,2,4));
		toBeSpawned.Add(new SpawnNode(30,2,4));
		toBeSpawned.Add(new SpawnNode(30,2,4));
		toBeSpawned.Add(new SpawnNode(30,2,4));
		toBeSpawned.Add(new SpawnNode(30,2,4));
		toBeSpawned.Add(new SpawnNode(30,2,4));

		toBeSpawned.Add(new SpawnNode(100,2,0,0.2f));
		toBeSpawned.Add(new SpawnNode(0,2,2,0.2f));
		toBeSpawned.Add(new SpawnNode(15,2,0,0.2f));
		toBeSpawned.Add(new SpawnNode(0,2,2,0.2f));

		toBeSpawned.Add(new SpawnNode(70,2,0,0.8f));
		toBeSpawned.Add(new SpawnNode(0,2,2,0.8f));
		toBeSpawned.Add(new SpawnNode(15,2,0,0.8f));
		toBeSpawned.Add(new SpawnNode(0,2,2,0.8f));

		toBeSpawned.Add(new SpawnNode(70,2,0,0.2f));
		toBeSpawned.Add(new SpawnNode(0,2,2,0.2f));
		toBeSpawned.Add(new SpawnNode(15,2,0,0.2f));
		toBeSpawned.Add(new SpawnNode(0,2,2,0.2f));

		toBeSpawned.Add(new SpawnNode(70,2,0,0.8f));
		toBeSpawned.Add(new SpawnNode(0,2,2,0.8f));
		toBeSpawned.Add(new SpawnNode(15,2,0,0.8f));
		toBeSpawned.Add(new SpawnNode(0,2,2,0.8f));

		toBeSpawned.Add(new SpawnNode(70,2,0,0.5f));
		toBeSpawned.Add(new SpawnNode(0,2,2,0.5f));
		toBeSpawned.Add(new SpawnNode(15,2,0,0.5f));
		toBeSpawned.Add(new SpawnNode(0,2,2,0.5f));
	}

}
