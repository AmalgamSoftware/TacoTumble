using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundPlane : MonoBehaviour {

	public Material mat;
	private Vector2 offset = Vector2.zero;
	private Vector2 movement = Vector2.zero;
	public float magnitude;
	private int nameID;
	private float timedelta;
	// Use this for initialization
	void Start () {
		nameID = Shader.PropertyToID ("_MainTex");
		mat.SetTextureOffset (nameID, offset);
		movement = Random.insideUnitCircle.normalized * magnitude;

	}
	
	// Update is called once per frame
	void Update () {
		
		offset.Set (offset.x + movement.x * Time.deltaTime, offset.y + movement.y * Time.deltaTime);
		mat.SetTextureOffset (nameID, offset);
	}
}
