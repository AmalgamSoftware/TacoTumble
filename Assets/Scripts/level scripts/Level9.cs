using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level9 : LevelTemplate {


	protected override void LoadList (){

		toBeSpawned.Add (new TipNode(100,10));

		toBeSpawned.Add (new SpawnNode(0,6,0,0.5f));
		toBeSpawned.Add (new SpawnNode(0,6,0,0.45f));
		toBeSpawned.Add (new SpawnNode(0,6,0,0.55f));
		toBeSpawned.Add (new SpawnNode(0,6,1,0.4f));
		toBeSpawned.Add (new SpawnNode(0,6,1,0.5f));
		toBeSpawned.Add (new SpawnNode(0,6,1,0.6f));
		toBeSpawned.Add (new SpawnNode(0,6,3,0.4f));
		toBeSpawned.Add (new SpawnNode(0,6,3,0.5f));
		toBeSpawned.Add (new SpawnNode(0,6,3,0.6f));

		toBeSpawned.Add (new SpawnNode(100,6,0,0.5f));
		toBeSpawned.Add (new SpawnNode(0,6,0,0.45f));
		toBeSpawned.Add (new SpawnNode(0,6,0,0.55f));
		toBeSpawned.Add (new SpawnNode(0,6,1,0.4f));
		toBeSpawned.Add (new SpawnNode(0,6,1,0.5f));
		toBeSpawned.Add (new SpawnNode(0,6,1,0.6f));
		toBeSpawned.Add (new SpawnNode(0,6,3,0.4f));
		toBeSpawned.Add (new SpawnNode(0,6,3,0.5f));
		toBeSpawned.Add (new SpawnNode(0,6,3,0.6f));



		toBeSpawned.Add (new SpawnNode(30,4,2,0.5f));
		toBeSpawned.Add (new SpawnNode(30,4,2,0.5f));
		toBeSpawned.Add (new SpawnNode(30,4,2,0.5f));

		toBeSpawned.Add (new SpawnNode(10,4,2,0.5f));
		toBeSpawned.Add (new SpawnNode(10,4,2,0.6f));
		toBeSpawned.Add (new SpawnNode(10,4,2,0.7f));
		toBeSpawned.Add (new SpawnNode(10,4,2,0.8f));
		toBeSpawned.Add (new SpawnNode(10,4,2,0.9f));
		toBeSpawned.Add (new SpawnNode(10,4,2,10f));

		toBeSpawned.Add (new SpawnNode(10,4,1,0f));
		toBeSpawned.Add (new SpawnNode(10,4,1,0.1f));
		toBeSpawned.Add (new SpawnNode(10,4,1,0.2f));
		toBeSpawned.Add (new SpawnNode(10,4,1,0.3f));
		toBeSpawned.Add (new SpawnNode(10,4,1,0.4f));
		toBeSpawned.Add (new SpawnNode(10,4,1,0.5f));
		toBeSpawned.Add (new SpawnNode(10,4,1,0.6f));
		toBeSpawned.Add (new SpawnNode(10,4,1,0.7f));
		toBeSpawned.Add (new SpawnNode(10,4,1,0.8f));
		toBeSpawned.Add (new SpawnNode(10,4,1,0.9f));
		toBeSpawned.Add (new SpawnNode(10,4,1,1f));

		toBeSpawned.Add (new SpawnNode(10,4,0,1f));
		toBeSpawned.Add (new SpawnNode(10,4,0,0.9f));
		toBeSpawned.Add (new SpawnNode(10,4,0,0.8f));
		toBeSpawned.Add (new SpawnNode(10,4,0,0.7f));
		toBeSpawned.Add (new SpawnNode(10,4,0,0.6f));
		toBeSpawned.Add (new SpawnNode(10,4,0,0.5f));
		toBeSpawned.Add (new SpawnNode(10,4,0,0.4f));
		toBeSpawned.Add (new SpawnNode(10,4,0,0.3f));
		toBeSpawned.Add (new SpawnNode(10,4,0,0.2f));
		toBeSpawned.Add (new SpawnNode(10,4,0,0.1f));
		toBeSpawned.Add (new SpawnNode(10,4,0,0.0f));

		toBeSpawned.Add (new SpawnNode(10,4,3,1f));
		toBeSpawned.Add (new SpawnNode(10,4,3,0.9f));
		toBeSpawned.Add (new SpawnNode(10,4,3,0.8f));
		toBeSpawned.Add (new SpawnNode(10,4,3,0.7f));
		toBeSpawned.Add (new SpawnNode(10,4,3,0.6f));
		toBeSpawned.Add (new SpawnNode(10,4,3,0.5f));
		toBeSpawned.Add (new SpawnNode(10,4,3,0.4f));
		toBeSpawned.Add (new SpawnNode(10,4,3,0.3f));
		toBeSpawned.Add (new SpawnNode(10,4,3,0.2f));
		toBeSpawned.Add (new SpawnNode(10,4,3,0.1f));
		toBeSpawned.Add (new SpawnNode(10,4,3,0.0f));

		toBeSpawned.Add (new SpawnNode(10,4,2,0.0f));
		toBeSpawned.Add (new SpawnNode(10,4,2,0.1f));
		toBeSpawned.Add (new SpawnNode(10,4,2,0.2f));
		toBeSpawned.Add (new SpawnNode(10,4,2,0.3f));
		toBeSpawned.Add (new SpawnNode(10,4,2,0.4f));
		toBeSpawned.Add (new SpawnNode(10,4,2,0.5f));
		toBeSpawned.Add (new SpawnNode(10,4,2,0.6f));
		toBeSpawned.Add (new SpawnNode(10,4,2,0.7f));
		toBeSpawned.Add (new SpawnNode(10,4,2,0.8f));
		toBeSpawned.Add (new SpawnNode(10,4,2,0.9f));
		toBeSpawned.Add (new SpawnNode(10,4,2,10f));

		toBeSpawned.Add (new SpawnNode(10,4,1,0f));
		toBeSpawned.Add (new SpawnNode(10,4,1,0.1f));
		toBeSpawned.Add (new SpawnNode(10,4,1,0.2f));
		toBeSpawned.Add (new SpawnNode(10,4,1,0.3f));
		toBeSpawned.Add (new SpawnNode(10,4,1,0.4f));
		toBeSpawned.Add (new SpawnNode(10,4,1,0.5f));
		toBeSpawned.Add (new SpawnNode(10,4,1,0.6f));
		toBeSpawned.Add (new SpawnNode(10,4,1,0.7f));
		toBeSpawned.Add (new SpawnNode(10,4,1,0.8f));
		toBeSpawned.Add (new SpawnNode(10,4,1,0.9f));
		toBeSpawned.Add (new SpawnNode(10,4,1,1f));

		toBeSpawned.Add (new SpawnNode(10,4,0,1f));
		toBeSpawned.Add (new SpawnNode(10,4,0,0.9f));
		toBeSpawned.Add (new SpawnNode(10,4,0,0.8f));
		toBeSpawned.Add (new SpawnNode(10,4,0,0.7f));
		toBeSpawned.Add (new SpawnNode(10,4,0,0.6f));
		toBeSpawned.Add (new SpawnNode(10,4,0,0.5f));
		toBeSpawned.Add (new SpawnNode(10,4,0,0.4f));
		toBeSpawned.Add (new SpawnNode(10,4,0,0.3f));
		toBeSpawned.Add (new SpawnNode(10,4,0,0.2f));
		toBeSpawned.Add (new SpawnNode(10,4,0,0.1f));
		toBeSpawned.Add (new SpawnNode(10,4,0,0.0f));

		toBeSpawned.Add (new SpawnNode(10,4,3,1f));
		toBeSpawned.Add (new SpawnNode(10,4,3,0.9f));
		toBeSpawned.Add (new SpawnNode(10,4,3,0.8f));
		toBeSpawned.Add (new SpawnNode(10,4,3,0.7f));
		toBeSpawned.Add (new SpawnNode(10,4,3,0.6f));
		toBeSpawned.Add (new SpawnNode(10,4,3,0.5f));
		toBeSpawned.Add (new SpawnNode(10,4,3,0.4f));
		toBeSpawned.Add (new SpawnNode(10,4,3,0.3f));
		toBeSpawned.Add (new SpawnNode(10,4,3,0.2f));
		toBeSpawned.Add (new SpawnNode(10,4,3,0.1f));
		toBeSpawned.Add (new SpawnNode(10,4,3,0.0f));

		toBeSpawned.Add (new SpawnNode(30,4,2,0.5f));
		toBeSpawned.Add (new SpawnNode(30,4,2,0.5f));
		toBeSpawned.Add (new SpawnNode(30,4,2,0.5f));

		toBeSpawned.Add (new SpawnNode(200,7,0,0.5f));
		toBeSpawned.Add (new SpawnNode(0,7,0,0.45f));
		toBeSpawned.Add (new SpawnNode(0,7,0,0.55f));
		toBeSpawned.Add (new SpawnNode(0,7,1,0.4f));
		toBeSpawned.Add (new SpawnNode(0,7,1,0.5f));
		toBeSpawned.Add (new SpawnNode(0,7,1,0.6f));
		toBeSpawned.Add (new SpawnNode(0,7,3,0.4f));
		toBeSpawned.Add (new SpawnNode(0,7,3,0.5f));
		toBeSpawned.Add (new SpawnNode(0,7,3,0.6f));

		toBeSpawned.Add (new SpawnNode(100,7,0,0.5f));
		toBeSpawned.Add (new SpawnNode(0,7,0,0.45f));
		toBeSpawned.Add (new SpawnNode(0,7,0,0.55f));
		toBeSpawned.Add (new SpawnNode(0,7,1,0.4f));
		toBeSpawned.Add (new SpawnNode(0,7,1,0.5f));
		toBeSpawned.Add (new SpawnNode(0,7,1,0.6f));
		toBeSpawned.Add (new SpawnNode(0,7,3,0.4f));
		toBeSpawned.Add (new SpawnNode(0,7,3,0.5f));
		toBeSpawned.Add (new SpawnNode(0,7,3,0.6f));

		toBeSpawned.Add (new SpawnNode(100,0,0,0.1f));
		toBeSpawned.Add (new SpawnNode(0,1,2,0.9f));
		toBeSpawned.Add (new SpawnNode(0,2,1,0.1f));
		toBeSpawned.Add (new SpawnNode(0,3,3,0.9f));

		for (int i = 0; i < 45; i++) {
			toBeSpawned.Add (new SpawnNode(15,4,0));
		}

		toBeSpawned.Add (new TipNode(150,11));
		toBeSpawned.Add (new SpawnNode(0,9,0,0.5f));

		toBeSpawned.Add (new SpawnNode(150,5,0,0.5f));
		toBeSpawned.Add (new SpawnNode(0,5,0,0.45f));
		toBeSpawned.Add (new SpawnNode(0,5,0,0.55f));
		toBeSpawned.Add (new SpawnNode(0,5,1,0.4f));
		toBeSpawned.Add (new SpawnNode(0,5,1,0.5f));
		toBeSpawned.Add (new SpawnNode(0,5,1,0.6f));
		toBeSpawned.Add (new SpawnNode(0,5,3,0.4f));
		toBeSpawned.Add (new SpawnNode(0,5,3,0.5f));
		toBeSpawned.Add (new SpawnNode(0,5,3,0.6f));

		toBeSpawned.Add (new SpawnNode(100,5,0,0.5f));
		toBeSpawned.Add (new SpawnNode(0,5,0,0.45f));
		toBeSpawned.Add (new SpawnNode(0,5,0,0.55f));
		toBeSpawned.Add (new SpawnNode(0,5,1,0.4f));
		toBeSpawned.Add (new SpawnNode(0,5,1,0.5f));
		toBeSpawned.Add (new SpawnNode(0,5,1,0.6f));
		toBeSpawned.Add (new SpawnNode(0,5,3,0.4f));
		toBeSpawned.Add (new SpawnNode(0,5,3,0.5f));
		toBeSpawned.Add (new SpawnNode(0,5,3,0.6f));

		toBeSpawned.Add (new SpawnNode(150,1,1,0.3f));
		toBeSpawned.Add (new SpawnNode(0,1,3,0.3f));

		SideCheese (1,0.3f);
		SideCheese (1,0.3f);
		SideCheese (1,0.4f);
		SideCheese (1,0.5f);
		SideCheese (1,0.6f);
		SideCheese (1,0.7f);
		SideCheese (1,0.8f);
		SideCheese (1,0.9f);
		SideCheese (1,1f);
		SideCheese (1,0.1f);
		SideCheese (1,0.2f);
		SideCheese (1,0.3f);
		SideCheese (1,0.4f);
		SideCheese (1,0.5f);
		SideCheese (1,0.6f);
		SideCheese (1,0.7f);
		SideCheese (1,0.8f);
		SideCheese (1,0.9f);

		toBeSpawned.Add (new SpawnNode(150,2,1,0.3f));
		toBeSpawned.Add (new SpawnNode(0,2,3,0.3f));

		SideCheese (2,0.3f);
		SideCheese (2,0.3f);
		SideCheese (2,0.2f);
		SideCheese (2,0.1f);
		SideCheese (2,0.2f);
		SideCheese (2,0.3f);
		SideCheese (2,0.4f);
		SideCheese (2,0.5f);
		SideCheese (2,0.4f);
		SideCheese (2,0.3f);
		SideCheese (2,0.2f);
		SideCheese (2,0.1f);
		SideCheese (2,1f);
		SideCheese (2,0.9f);
		SideCheese (2,0.8f);
		SideCheese (2,0.7f);
		SideCheese (2,0.6f);
		SideCheese (2,0.5f);
		SideCheese (2,0.4f);
		SideCheese (2,0.5f);
		SideCheese (2,0.6f);
		SideCheese (2,0.7f);
		SideCheese (2,0.7f);
		SideCheese (2,0.7f);
		SideCheese (2,0.7f);
		SideCheese (2,0.7f);

		toBeSpawned.Add (new SpawnNode(150,5,0,0.5f));
		toBeSpawned.Add (new SpawnNode(0,6,1,0.5f));
		toBeSpawned.Add (new SpawnNode(0,7,3,0.5f));
		toBeSpawned.Add (new SpawnNode(0,5,2,0.5f));
	}
	void SideCheese(int type,float offs){
		toBeSpawned.Add (new SpawnNode(10,type,1,offs));
		toBeSpawned.Add (new SpawnNode(0,type,3,offs));
	}

}
