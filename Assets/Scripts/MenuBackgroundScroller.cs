using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuBackgroundScroller : MonoBehaviour {
	public RectTransform panel1;
	public RectTransform panel2;
	public RectTransform bar1;
	public RectTransform bar2;
	private Vector2 panel1Start;
	//private Vector2 panel1Width;
	private float panelScrollSpeed = 2.0f;
	private float barScrollSpeed = 2.0f;
	private Vector2 panelScrollVec = Vector2.zero;
	private Vector2 barScrollVec = Vector2.zero;
	private float bottomLimit;
	private float screenHeight;

	// Use this for initialization
	void Start () {

		//Debug.Log (Screen.height);
		//Debug.Log (panel2.rect.height);
		screenHeight = panel2.rect.height;
		//screenHeight;
		//panel1.rect.size.Set(panel1.rect.width,screenHeight);

		panel1.anchoredPosition.Set (0f, 0f);
		panel1Start = panel1.anchoredPosition;
		//panel1Width = new Vector2 (panel1.rect.width, panel1.rect.height);
		//panel2.rect.size.Set (panel1.rect.width, screenHeight);
		panel2.anchoredPosition = new Vector2 (panel1.anchoredPosition.x, panel1Start.y + panel2.rect.height);
		bar2.anchoredPosition = new Vector2 (bar1.anchoredPosition.x, bar1.anchoredPosition.y - panel2.rect.height);
		bottomLimit = -screenHeight;
		//bottomLimit;

		panelScrollVec = new Vector2 (0.0f, panelScrollSpeed);
		barScrollVec = new Vector2 (0.0f, barScrollSpeed);
		//Debug.Log (panel1.rect.size.y)



	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log (screenHeight);
		//Debug.Log (panel1.anchoredPosition);
		panel1.anchoredPosition -= panelScrollVec;
		panel2.anchoredPosition -= panelScrollVec;
		bar1.anchoredPosition += barScrollVec;
		bar2.anchoredPosition += barScrollVec;
		CheckForBound (panel1, 0);
		CheckForBound (panel2, 0);
		CheckForBound (bar1, 1);
		CheckForBound (bar2, 1);
	}
	void CheckForBound(RectTransform panel, int direction){
		if (direction == 0) {
			if (panel.anchoredPosition.y <= bottomLimit) {
				//Debug.Log ("BOOGALOO");
				panel.anchoredPosition += new Vector2 (0.0f, screenHeight * 2.0f);
			}
		}
		if (direction == 1) {
			if (panel.anchoredPosition.y >= screenHeight) {
				panel.anchoredPosition -= new Vector2 (0.0f, screenHeight * 2.0f);
			}
		}
	}
}
