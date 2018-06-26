using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SelectionPopupTwoWay : MonoBehaviour
{
    [HideInInspector]
    public string message;
    [HideInInspector]
    public System.Action actionYes,actionNo;
    public Text tipText;
   // [HideInInspector]
   // public delegate void func();
    [HideInInspector]
    public TwoWayPopup twp;
    bool soundPlayed = false;
    //public Text buttonText;
    //GameController gc;
    // Use this for initialization
    void Start()
    {
        if (!soundPlayed)
        {
            GameDataManger.manager.soundManager.PlayMenuClick();
            soundPlayed = true;
        }
        //gc = GameDataManger.manager.gameController;
        tipText.text = message;
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
    public void YesButton()
    {
        GameDataManger.manager.RemoveFromMessageQueue(gameObject);
        if (twp == TwoWayPopup.yes || twp == TwoWayPopup.both)
        {
            actionYes();
        }
        GameDataManger.manager.soundManager.PlayMenuClick();
        Destroy(gameObject);
    }
    public void CancelButton()
    {
        GameDataManger.manager.RemoveFromMessageQueue(gameObject);
        if (twp == TwoWayPopup.no || twp == TwoWayPopup.both)
        {
            actionNo();
        }

        GameDataManger.manager.soundManager.PlayMenuClick();
        Destroy(gameObject);
    }

}
public enum TwoWayPopup { yes, no, both }

