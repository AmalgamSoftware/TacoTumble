using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectionPopup : MonoBehaviour {
	[HideInInspector]
	public string message;
	[HideInInspector]
	public System.Action action;
	public Text tipText;
    private bool soundPlayed = false;
	//[HideInInspector]
	//public delegate void func();
	//public Text buttonText;
	//GameController gc;
	// Use this for initialization
	void Start () {
		//gc = GameDataManger.manager.gameController;
		tipText.text = message;
        GameDataManger.manager.AddToMessageQueue(gameObject);
        if (!soundPlayed)
        {
            GameDataManger.manager.soundManager.PlayMenuClick();
            soundPlayed = true;
        }
    }
    private void OnEnable()
    {
        if (!soundPlayed)
        {
            GameDataManger.manager.soundManager.PlayMenuClick();
            soundPlayed = true;
        }
    }
    public void YesButton(){
        GameDataManger.manager.RemoveFromMessageQueue(gameObject);
        action ();
        GameDataManger.manager.soundManager.PlayMenuClick();
        Destroy (gameObject);
    }
    public void CancelButton(){
        GameDataManger.manager.RemoveFromMessageQueue(gameObject);
        GameDataManger.manager.soundManager.PlayMenuClick();
        Destroy (gameObject);
    }

}
