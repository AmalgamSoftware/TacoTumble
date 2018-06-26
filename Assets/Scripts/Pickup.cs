using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Type {Beef,Cheese,Lettuce,Cream,Pill,Rock};
public class Pickup : MonoBehaviour {

	public Vector3 velocity = Vector3.zero;
	[HideInInspector]
	public Vector3 pos = Vector3.zero;
	Vector3 rot = Vector3.zero;
	Transform tf;
	public Transform modelTf;
	private float randomRange = 5f;
	public Type type = Type.Beef;
	public Material mat;
	private ParticleSystem.MainModule mn;
	public Color c1, c2, c3, c4;
	private Color cReal;
	public GameObject partPrefab;
	public ParticleSystem part;
	public float xSpeed = 0;
	public bool gravity = true;
	private float timeOffset;
	public int value = 1;
	public bool special = false;
	public LevelBasic level;
    public PhysicParticlePool ppp;
	// Use this for initialization
	void Start () {
        ppp = GameDataManger.manager.gameController.ppp;
		tf = transform;
		rot = new Vector3 (Random.Range(-randomRange,randomRange),Random.Range(-randomRange,randomRange), Random.Range(-randomRange,randomRange));

		//mat = GetComponent<MeshRenderer> ().material;
		switch (type) {
		case Type.Beef:
			cReal = c1;
			break;
		case Type.Cheese:
			cReal = c2;
			break;
		case Type.Lettuce:
			cReal = c3;
			break;
		case Type.Cream:
			cReal = c4;
			break;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (!GameController.isPaused) {
			Movement ();
			pos = tf.position;
		}
		//Debug.Log (velocity.y);
	}
	void Movement(){
		timeOffset = Time.deltaTime * 30;
		if (velocity.y > -0.06f && gravity) {
			velocity += new Vector3 (0.0f, -0.001f * timeOffset, 0.0f);
		}

		modelTf.Rotate (rot * timeOffset);
		tf.position += velocity * timeOffset;
		//tf.rotation.eulerAngles += rot;
		if(Mathf.Abs(tf.position.y) > 7.0f || Mathf.Abs(tf.position.x) > 14f){
			SelfDestruct (0);
		}
	}
	public void SelfDestruct(int tp){
		Destroy (gameObject);
		if (tp == 1) {
			DetachParticle ();
		}
		if (level != null) {
			level.activePickups.Remove (this);
		}
	}
	private void DetachParticle(){
		GameObject partSpawn = (GameObject)Instantiate (partPrefab, tf.position, Quaternion.identity);
		if (type < Type.Pill) {
			mn = partSpawn.GetComponentInChildren<ParticleSystem> ().main;
			mn.startColor = cReal;
		}
		float randRange = 0.2f;
		float randRangeHalf = randRange * 0.5f;

		ppp.ProduceParticle (pos, new Vector3 (Random.value * randRange - randRangeHalf, Random.value * randRange - randRangeHalf,0.0f),cReal);
		ppp.ProduceParticle (pos, new Vector3 (Random.value * randRange - randRangeHalf,Random.value * randRange - randRangeHalf,0.0f),cReal);
		ppp.ProduceParticle (pos, new Vector3 (Random.value * randRange - randRangeHalf, Random.value * randRange - randRangeHalf,0.0f),cReal);

		Destroy (partSpawn, 4f);
	}
}
