using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialTintController : MonoBehaviour {

	public Color col;
	private int nameID;
	public Material[] mats;
	// Use this for initialization
	void Awake () {
		nameID = Shader.PropertyToID ("_Color");
	}
	
	// Update is called once per frame

	public void SetColors(Color c){
		int l = mats.Length;
		for (int i = 0; i < l; i++) {
			if (mats [i] != null) {
				mats [i].SetColor (nameID, c);
			}
		}
	}
}
