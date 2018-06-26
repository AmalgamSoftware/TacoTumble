using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundFollow : MonoBehaviour {

	private Material mat;
	//private Texture text;

	void Start () {
		mat = GetComponent<Image> ().material;
		//text = GetComponent<Image> ().mainTexture;

	}
	void Update(){
		mat.SetTextureOffset("_MainTex",new Vector2(Time.time,0f));
        
	}

}