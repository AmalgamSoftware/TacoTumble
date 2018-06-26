using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	private Rigidbody rb;
	private Transform tf;
	//private float sqMag = 0f;
	public GameController gc;
    private SoundManager sm;
	public LevelBasic level;
	public RectTransform duster;
	public RectTransform dusterHolder;
	public Animator dustAnim; 
	public ParticleSystem dusterRing;
	/*private float height;
	private float width;
	private float heightFactor;
	private float widthFactor;
	private float inverseHeightFactor;
	private float inverseWidthFactor;*/
	private bool firstTouchFrame = false;
	private Camera cam;
	private Vector3 pointToPos;
	[HideInInspector] 
	public bool dusterEnabled = false;

    //private float startMass = 1f;
    private float maxMass = 1.75f;
	private float massAdjust = 0.05f;

	//private float startScale = 1f;
	private float maxScale = 1.5f,minScale = 0.75f;
	private float scaleAdjust = 0.05f;
	private Vector3 scaleAdj;

	//private int debugCounter = 0;
	// Use this for initialization
	void Start () {
        sm = GameDataManger.manager.soundManager;
		cam = Camera.main;
		rb = GetComponent<Rigidbody> ();
		tf = GetComponent<Transform> ();

		scaleAdj = new Vector3 (scaleAdjust, scaleAdjust, scaleAdjust);

		/*height = Screen.height;
		width = Screen.width;
		heightFactor = 10.0f / height;
		widthFactor = 18.0f / width;
		inverseHeightFactor = height / 10.0f;
		inverseWidthFactor = width / 18.0f;*/
	}
	
	// Update is called once per frame
	void Update () {
		if (!GameController.isPaused) {
			if (dusterEnabled) {
				CheckInput ();
			}
			//sqMag = rb.velocity.sqrMagnitude;
		}
		//Debug.Log (duster.position);
		//Debug.Log (WorldToScreen (tf.position));
	}
	void CheckInput(){
        if (Input.touchCount == 3)
        {
            gc.Pause();
        }
        if (firstTouchFrame == true) {
            
			 if (Input.touchCount > 0 && Input.touchCount < 3) {

				firstTouchFrame = false;
				Vector2 point = Input.GetTouch (0).position;
				//Vector3 pos = new Vector3 (point.x * widthFactor - (9.0f), point.y * heightFactor - (5.0f), 0.3f);
				//Vector3 pos = ScreenToWorld(point,0.3f);
				pointToPos.Set(point.x,point.y,0.3f);
				Vector3 pos = cam.ScreenToWorldPoint (pointToPos);
				pos.Set (pos.x, pos.y, 0.3f);

				//duster.position = new Vector2(point.x + 50f, point.y - 50f);
				dusterRing.transform.position = pos;
				dusterRing.Emit (1);
				//DusterAnimate ();
                sm.PlayTickleRandom();


				Collider[] colliders = Physics.OverlapSphere (pos, 2.0f);
				foreach (Collider hit in colliders) {
					if (hit.tag == "Player") {
						Rigidbody hitRb = hit.GetComponentInParent<Rigidbody> ();
						if (hitRb != null) {
							rb.AddExplosionForce (1000, pos, 5.0f);
							}
					}
				}
			}
		}
		if(Input.touchCount == 0){
			firstTouchFrame = true;
		}
	}
	/*Vector3 ScreenToWorld(Vector2 v, float z){
		return new Vector3 (v.x * widthFactor - 9.0f,v.y * widthFactor - 5.0f, z);
	}
	Vector2 WorldToScreen(Vector3 v){
		return new Vector2 ((v.x + 9.0f) * inverseWidthFactor,(v.y + 5.0f) * inverseHeightFactor );
	}
    */
	/*void DusterAnimate(){
		dustAnim.Play ("Duster_Tickle");
	}*/
	void OnTriggerEnter(Collider other){
		if (other.tag == "Pickup") {
			Pickup pu = other.GetComponentInParent<Pickup> ();
			if (level != null) {
				level.ChangeScore (pu.value);
			}
			if (pu.special) {
				if (pu.type == Type.Beef) {
					MassGain ();
				}
				if (pu.type == Type.Cheese) {
					SizeGain ();
				}
				if (pu.type == Type.Lettuce) {
					SizeLoss ();
					MassGain ();
				}
			}
			if (pu.type == Type.Pill) {
				ResetSize ();
				ResetMass ();
			}
            sm.PlayPopRandom();
			pu.SelfDestruct (1);

			/*tf.localScale += new Vector3 (0.01f, 0.01f, 0.01f);
			rb.mass += 0.01f;
			*/

		}
	}
	void MassGain(){
		rb.mass += massAdjust;
		if (rb.mass > maxMass) {
			rb.mass = maxMass;
		}
	}
	void SizeGain(){
		tf.localScale += scaleAdj;
		if (tf.localScale.x > maxScale) {
			tf.localScale = new Vector3 (maxScale, maxScale, maxScale);
		}

	}
	void SizeLoss(){
		tf.localScale -= scaleAdj;
		if (tf.localScale.x < minScale) {
			tf.localScale = new Vector3 (minScale, minScale, minScale);
		}
	
	}
	void ResetSize(){
		tf.localScale = Vector3.one;
	}
	void ResetMass(){
		rb.mass = 1f;
	}
	void OnCollisionEnter(Collision other){
		float hitMag = Vector3.Dot (rb.velocity, other.contacts [0].normal);
        sm.PlayCrashRandom((0.3f + hitMag * 0.10f));
        //Debug.Log(hitMag);
		if (hitMag > 5f) {
			gc.StartScreenShake (10, 0.20f);
            sm.PlayBigCrash();
			//Debug.Log (hitMag);
		}
	}
}





/*Vector2 tfPosScreen = WorldToScreen (tf.position);
				Vector2 riseRun = new Vector2 (tfPosScreen.x - duster.position.x, tfPosScreen.y - duster.position.y);
				float dustAngle = Mathf.Atan (riseRun.y / riseRun.x) * Mathf.Rad2Deg;
				if (dustAngle < 0f) {
					dustAngle += 180f;
				}
				if (riseRun.y < 0f) {
					dustAngle += 180f;
				}
				dustAngle -= 90f;
				dusterHolder.localRotation = Quaternion.Euler(0.0f, 0.0f, dustAngle);
				*/
//Debug.Log(dustAngle);