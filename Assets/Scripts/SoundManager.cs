using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    private SettingsManager settings;
    public AudioSource sfxSrc,sfxSrcPS,sfxSrcAlt,musicSrc;
    private AudioClip chosen;
    public AudioClip menuClick, confettiPuff, unlockJingle, menuSlide,menuSlideBack, pop1,pop2,pop3,cashRustle,tickle1,tickle2,tickle3,crash1,crash2,crash3,countdownLow,countdownHigh;
    public AudioClip musicMain, musicLevel, musicScore;

    [HideInInspector]
    public bool musicMainPlaying = false;
    
    [HideInInspector]
    public float masterVol, musicVol, sfxVol;

    float fadeKey = 0;
    // Use this for initialization
    void Start () {
        settings = GameDataManger.manager.settings;
        UpdateVolume();
        //menuClick.LoadAudioData();
        
	}
    public void UpdateVolume() {
        masterVol = settings.masterVolume;
        musicVol = settings.musicVolume * masterVol * 0.5f;
        sfxVol = settings.sfxVolume * masterVol;
        musicSrc.volume = musicVol;
        sfxSrc.volume = sfxVol;
        sfxSrcPS.volume = sfxVol;
        sfxSrcAlt.volume = sfxVol;
    }

    public void LoadMenuMusic()
    {
        musicMain.LoadAudioData();
    }
    public void UnloadMenuMusic()
    {
        musicMain.UnloadAudioData();
    }
    public void LoadLevelMusic()
    {
        musicLevel.LoadAudioData();
    }
    public void LoadScoreMusic()

    {
        musicScore.LoadAudioData();
    }
    #region sfx
    public void PlayMenuClick() {

        sfxSrc.pitch = Random.Range(0.8f, 1.2f);
        sfxSrc.PlayOneShot(menuClick, sfxVol * 0.1f);
        
    }
    public void PlayMenuSlide() {
        sfxSrc.pitch = Random.Range(0.9f, 1.1f);
        sfxSrc.PlayOneShot(menuSlide, sfxVol * 0.4f);
    }
    public void PlayMenuSlideBack()
    {
        sfxSrc.pitch = Random.Range(0.9f, 1.1f);
        sfxSrc.PlayOneShot(menuSlideBack, sfxVol * 0.4f);
    }
    public void PlayConfettiPuff() {
        sfxSrc.PlayOneShot(confettiPuff, sfxVol * 0.7f);
    }
    public void PlayConfettiPuffMenu()
    {
        sfxSrc.pitch = Random.Range(0.85f, 1.15f);
        sfxSrc.PlayOneShot(confettiPuff, sfxVol * 0.4f);
    }
    public void PlayUnlockJingle()
    {
        sfxSrc.pitch = 1f;
        sfxSrc.PlayOneShot(unlockJingle, sfxVol * 0.5f);
    }
    public void PlayPopRandom()
    {
        chosen = pop1;
        int rando = Random.Range(0, 3);
        switch (rando)
        {
            case 0:
                break;
            case 1:
                chosen = pop2;
                break;
            case 2:
                chosen = pop3;
                break;
        }
        sfxSrc.PlayOneShot(chosen, 0.5f * sfxVol);
    }
    public void PlayPop(int whichOfThree)
    {
        chosen = pop1;
        switch (whichOfThree)
        {
            case 0:
                break;
            case 1:
                chosen = pop2;
                break;
            case 2:
                chosen = pop3;
                break;
        }
        sfxSrc.PlayOneShot(chosen, 0.5f * sfxVol);
    }
    public void PlayCashRustle()
    {
        float pitch = Random.Range(0.9f, 1.1f);
        sfxSrc.pitch = pitch;
        sfxSrc.PlayOneShot(cashRustle, 0.3f * sfxVol);
        sfxSrc.pitch = 1f;
    }
    public void PlayTickleRandom()
    {
        chosen = tickle1;
        int rando = Random.Range(0, 3);
        sfxSrc.pitch = Random.Range(0.9f, 1.1f);
        switch (rando)
        {
            case 0:
                break;
            case 1:
                chosen = tickle2;
                break;
            case 2:
                chosen = tickle3;
                break;
        }
        sfxSrc.PlayOneShot(chosen, Random.Range(0.2f, 0.25f) * sfxVol);
    }
    public void PlayCrashRandom(float volumeMod)
    {
        chosen = crash1;
        int rando = Random.Range(0, 2);
        sfxSrc.pitch = Random.Range(0.8f, 1.2f);
        switch (rando)
        {
            case 0:
                break;
            case 1:
                chosen = crash2;
                break;
        }
        sfxSrc.PlayOneShot(chosen, 0.7f * volumeMod * sfxVol);
    }
    public void PlayBigCrash()
    {
        sfxSrc.pitch = Random.Range(0.8f, 1.2f);
        sfxSrcAlt.PlayOneShot(crash3, 0.5f * sfxVol);
    }
    public void PlayCountdownLow() {
        sfxSrcPS.PlayOneShot(countdownLow, 0.3f * sfxVol);
    }
    public void PlayCountdownHigh()
    {
        sfxSrcPS.PlayOneShot(countdownHigh, 0.3f * sfxVol);
    }
    #endregion
    #region music
    public void FadeOutMusic(float time) 
    {
        StartCoroutine(FadeOutMusicRoutine(time));
    }
    public void FadeInMusic(float time)
    {
        StartCoroutine(FadeInMusicRoutine(time));
    }
    private IEnumerator FadeOutMusicRoutine(float time) {

        float key = NewFadeKey();
        float step = musicSrc.volume / (time * 30f);
        AudioClip clip = musicSrc.clip;
        while(musicSrc.volume > 0 && key == fadeKey)
        {
            musicSrc.volume -= step;
            yield return null;
        }
        if (key == fadeKey)
        {
            musicSrc.volume = 0f;
            clip.UnloadAudioData();
        }
    }
    private IEnumerator FadeInMusicRoutine(float time)
    {
        float key = NewFadeKey();
        float step = musicVol / (time * 30f);
        float count = 0f;
        float countMax = time * 30f;
        musicSrc.volume = 0;
        
        while (count < countMax && key == fadeKey)
        {
            count += 1f;
            musicSrc.volume = count * step;
            yield return null;
        }
        if(key == fadeKey)
        {
            musicSrc.volume = musicVol;
        }
        
    }
    public void PlayMusicMain()
    {
        musicSrc.clip = musicMain;
        musicSrc.loop = true;
        musicSrc.Play();
    }
    /*public void PlayMusicMainWithIntro()
    {
        musicSrc.clip = musicMainIntro;
        musicSrc.Play();
        musicSrc.loop = false;
        StartCoroutine(IntroFinished());
    }
    IEnumerator IntroFinished() {
        yield return new WaitForSeconds(musicMainIntro.length);
        musicSrc.clip = musicMain;
        musicSrc.Play();
        musicSrc.loop = true;

    }*/
    public void PlayMusicLevel()
    {
        UpdateVolume();
        musicSrc.loop = true;
        musicSrc.clip = musicLevel;
        musicSrc.Play();
    }
    public void PlayMusicScore()
    {
        sfxSrcPS.PlayOneShot(musicScore , 0.5f);
    }
    #endregion

    private float NewFadeKey()
    {
        float newKey = 0f;
        do { newKey = Random.value; } while (newKey == fadeKey);
        fadeKey = newKey;
        return newKey;
    }

}
