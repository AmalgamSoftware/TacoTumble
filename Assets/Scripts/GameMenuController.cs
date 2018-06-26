using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMenuController : MonoBehaviour {

	public List<Button> buttons;
	public AnimationCurve animCurve;
	public RectTransform optionsPanel;
	public Image OptionsSound, OptionsGame, OptionsDisplay;
	public GameObject OptionsSoundPanel,OptionsGamePanel,OptionsDisplayPanel;
	public Color selected, deselected;


	//private float width;
	// Use this for initialization
	void Start () {
		//width = Screen.width;
		//ButtonOptionsGame ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	private void SetMenuButtons(bool cond){
		foreach (Button b in buttons) {
			b.interactable = cond;
		}
	}
	public void ButtonOptions(){
		StartCoroutine(ButtonTransition(30, optionsPanel,Vector2.zero,true));
	}
	/*public void ButtonOptionsBack(){
		StartCoroutine(ButtonTransition(30, optionsPanel,new Vector2(-width * 1.3f,0.0f),false));
		GameDataManger.manager.settings.SaveSettings ();
	}
	public void ButtonOptionsSound(){
		OptionsGame.color = deselected;
		OptionsDisplay.color = deselected;
		OptionsSound.color = selected;

		OptionsDisplayPanel.SetActive (false);
		OptionsGamePanel.SetActive (false);
		OptionsSoundPanel.SetActive (true);
	}
	public void ButtonOptionsDisplay(){
		OptionsGame.color = deselected;
		OptionsDisplay.color = selected;
		OptionsSound.color = deselected;

		OptionsDisplayPanel.SetActive (true);
		OptionsGamePanel.SetActive (false);
		OptionsSoundPanel.SetActive (false);
	}
	public void ButtonOptionsGame(){
		OptionsGame.color = selected;
		OptionsDisplay.color = deselected;
		OptionsSound.color = deselected;

		OptionsDisplayPanel.SetActive (false);
		OptionsGamePanel.SetActive (true);
		OptionsSoundPanel.SetActive (false);
	}*/
	public IEnumerator ButtonTransition(int frames, RectTransform rt, Vector2 endPos,bool enableOrDisable){
		SetMenuButtons (false);
		if (enableOrDisable) {
			rt.gameObject.SetActive (true);
		}
		Vector2 startPos = new Vector2 (rt.localPosition.x,rt.localPosition.y);
		Vector2 movement = endPos - startPos;
		for (int i = 1; i <= frames; i++) {
			float evalPoint = (float)i / (float)frames;
			float eval = animCurve.Evaluate (evalPoint);
			rt.localPosition = new Vector3 (startPos.x + movement.x * eval, startPos.y + movement.y * eval, 0.0f);
			yield return null;

		}
		SetMenuButtons (true);
		if (!enableOrDisable) {
			rt.gameObject.SetActive (false);
		}
	}
}
