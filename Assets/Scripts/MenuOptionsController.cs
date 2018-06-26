using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuOptionsController : MonoBehaviour {
	public Slider gameTipsSlider;
	public Slider qualitySlider;
	public Slider masterVolSlider;
	public Slider musicVolSlider;
	public Slider sfxVolSlider;

    private SoundManager sound;
    private SettingsManager settings;
	// Use this for initialization
	void Start () {
        sound = GameDataManger.manager.soundManager;
        settings = GameDataManger.manager.settings;

		gameTipsSlider.value = settings.gameTips;
		qualitySlider.value = settings.graphicsQuality;
		masterVolSlider.value = settings.masterVolume;
		musicVolSlider.value = settings.musicVolume;
		sfxVolSlider.value = settings.sfxVolume;
	}
	
	
	public void SetQuality(){
		settings.graphicsQuality = (int)qualitySlider.value;
		settings.EnforceSettings ();
	}
	public void SetMasterVol(){
		settings.masterVolume = masterVolSlider.value;
        sound.UpdateVolume();
	}
	public void SetMusicVol(){
		settings.musicVolume = musicVolSlider.value;
        sound.UpdateVolume();
    }
	public void SetSfxVol(){
		settings.sfxVolume = sfxVolSlider.value;
        sound.UpdateVolume();
    }
	public void SetGameTips(){
		settings.gameTips = (int)gameTipsSlider.value;
        
    }
    

}
