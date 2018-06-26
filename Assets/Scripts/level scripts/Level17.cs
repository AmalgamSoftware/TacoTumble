using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level17 : LevelTemplate {


	protected override void LoadList (){
		int dir = 1;
		int iterations = 40;
		int startSpacing = 110;
		int endSpacing = 80;
		int spacingDifference = startSpacing - endSpacing;
		int spacing;
		int halfSpacing;
		float iterationFactor = 1f / iterations;
		for (int i = 0; i < iterations; i++) {
			spacing = Mathf.FloorToInt(startSpacing - spacingDifference * iterationFactor * i);
			halfSpacing = spacing / 2;
			int rand = Random.Range (0, 5);
			for (int j = 0; j < 5; j++) {
				int timeoff = 0;
				if (j == 0) {
					timeoff = halfSpacing;
				}
				int type;
				if (j == rand) {
					type = 7;
				} else {
					type = 10;
				}
				toBeSpawned.Add(new SpawnNode(timeoff,type,dir,0.1f + j * 0.2f,false));
			}
			toBeSpawned.Add (new SpawnNode (halfSpacing, 4, dir,0.1f + Random.Range (0, 2) * 0.8f,false));
		}



	}

}