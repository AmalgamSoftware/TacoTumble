using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessagePopup : MonoBehaviour {
	[HideInInspector]
	public string titleString, textString;
	public Text titleText;
	public Text tipText;
	public Text buttonText;
    [HideInInspector]
    public bool special = false;
    private bool soundPlayed = false;
	GameController gc;
	// Use this for initialization
	void Start () {
		titleText.text = titleString;
		tipText.text = textString;

		int rand = Random.Range (1, 11);
		string chosenOK;
		if (rand == 10 || rand == 9) {
			chosenOK = "WHAT?!";
		} else if (rand == 8 || rand == 7) {
			chosenOK = "YEAH!";
		} else {
			chosenOK = "OKAY!";
		}
		buttonText.text = chosenOK;
        if (special)
        {
            if (!soundPlayed)
            {
                GameDataManger.manager.soundManager.PlayUnlockJingle();
                soundPlayed = true;
            }

        }
        GameDataManger.manager.AddToMessageQueue(gameObject);
    }
    private void OnEnable()
    {
        //Debug.Log("hello");
        if (special)
        {
            if (!soundPlayed)
            {
                GameDataManger.manager.soundManager.PlayUnlockJingle();
                soundPlayed = true;
            }
            
        }
    }
    public void OkButton(){
        GameDataManger.manager.RemoveFromMessageQueue(gameObject);
        GameDataManger.manager.soundManager.PlayMenuClick();
        Destroy(gameObject);
	}

}
