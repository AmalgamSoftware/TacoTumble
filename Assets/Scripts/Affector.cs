using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Affector : MonoBehaviour {
	public bool type;
	private float typeMod;
	public LevelBasic level;
	private int counter = 0;
	private Vector3 heading = Vector3.zero;
	public int duration;
	private float radius = 5f;
	private float power = 0.004f;
	private float repulsePower = 0.004f;
	private float attractPower = 0.015f;
	private float dampening = 0.98f;
	private float radiusSquared;
	private float dist;
	private Transform tf;
	public Transform tTf;
	public Rigidbody tRb;
	public GameObject particlePackage;
	public GameObject attPart, repPart;
	// Use this for initialization
	void Start () {
		level = GameDataManger.manager.gameController.level;
		tTf = level.gc.playerTf;
		tRb = tTf.GetComponent<Rigidbody> ();
		tf = GetComponent<Transform> ();
		if (type == false) {
			typeMod = -1;
			power = attractPower;
			GameObject part = (GameObject)Instantiate (attPart,tf,false);
			particlePackage = part;
		}
		if (type == true) {
			typeMod = 1;
			power = repulsePower;
			GameObject part = (GameObject)Instantiate (repPart,tf,false);
			particlePackage = part;
		}

		radiusSquared = radius * radius;
	}
	
	// Update is called once per frame
	void Update () {
		duration -= 1;
		if (duration <= 0) {
			SelfDestruct ();
		}
		counter++;
		if (counter == 2) {
			Affect ();
			counter = 0;
		}
	}
	void Affect(){
		int c = level.activePickups.Count;
		for (int i = 0; i < c; i++) {
			ApplyEffect (ref level.activePickups [i].velocity, level.activePickups [i].pos, 1f);
		}
		if (tTf != null) {
			ApplyToRigidbody (tRb, tTf.position);
		}
	}
	void ApplyToRigidbody(Rigidbody rb, Vector3 _pos){
		Vector3 veloc = rb.velocity;

		ApplyEffect (ref veloc, _pos,70f);

		rb.velocity = veloc;
	}
	void ApplyEffect(ref Vector3 vel, Vector3 pos, float powerScale){
		heading = pos - tf.position;
		//heading = level.activePickups [i].pos - tf.position;
		dist = Vector3.SqrMagnitude (heading);
		if (dist < radiusSquared) {
			vel += (heading.normalized * power * typeMod * powerScale);
			vel *= dampening;
			//level.activePickups [i].velocity += (Vector3.Normalize (heading) * power);
		}
	}
	void SelfDestruct(){
		particlePackage.transform.parent = null;
		Destroy (particlePackage, 5f);
		foreach (ParticleSystem p in particlePackage.GetComponentsInChildren<ParticleSystem>()) {
			ParticleSystem.EmissionModule em = p.emission;
			em.enabled = false;
		}
		Destroy (gameObject);
	}
}
