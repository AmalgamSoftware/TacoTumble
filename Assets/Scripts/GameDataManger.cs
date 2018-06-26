using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
//using System;


public class GameDataManger : MonoBehaviour {

	public static GameDataManger manager;
	public SettingsManager settings;
	public LevelData levelData;
	public UnlockData unlockData;
	public SocialPlatformManager socialPlat;
	public AdManager adManager;
	[HideInInspector]
	public GameController gameController;
	public GameObject tipPrefab,selectionPrefab,selectionTwoWayPrefab,messagePrefab,unlockPrefab;
	[HideInInspector]
	public Transform mainCanvas;
	[HideInInspector]
	public int currentLevel;
	private string levelFileName = "/leveldatafile.dat";
	private string unlockFileName = "/unlockdatafile.dat";
	[HideInInspector]
	public Image fadePanel;
	[HideInInspector]
	public bool adFinished = false;
    [HideInInspector]
    public string modelUnlockText = "Model Unlocked", matUnlockText = "Skin Unlocked";
    [HideInInspector]
    public List<GameObject> messageQueue;
    [HideInInspector]
    public int messageQueueCount = 0;
    [HideInInspector]
    public bool messageQueueEnabled = true;
    [HideInInspector]
    public SoundManager soundManager;
    [HideInInspector]
    public AssetManager assetManager;
    [HideInInspector]
    public IAPManager iapManager;
	// Use this for initialization
	void Awake () {
		InitializeManager ();
	}
	void Start(){
		StartCoroutine (DelayedStart ());
        messageQueue = new List<GameObject>();
        
	}
	IEnumerator DelayedStart(){
		yield return new WaitForSeconds (0.1f);
		ShowTip (0);
	}
    #region initializeandsaving
    void InitializeManager(){
		if (manager == null) {
			manager = this;
			DontDestroyOnLoad (gameObject);
			InitializeComponents ();
		}
		else{
			Destroy (gameObject);
		}
	}
	void InitializeComponents(){
		Application.targetFrameRate = 30;

		settings = new SettingsManager();
		socialPlat = new SocialPlatformManager ();
		adManager = new AdManager (this);
        soundManager = GetComponentInChildren<SoundManager>();
        assetManager = GetComponentInChildren<AssetManager>();
        LoadLevelData ();
		LoadUnlockData ();
	}
	void LoadLevelData(){
		if (File.Exists (Application.persistentDataPath + levelFileName)) {
			BinaryFormatter bf = new BinaryFormatter ();
			FileStream file = File.Open (Application.persistentDataPath + levelFileName, FileMode.Open);
			levelData = (LevelData)bf.Deserialize (file);
			file.Close ();
		} else {
			levelData.initialize ();
			SaveLevelData ();
		}
	}
	void LoadUnlockData(){
		if (File.Exists (Application.persistentDataPath + unlockFileName)) {
			BinaryFormatter bf = new BinaryFormatter ();
			FileStream file = File.Open (Application.persistentDataPath + unlockFileName, FileMode.Open);
			unlockData = (UnlockData)bf.Deserialize (file);
			file.Close ();
		} else {
			unlockData.initialize ();
			SaveUnlockData ();
		}
	}
	public void SaveLevelData(){
		BinaryFormatter bf = new BinaryFormatter ();
		FileStream file = File.Create (Application.persistentDataPath + levelFileName);
		bf.Serialize (file, levelData);
		file.Close ();
	}
	public void DeleteLevelData(){
		if (File.Exists (Application.persistentDataPath + levelFileName)) {
			File.Delete (Application.persistentDataPath + levelFileName);
		}
		levelData.initialize ();
		SceneManager.LoadSceneAsync ("Intro", LoadSceneMode.Single);
	}
	public void SaveUnlockData(){
		BinaryFormatter bf = new BinaryFormatter ();
		FileStream file = File.Create (Application.persistentDataPath + unlockFileName);
		bf.Serialize (file, unlockData);
		file.Close ();
	}
	public void DeleteUnlockData(){
		if (File.Exists (Application.persistentDataPath + unlockFileName)) {
			File.Delete (Application.persistentDataPath + unlockFileName);
		}
		unlockData.initialize ();
		SceneManager.LoadSceneAsync ("Intro", LoadSceneMode.Single);
	}
    #endregion

    public void UpdateMessageQueue() {
        messageQueueCount = messageQueue.Count;
        
        if (messageQueueEnabled) {
            int count = messageQueueCount;
            for (int i = 0; i < count; i++)
            {
                if (i == 0)
                {
                    messageQueue[i].SetActive(true);
                }
                else
                {
                    messageQueue[i].SetActive(false);
                }
            }
        }
        else
        {
            int count = messageQueueCount;
            for (int i = 0; i < count; i++)
            {
                messageQueue[i].SetActive(false);
            }
        }

    }
    public void AddToMessageQueue(GameObject go) {
        messageQueue.Add(go);
        UpdateMessageQueue();
    }
    public void RemoveFromMessageQueue(GameObject go) {
        messageQueue.Remove(go);
        UpdateMessageQueue();
    }
    public void EnableMessageQueue()
    {
        messageQueueEnabled = true;
        UpdateMessageQueue();
    }
    public void DisableMessageQueue()
    {
        messageQueueEnabled = false;
        UpdateMessageQueue();
    }
    public void ClearMessageQueue()
    {
        messageQueue.Clear();
        messageQueueCount = 0;
    }
    public void ShowTip(int tipNumber){
		if (levelData.tipRead [tipNumber] == false && settings.gameTips == 1) {
			GameObject newTipPanel = (GameObject)Instantiate (tipPrefab, Vector3.zero, Quaternion.identity, null);
			newTipPanel.transform.SetParent (mainCanvas, false);
			newTipPanel.GetComponent<TipPopup> ().tipNumber = tipNumber;
		}
	}
    
