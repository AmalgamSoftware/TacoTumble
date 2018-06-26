using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTemplate : MonoBehaviour {

	public List<EventNode> toBeSpawned;
	public LevelBasic level;
	// Use this for initialization
	protected virtual void Start () {
		level = gameObject.GetComponent<LevelBasic> ();
		toBeSpawned = level.toBeSpawned;
		LoadList ();
		level.LevelSetup ();
	}
	protected virtual void LoadList (){

	}
}

