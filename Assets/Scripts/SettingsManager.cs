using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsManager{
	public int graphicsQuality;
	public float masterVolume;
	public float musicVolume;
	public float sfxVolume;
	public int gameTips;
	public int currentModel;
	public int currentMat;
	public SettingsManager(){
		graphicsQuality = PlayerPrefs.GetInt ("graphicsQuality", 2);
		masterVolume = PlayerPrefs.GetFloat ("masterVolume", 1);
		musicVolume = PlayerPrefs.GetFloat ("musicVolume", 1);
		sfxVolume = PlayerPrefs.GetFloat ("sfxVolume", 1);
		gameTips = PlayerPrefs.GetInt ("gameTips", 1);
		currentModel = PlayerPrefs.GetInt ("currentModel",0);
		currentMat = PlayerPrefs.GetInt ("currentMat",0);
	}
	public void SaveSettings(){
		PlayerPrefs.SetInt ("graphicsQuality", graphicsQuality);
		PlayerPrefs.SetFloat ("masterVolume", masterVolume);
		PlayerPrefs.SetFloat ("musicVolume", musicVolume);
		PlayerPrefs.SetFloat ("sfxVolume", sfxVolume);
		PlayerPrefs.SetInt ("gameTips", gameTips);
		PlayerPrefs.SetInt ("currentModel",currentModel);
		PlayerPrefs.SetInt ("currentMat",currentMat);
		PlayerPrefs.Save ();
	}
	public void EnforceSettings (){
		QualitySettings.SetQualityLevel (graphicsQuality);
	}
}
public class TipTexts{
    public static string[] tips = new string[24] {
		//Tip 0
		"Press 'START' and select the first level to begin!" +
        "\n (You can turn off these tips in the OPTIONS menu.)",
		//Tip 1
		"The Taco moves away from the location you tap! \n" 
        ,
		//Tip 2
		"Move the taco to pick up any and all FOOD PIECES you see! " +
        "This will increase your score. Try it with the GROUND BEEF!",
		//Tip 3
		"A good taco doesn't consist of only meat! \n" +
        "Get some CHEESE in there as well!",
		//TIP 4
		"A good taco has more crunch in it! \n" +
        "Throw in some LETTUCE for good measure!",
		//TIP 5
		"Is it snowing? Time to get creamy! \n" +
        "Throw in a few globs of SOUR CREAM for some perfectly balanced flavor!",
		//Tip 6
		"SPECIAL ingredients are worth three times as much as the normal ones. " +
        "Steak is better than ground beef! Steak also increases the weight of the taco, " +
        "making it easier to maneuver.",
		//Tip 7
		"Real cheese or fake news?\n " +
        "SPECIAL Cheese increases the size of your taco.",
		//Tip 8
		"Lettuce see how you perform in this level... \n" +
        "Collecting SPECIAL Lettuce increases your taco's weight, but decreases its size.",
		//Tip 9
		"Now the real fun begins....",
		//TIP 10
		"Can you be everywhere at once?",
		//TIP 11
		"Feeling small? \n" +
        "PILLS don't add score, but they reset the size and weight of your taco.",
		//TIP 12
		"Decisions...",
		//TIP 13
		"This level rocks.",
		//TIP 14
		"This might require some practice...",
		//TIP 15
		"Fewer pickups, more obstacles.",
		//TIP 16
		"Stay on the path!",
		//TIP 17
		"Keep an eye out!\n Blue VORTEXES attract food, while Pink VORTEXES repel it.",
        //Tip 18
        "If you think you've mastered the taco, now is the time to prove it...",
        //Tip 19
        "Level 18 is Infinite Mode!\n You lose when the timer ticks down to zero. Grabbing food pieces extends the timer. Good Luck!",
        //Tip 20
        "Congratulations, you've beaten the game. Thanks for playing!",
        //Tip 21
        "Tap the screen with three fingers to pause the game.",
        //Tip 22
        "There is a 1 in 3 chance to recieve an ad before each level! Every level in this game is free to play. However, ads can be disabled by purchasing the 'Full Game' item in the shop, which also rewards a 'Supporter' skin.",
        //TIP 23
        "You must get at least 1 star (70 score) to unlock the next level."
	};

}
