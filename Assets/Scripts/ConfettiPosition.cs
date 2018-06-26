using UnityEngine;
using System.Collections;

public class ConfettiPosition : MonoBehaviour {

	public Transform confetti;
	public ParticleSystem part;
	private float height;
	private float width;
	private float heightFactor;
	private float widthFactor;
	private bool firstFrame = true;
    private int baseEmissionAmount = 15;
    private int emissionAmount;
	void Start () {
		height = Screen.height;
		width = Screen.width;
		heightFactor = 10.0f / height;
		widthFactor = 18.0f / width;
        UpdateEmissionAmount();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.touchCount > 0) {
			if (firstFrame == true) {
                UpdateEmissionAmount();
				firstFrame = false;
				Vector2 point = Input.GetTouch (0).position;
				confetti.position = new Vector3 (point.x * widthFactor - (9.0f), point.y * heightFactor - (5.0f), confetti.position.z);
				part.Emit (emissionAmount);
                GameDataManger.manager.soundManager.PlayConfettiPuffMenu();
			}
		}
		if (Input.touchCount == 0) {
			firstFrame = true;
		}
	}
    public void UpdateEmissionAmount() {
        emissionAmount = baseEmissionAmount + Mathf.RoundToInt((float)baseEmissionAmount * (float)GameDataManger.manager.unlockData.donatedDollars * 0.2f);
    }
}
