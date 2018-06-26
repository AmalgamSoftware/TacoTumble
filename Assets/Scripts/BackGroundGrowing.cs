using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundGrowing : MonoBehaviour {

	public Material mat;
	private Vector2 offset = Vector2.zero;
	//private Vector2 movement = Vector2.zero;
	public float magnitude = 0.032f;
	public float accel = 0.0000125f;
	private int nameID;
	private float timedelta;
	// Use this for initialization
	void Start () {
		nameID = Shader.PropertyToID ("_MainTex");
		mat.SetTextureOffset (nameID, offset);
		//movement = Random.insideUnitCircle.normalized * magnitude;

	}

	// Update is called once per frame
	void Update () {
		magnitude += accel;
		offset.Set (0.0f, offset.y + magnitude * Time.deltaTime);
		mat.SetTextureOffset (nameID, offset);
	}
}
