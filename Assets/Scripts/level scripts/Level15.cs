using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level15 : LevelTemplate {


	protected override void LoadList (){
		toBeSpawned.Add (new SpawnNode(100,5,0,0.5f));
		toBeSpawned.Add (new SpawnNode(0,6,1,0.5f));
		toBeSpawned.Add (new SpawnNode(0,7,3,0.5f));
		toBeSpawned.Add (new TipNode(0,17));

		toBeSpawned.Add(new AffectorNode(0,false,0.5f,0.5f));

		toBeSpawned.Add (new SpawnNode(150,0,0,0f));
		for(int i = 1; i < 11;i++){
			toBeSpawned.Add (new SpawnNode(0,0,0,i * 0.1f));
		}

		toBeSpawned.Add (new SpawnNode(25,4,0,0.3f));
		toBeSpawned.Add (new SpawnNode(0,4,0,0.7f));
		toBeSpawned.Add (new SpawnNode(25,4,0,0.2f));
		toBeSpawned.Add (new SpawnNode(0,4,0,0.8f));
		toBeSpawned.Add (new SpawnNode(25,4,0,0.1f));
		toBeSpawned.Add (new SpawnNode(0,4,0,0.9f));

		toBeSpawned.Add(new AffectorNode(125,true,0.2f,0.2f));

		toBeSpawned.Add (new SpawnNode(0,4,0,0.2f));
		toBeSpawned.Add (new SpawnNode(0,4,0,0.3f));
		toBeSpawned.Add (new SpawnNode(25,4,0,0.2f));
		toBeSpawned.Add (new SpawnNode(0,4,0,0.3f));
		toBeSpawned.Add (new SpawnNode(25,4,0,0.2f));
		toBeSpawned.Add (new SpawnNode(0,4,0,0.3f));


		toBeSpawned.Add (new SpawnNode(100,4,0,0.7f));
		toBeSpawned.Add (new SpawnNode(0,4,0,0.8f));
		toBeSpawned.Add (new SpawnNode(25,4,0,0.7f));
		toBeSpawned.Add (new SpawnNode(0,4,0,0.8f));
		toBeSpawned.Add (new SpawnNode(25,4,0,0.7f));
		toBeSpawned.Add (new SpawnNode(0,4,0,0.8f));

		toBeSpawned.Add(new SpawnNode(150,4,4));
		for (int i = 0; i < 10; i++) {
			toBeSpawned.Add(new SpawnNode(7,4,4));
		}

		toBeSpawned.Add(new AffectorNode(0,false,150,0.5f,0.5f));

		for (int i = 0; i < 10; i++) {
			toBeSpawned.Add(new SpawnNode(7,4,4));
		}

		toBeSpawned.Add(new SpawnNode(150,10,0,0.75f,false));
		toBeSpawned.Add(new SpawnNode(0,10,0,0.25f,false));
		toBeSpawned.Add(new SpawnNode(30,10,0,0.75f,false));
		toBeSpawned.Add(new SpawnNode(0,10,0,0.25f,false));
		//
		toBeSpawned.Add(new SpawnNode(0,6,0,0.15f,false));
		toBeSpawned.Add(new SpawnNode(0,6,0,0.85f,false));
		//
		toBeSpawned.Add(new SpawnNode(30,10,0,0.75f,false));
		toBeSpawned.Add(new SpawnNode(0,10,0,0.25f,false));

		toBeSpawned.Add(new SpawnNode(200,10,2,0.75f,false));
		toBeSpawned.Add(new SpawnNode(0,10,2,0.25f,false));
		toBeSpawned.Add(new SpawnNode(30,10,2,0.75f,false));
		toBeSpawned.Add(new SpawnNode(0,10,2,0.25f,false));
		//
		toBeSpawned.Add(new SpawnNode(0,6,2,0.65f,false));
		toBeSpawned.Add(new SpawnNode(0,6,2,0.35f,false));
		//
		toBeSpawned.Add(new SpawnNode(30,10,2,0.75f,false));
		toBeSpawned.Add(new SpawnNode(0,10,2,0.25f,false));

		

		toBeSpawned.Add(new SpawnNode(10,1,3,0.8f,false));
		toBeSpawned.Add(new AffectorNode(0,true,700,0.5f,1.2f));

		for (int i = 0; i < 10; i++) {
			toBeSpawned.Add(new SpawnNode(15,1,3,0.8f,false));
		}

		toBeSpawned.Add(new AffectorNode(0,true,400,0.2f,0f));

		for (int i = 0; i < 20; i++) {
			toBeSpawned.Add(new SpawnNode(15,1,3,0.8f,false));
		}


		toBeSpawned.Add(new AffectorNode(0,false,40,0.7f,0.2f));

		

		toBeSpawned.Add(new SpawnNode(200,10,1,0.5f,false));
		toBeSpawned.Add(new SpawnNode(30,10,1,0.6375f,false));
		toBeSpawned.Add(new SpawnNode(0,10,1,0.3625f,false));
		toBeSpawned.Add(new SpawnNode(30,10,1,0.7f,false));
		toBeSpawned.Add(new SpawnNode(0,10,1,0.3f,false));
		toBeSpawned.Add(new SpawnNode(0,4,1,0.5375f,false));
		toBeSpawned.Add(new SpawnNode(0,4,1,0.4625f,false));
		toBeSpawned.Add(new SpawnNode(30,10,1,0.7f,false));
		toBeSpawned.Add(new SpawnNode(0,10,1,0.3f,false));
		toBeSpawned.Add(new SpawnNode(0,4,1,0.5375f,false));
		toBeSpawned.Add(new SpawnNode(0,4,1,0.4625f,false));
		toBeSpawned.Add(new SpawnNode(30,10,1,0.7f,false));
		toBeSpawned.Add(new SpawnNode(0,10,1,0.3f,false));
		toBeSpawned.Add(new SpawnNode(0,4,1,0.5375f,false));
		toBeSpawned.Add(new SpawnNode(0,4,1,0.4625f,false));
		toBeSpawned.Add(new SpawnNode(30,10,1,0.7f,false));
		toBeSpawned.Add(new SpawnNode(0,10,1,0.3f,false));
		toBeSpawned.Add(new SpawnNode(0,4,1,0.5375f,false));
		toBeSpawned.Add(new SpawnNode(0,4,1,0.4625f,false));

		

		toBeSpawned.Add(new SpawnNode(200,10,2,0.5f));
		toBeSpawned.Add(new SpawnNode(0,10,2,0.25f));
		toBeSpawned.Add(new SpawnNode(0,10,2,0.0f));
		toBeSpawned.Add(new SpawnNode(0,10,2,0.75f));
		toBeSpawned.Add(new SpawnNode(0,10,2,1f));

		toBeSpawned.Add(new SpawnNode(0,7,2,0.125f));
		toBeSpawned.Add(new SpawnNode(0,7,2,0.375f));
		toBeSpawned.Add(new SpawnNode(0,7,2,0.625f));
		toBeSpawned.Add(new SpawnNode(0,7,2,0.875f));

		toBeSpawned.Add(new SpawnNode(120,10,2,0.5f));
		toBeSpawned.Add(new SpawnNode(0,10,2,0.25f));
		toBeSpawned.Add(new SpawnNode(0,10,2,0.0f));
		toBeSpawned.Add(new SpawnNode(0,10,2,0.75f));
		toBeSpawned.Add(new SpawnNode(0,10,2,1f));

		toBeSpawned.Add(new SpawnNode(0,7,2,0.125f));
		toBeSpawned.Add(new SpawnNode(0,7,2,0.375f));
		toBeSpawned.Add(new SpawnNode(0,7,2,0.625f));
		toBeSpawned.Add(new SpawnNode(0,7,2,0.875f));

		toBeSpawned.Add(new SpawnNode(150,4,0));
		for (int i = 0; i < 20; i++) {
			toBeSpawned.Add(new SpawnNode(15,4,0));
		}

		toBeSpawned.Add(new AffectorNode(0,false,250,0.25f,0.5f));
		toBeSpawned.Add(new AffectorNode(0,false,500,0.75f,0.5f));

		for (int i = 0; i < 20; i++) {
			toBeSpawned.Add(new SpawnNode(15,4,0,Random.Range(0.5f,1f)));
		}

		toBeSpawned.Add(new SpawnNode(50,9,0,0.5f));

		toBeSpawned.Add(new WaitNode(150));

		for (int i = 0; i < 11; i++) {
			toBeSpawned.Add(new SpawnNode(0,0,0,i * 0.1f,false));
		}
		for (int i = 0; i < 11; i++) {
			toBeSpawned.Add(new SpawnNode(0,1,1,i * 0.1f,false));
		}
		for (int i = 0; i < 11; i++) {
			toBeSpawned.Add(new SpawnNode(0,2,2,i * 0.1f,false));
		}
		for (int i = 0; i < 11; i++) {
			toBeSpawned.Add(new SpawnNode(0,3,3,i * 0.1f,false));
		}
	}

}