using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicParticlePool : MonoBehaviour {

	private List<PhysicParticle> inactiveParts;
	private List<PhysicParticle> activeParts;
	public GameObject physicParticlePrefab;
	public float checkDistance = 0.5f;
	private Transform plr;
	private Vector3 plrPos;
	public int pCounterMax = 25;
	private float pCounterMaxRecip;

	public int max;
	// Use this for initialization
	void Start () {
		pCounterMaxRecip = 30f / (float)pCounterMax;
		plr = GameDataManger.manager.gameController.player.transform;
		inactiveParts = new List<PhysicParticle>();
		activeParts = new List<PhysicParticle>();
		for (int i = 0; i < max; i++) {
			PhysicParticle part = Instantiate (physicParticlePrefab, Vector3.zero, Quaternion.identity).GetComponent<PhysicParticle>();
			inactiveParts.Add(part);
			part.go.SetActive (false);
		}
	}
	
	public void ProduceParticle(Vector3 position, Vector3 vel,Color col){
		bool particleChosen = false;
		int count = 0;
		int countMax = inactiveParts.Count;

		while (!particleChosen) {
			if (count < countMax) {
				if (inactiveParts[count]) {
					PhysicParticle p = inactiveParts [count];
					inactiveParts.Remove (p);
					p.go.SetActive (true);
					p.tf.position = position;
					particleChosen = true;
					activeParts.Add (p);
					p.sprite.color = col;
					p.counter = 0;
					p.velocity = vel;
					float newScale = Random.value * 0.05f + 0.025f;
					p.tf.localScale = new Vector3(newScale,newScale,newScale);
				}
			} else {
				particleChosen = true;
			}
		}
	}

	void Update () {
		plrPos = plr.position;
		int countMax = activeParts.Count;

		for (int i = countMax - 1; i > -1; i--) {
			PhysicParticle p = activeParts [i];
			p.counter += 1;
			if (p.counter >= pCounterMax) {
				//p.tf.position = Vector3.Lerp (p.tf.position, plr.position, 0.1f);
				Vector3 newHeading = (plrPos - p.tf.position);
				p.tf.position += newHeading.normalized * 0.2f * p.counter * pCounterMaxRecip * Time.deltaTime;
				if (newHeading.sqrMagnitude <= checkDistance) {
					p.go.SetActive (false);
					inactiveParts.Add (p);
					activeParts.Remove (p);
				}
			} else {
				p.tf.position += p.velocity * ((float)(pCounterMax - p.counter) * pCounterMaxRecip) * Time.deltaTime ;
			}


		}
	}
}
