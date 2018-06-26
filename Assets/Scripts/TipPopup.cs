using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TipPopup : MonoBehaviour {

	public int tipNumber;
	public Text tipText;
	public Text buttonText;
	GameController gc;
    private bool soundPlayed = false;
	// Use this for initialization
	void Start () {
        //Debug.Log(tipNumber);
		GameDataManger.manager.levelData.tipRead [tipNumber] = true;
		gc = GameDataManger.manager.gameController;
		if (gc != null) {
			gc.Pause ();
		}
		tipText.text = TipTexts.tips [tipNumber];
		string chosenOK;
		int rand = Random.Range (1, 11);
		if (rand == 10 || rand == 9) {
			chosenOK = "WHAT?!";
		} else if (rand == 8 || rand == 7) {
			chosenOK = "YEAH!";
		} else {
			chosenOK = "OKAY!";
		}
		buttonText.text = chosenOK;

        if (!soundPlayed)
        {
            GameDataManger.manager.soundManager.PlayMenuClick();
            soundPlayed = true;
        }
        //Obligatory for popup gameobjects
        GameDataManger.manager.AddToMessageQueue(gameObject);
	}
    private void OnEnable()
    {
        if (!soundPlayed)
        {
            GameDataManger.manager.soundManager.PlayMenuClick();
            soundPlayed = true;
        }

    }
    public void OkButton(){
		if (gc != null) {
			gc.UnPause ();
		}
        GameDataManger.manager.RemoveFromMessageQueue(gameObject);
        GameDataManger.manager.soundManager.PlayMenuClick();
        Destroy (gameObject);
	}

}
