using UnityEngine;
using System.Collections;

public class MenuRibbonRotator : MonoBehaviour {

	public RectTransform[] ribbons;
	private int[] sign;

	void Start(){
		ribbons = new RectTransform[transform.childCount];
		for(int i = 0; i < transform.childCount; i++){
			ribbons [i] = transform.GetChild (i).GetComponent<RectTransform>();
			}
		sign = new int[ribbons.Length];

		for (int i = 0; i < ribbons.Length; i++) {
			sign [i] = (Random.Range (0, 2));
			sign [i] = (sign [i] * 2) - 1;
		}
	}
	void Update () {
		for (int i = 0; i < ribbons.Length; i++) {
			ribbons [i].Rotate(0.0f,0.0f,1 * sign[i]);
		}
	}
}
