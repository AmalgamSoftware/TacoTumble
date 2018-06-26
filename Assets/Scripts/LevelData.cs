using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine;

[System.Serializable]
public class LevelData{
	public bool[] tipRead;
	public List<IndLevel> levels;
	public void initialize(){
		tipRead = new bool[30];
		levels = new List<IndLevel> ();
		for (int i = 0; i < 18; i++) {
			IndLevel ind = new IndLevel();
            ind.unlocked = false;
            ind.amountOfStars = 0;
            ind.score = 0f;
			if (i == 0) {
				ind.unlocked = true;
                //ind.amountOfStars = 3;
			}
			levels.Add(ind);
		}
	}

}
[System.Serializable]
public class IndLevel{
	public int amountOfStars;
	public float score;
	public bool unlocked;
	public IndLevel(){
		amountOfStars = 0;
		score = 0.0f;
		unlocked = false;
	}

}
