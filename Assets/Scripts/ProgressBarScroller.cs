using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ProgressBarScroller : MonoBehaviour {
	public Material mat;
	public Vector2 speed = Vector2.zero;
	// Use this for initialization
	void Start () {
		 
	}
	
	// Update is called once per frame
	void Update () {
		mat.mainTextureOffset += speed;
	}
}
