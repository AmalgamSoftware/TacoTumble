using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1 : LevelTemplate {


	protected override void LoadList (){
		toBeSpawned.Add (new TipNode (10, 1));

        

         toBeSpawned.Add(new SpawnNode(0, 0, 2, 0.5f));


         toBeSpawned.Add(new SpawnNode(120,0,0,0.1f));
         toBeSpawned.Add (new TipNode (0, 2));
         toBeSpawned.Add(new SpawnNode(40,0,0,0.1f));
         toBeSpawned.Add(new SpawnNode(80,0,0,0.5f));
         toBeSpawned.Add(new SpawnNode(40,0,0,0.5f));
         toBeSpawned.Add(new SpawnNode(80,0,0,0.9f));
         toBeSpawned.Add(new SpawnNode(40,0,0,0.9f));

         toBeSpawned.Add(new SpawnNode(80,0,2,0.5f));
         toBeSpawned.Add(new SpawnNode(40,0,2,0.5f));

         toBeSpawned.Add(new SpawnNode(40,0,0,0.1f));
         toBeSpawned.Add(new SpawnNode(40,0,0,0.2f));
         toBeSpawned.Add(new SpawnNode(40,0,0,0.3f));
         toBeSpawned.Add(new SpawnNode(40,0,0,0.4f));
         toBeSpawned.Add(new SpawnNode(40,0,0,0.5f));
         toBeSpawned.Add(new SpawnNode(40,0,0,0.6f));
         toBeSpawned.Add(new SpawnNode(40,0,0,0.7f));
         toBeSpawned.Add(new SpawnNode(40,0,0,0.8f));
         toBeSpawned.Add(new SpawnNode(40,0,0,0.9f));

         toBeSpawned.Add(new SpawnNode(100,0,1,0.5f));
         toBeSpawned.Add(new SpawnNode(40,0,1,0.5f));
         toBeSpawned.Add(new SpawnNode(40,0,1,0.5f));

         toBeSpawned.Add(new SpawnNode(100,0,3,0.5f));
         toBeSpawned.Add(new SpawnNode(40,0,3,0.5f));
         toBeSpawned.Add(new SpawnNode(40,0,3,0.5f));

         toBeSpawned.Add(new SpawnNode(100,0,1,0.1f));
         toBeSpawned.Add(new SpawnNode(40,0,1,0.5f));
         toBeSpawned.Add(new SpawnNode(40,0,1,0.9f));

         toBeSpawned.Add(new SpawnNode(100,0,2,0.1f));
         toBeSpawned.Add(new SpawnNode(0,0,2,0.3f));

         toBeSpawned.Add(new SpawnNode(100,0,2,0.9f));
         toBeSpawned.Add(new SpawnNode(0,0,2,0.7f));

         toBeSpawned.Add(new SpawnNode(100,0,1,0.5f));
         toBeSpawned.Add(new SpawnNode(0,0,2,0.5f));
         toBeSpawned.Add(new SpawnNode(0,0,3,0.5f));
         toBeSpawned.Add(new SpawnNode(0,0,0,0.5f));

         toBeSpawned.Add(new SpawnNode(100,0,0,0.5f));
         toBeSpawned.Add(new SpawnNode(0,0,2,0.5f));

         toBeSpawned.Add(new SpawnNode(100,0,0,0.1f));
         toBeSpawned.Add(new SpawnNode(0,0,2,0.1f));

         toBeSpawned.Add(new SpawnNode(100,0,0,0.9f));
         toBeSpawned.Add(new SpawnNode(0,0,2,0.9f));

         toBeSpawned.Add(new TipNode(50, 21));

         toBeSpawned.Add(new SpawnNode(100,0,1,0.9f));
         toBeSpawned.Add(new SpawnNode(15,0,1,0.85f));
         toBeSpawned.Add(new SpawnNode(15,0,1,0.80f));
         toBeSpawned.Add(new SpawnNode(15,0,1,0.75f));
         toBeSpawned.Add (new SpawnNode (15, 0, 1, 0.70f));
         toBeSpawned.Add(new SpawnNode(15,0,1,0.65f));
         toBeSpawned.Add(new SpawnNode(15,0,1,0.60f));
         toBeSpawned.Add(new SpawnNode(15,0,1,0.55f));
         toBeSpawned.Add(new SpawnNode(15,0,1,0.50f));
         toBeSpawned.Add(new SpawnNode(15,0,1,0.45f));

    }

}
