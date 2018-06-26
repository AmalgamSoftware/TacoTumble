using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine;

[System.Serializable]
public class UnlockData{
	public bool[] modelUnlocks;
	public bool[] matUnlocks;
    public bool fullGame;
    public float confettiMultiplier;
    public int donatedDollars;
	public void initialize(){
		modelUnlocks = new bool[7];
		matUnlocks = new bool[6];
        
		for (int i = 0; i < 6; i++) {
			if (i == 0) {
				modelUnlocks[i] = true;
				matUnlocks[i] = true;
			} else {
				modelUnlocks[i] = false;
				matUnlocks[i] = false;
			}
		}
        fullGame = false;
        confettiMultiplier = 1f;
        donatedDollars = 0;
        GameDataManger.manager.settings.currentMat = 0;
        GameDataManger.manager.settings.currentModel = 0;
        GameDataManger.manager.settings.SaveSettings();
    }
	public void UnlockModel(int unlockIndex){
		modelUnlocks [unlockIndex] = true;
		GameDataManger.manager.SaveUnlockData ();
	}
	public void UnlockMat(int unlockIndex){
		matUnlocks [unlockIndex] = true;
		GameDataManger.manager.SaveUnlockData ();
	}
    public void UnlockFullGame()
    {
        fullGame = true;
        GameDataManger.manager.UnlockWithMessage(1, 4, GameDataManger.manager.matUnlockText, "Your support is much appreciated! Taco Tumble is now ad-free. For your patronage, you have been awarded the 'SUPPORTER' skin. Head over to the 'Skins' tab to equip it.");
        GameDataManger.manager.SaveUnlockData();
    }
    public void AddDonatedDollars(int num)
    {
        donatedDollars += num;
        if(donatedDollars >= 10)
        {
            GameDataManger.manager.UnlockWithMessage(0, 4, GameDataManger.manager.modelUnlockText, "Your donations have totaled more than $10! As recognition for your generosity (and apparent wealth), you've received the 'Money' playermodel. Head over to the 'Models' tab to equip this fat stack.");
        }
    }


}