    //Outdated but still exists within project
    public void ShowYesOrNoBox(System.Action act,string message){
		System.Action action = () => act();
		GameObject newSelectionPanel = (GameObject)Instantiate (selectionPrefab, Vector3.zero, Quaternion.identity, null);
		newSelectionPanel.transform.SetParent (mainCanvas, false);
		SelectionPopup sp = newSelectionPanel.GetComponent<SelectionPopup> ();
		sp.action = action;
		sp.message = message;

	}
    //Show a message box with an action for both proceeding and canceling the prompt.
    public void ShowYesAndNoBox(System.Action actYes, System.Action actNo, string message)
    {
        System.Action actionYes = () => actYes();
        System.Action actionNo = () => actNo();
        GameObject newSelectionPanel = (GameObject)Instantiate(selectionTwoWayPrefab, Vector3.zero, Quaternion.identity, null);
        newSelectionPanel.transform.SetParent(mainCanvas, false);
        SelectionPopupTwoWay sp = newSelectionPanel.GetComponent<SelectionPopupTwoWay>();
        sp.twp = TwoWayPopup.both;
        sp.actionYes = actionYes;
        sp.actionNo = actionNo;
        sp.message = message;

    }
    //Show a message box with an action for proceeding.
    public void ShowYesBox(System.Action actYes, string message)
    {
        System.Action actionYes = () => actYes();
        GameObject newSelectionPanel = (GameObject)Instantiate(selectionTwoWayPrefab, Vector3.zero, Quaternion.identity, null);
        newSelectionPanel.transform.SetParent(mainCanvas, false);
        SelectionPopupTwoWay sp = newSelectionPanel.GetComponent<SelectionPopupTwoWay>();
        sp.twp = TwoWayPopup.yes;
        sp.actionYes = actionYes;
        sp.message = message;

    }
    //Show a message box with an action for canceling the prompt.
    public void ShowNoBox(System.Action actNo, string message)
    {
        System.Action actionNo = () => actNo();
        GameObject newSelectionPanel = (GameObject)Instantiate(selectionTwoWayPrefab, Vector3.zero, Quaternion.identity, null);
        newSelectionPanel.transform.SetParent(mainCanvas, false);
        SelectionPopupTwoWay sp = newSelectionPanel.GetComponent<SelectionPopupTwoWay>();
        sp.twp = TwoWayPopup.no;
        sp.actionNo = actionNo;
        sp.message = message;

    }
    public void ShowMessage(string titleMessage,string textMessage){
		GameObject newMessagePanel = (GameObject)Instantiate (messagePrefab, Vector3.zero, Quaternion.identity, null);
		newMessagePanel.transform.SetParent (mainCanvas, false);
		MessagePopup mp = newMessagePanel.GetComponent<MessagePopup> ();
		mp.titleString = titleMessage;
		mp.textString = textMessage;
	}
    public void UnlockWithMessage(int ModelSkinNeither, int num, string titleMessage, string textMessage)
    {
        if (ModelSkinNeither == 0)
        {
            if (unlockData.modelUnlocks[num]) {
                return;
            }
            else
            {
                unlockData.modelUnlocks[num] = true;
            }
        }else if(ModelSkinNeither == 1)
        {
            if (unlockData.matUnlocks[num])
            {
                return;
            }
            else
            {
                unlockData.matUnlocks[num] = true;
            }
        }
        SaveUnlockData();
        GameObject newMessagePanel = (GameObject)Instantiate(unlockPrefab, Vector3.zero, Quaternion.identity, null);
        newMessagePanel.transform.SetParent(mainCanvas, false);
        MessagePopup mp = newMessagePanel.GetComponent<MessagePopup>();
        mp.titleString = titleMessage;
        mp.textString = textMessage;
        mp.special = true;
        


    }

    public void FadeToBlack(bool toOrFrom,string sceneName){
		if (fadePanel != null) {
			fadePanel.gameObject.SetActive (true);
			StartCoroutine (FadeRoutine (toOrFrom,sceneName));
		}
	}
	public IEnumerator FadeRoutine(bool toOrFrom, string sceneName){
		int frameLength = 30;
		float colorIncrements = 1f / frameLength;
		if (toOrFrom) {
			fadePanel.color = Color.clear;
			for (int i = 0; i < frameLength; i++) {
				fadePanel.color = new Color(0,0,0,i * colorIncrements);
				yield return null;
			}
			fadePanel.color = Color.black;
			SceneManager.LoadSceneAsync (sceneName, LoadSceneMode.Single);
		} else {
			fadePanel.color = Color.black;
			for (int i = 0; i < frameLength; i++) {
				fadePanel.color = new Color(0,0,0,1 - i * colorIncrements);
				yield return null;
			}
			fadePanel.color = Color.clear;
			fadePanel.gameObject.SetActive (false);
		}
	}
	public IEnumerator StartGameAfterAd(int level){
        if(unlockData.fullGame == false)
        {
            adFinished = false;
            adManager.ShowAd();
            while (!adFinished)
            {
                yield return null;
            }
        }
		StartGame (level);
		yield return null;
	}
	public void StartGame(int level){
		currentLevel = level;
		FadeToBlack (true, "game");
	}
}
