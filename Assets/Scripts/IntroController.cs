using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class IntroController : MonoBehaviour {

    public GameObject ContinueText;
    public Image fadePanel;
	// Use this for initialization
	void Start () {
        StartCoroutine(StartupSequence());
        GameDataManger.manager.soundManager.LoadMenuMusic();
        GameDataManger.manager.soundManager.PlayMusicMain();
        GameDataManger.manager.soundManager.FadeInMusic(1.5f);
        GameDataManger.manager.soundManager.musicMainPlaying = true;

        GameDataManger.manager.fadePanel = fadePanel;
    }
	
	// Update is called once per frame
    private IEnumerator StartupSequence()
    {
        ContinueText.SetActive(false);
        yield return new WaitForSeconds(3f);
        ContinueText.SetActive(true);
        yield return new WaitForSeconds(45f);
        Text[] texts = ContinueText.GetComponentsInChildren<Text>();
        foreach(Text t in texts)
        {
            t.text = "Uh... Hello?";
        }

    }
	void Update () {
		if (Input.touchCount > 0) {
			MenuScene ();
		}
        if (Input.GetMouseButtonDown(0)) {
            MenuScene();
        }
	}
	void MenuScene(){
        GameDataManger.manager.FadeToBlack(true, "MenuScene");
	}
}
