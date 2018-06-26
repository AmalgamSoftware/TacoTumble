using UnityEngine;
using System.Collections;

public class TacoLogoBurst : MonoBehaviour {

	public ParticleSystem part;
    
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void ParticleBurst(){
		
		for (int i = 0; i < 400; i++) {
			//part.main.startColor = Random.ColorHSV();
			part.Emit (1);
		}
	}
}
