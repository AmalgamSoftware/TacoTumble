using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelStarRotator : MonoBehaviour {

	private RectTransform rtf;
	private Vector3 rotation = Vector3.zero;
	// Use this for initialization
	void Start () {
		rtf = GetComponent<RectTransform> ();
		rotation = new Vector3 (0.0f, 0.0f, 2f);
		rtf.localEulerAngles += new Vector3(0.0f,0.0f,Random.value * 360);
	}
	
	// Update is called once per frame
	void Update () {
		rtf.localEulerAngles += rotation;
	}
}
