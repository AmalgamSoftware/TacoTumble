using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public GameObject pickupPrefab;
	public Material bf, cz, lc, sc;
	private int counter = 60;
	// Use this for initialization
	void Start () {
		//SpawnPickup ();


	}
	
	// Update is called once per frame
	void Update () {
		counter++;
		if(counter % 60 == 1){
			SpawnPickup ();
		}

	}
	void SpawnPickup (){
		float pos = Random.Range (-8f, 8f);
		GameObject pickup = (GameObject)Instantiate (pickupPrefab, new Vector3 (pos, 5.5f, 0.0f), Quaternion.identity);
		Pickup pickupScript = pickup.GetComponent<Pickup> ();
		int tacoType = Random.Range (0, 4);
		switch (tacoType) {
		case 0:
			pickupScript.type = Type.Beef;
			pickup.GetComponentInChildren<Renderer> ().material = bf;
			break;
		case 1:
			pickupScript.type = Type.Cheese;
			pickup.GetComponentInChildren<Renderer> ().material = cz;

			break;
		case 2:
			pickupScript.type = Type.Lettuce;
			pickup.GetComponentInChildren<Renderer> ().material = lc;

			break;
		case 3:
			pickupScript.type = Type.Cream;
			pickup.GetComponentInChildren<Renderer> ().material = sc;

			break;
		}
	}
}
