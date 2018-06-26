using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdManager{
	string gameID = "1593130";
	GameDataManger gdm;
	bool completeRef;
	public AdManager(GameDataManger gdmVar){
		Advertisement.Initialize (gameID);
		gdm = gdmVar;
	}
	public void ShowAd(){
		ShowOptions options = new ShowOptions { resultCallback = HandleShowResult };
		Advertisement.Show (options);
	}
	private void HandleShowResult(ShowResult result){
		switch (result) {
		case ShowResult.Finished:
			gdm.adFinished = true;
			break;
		case ShowResult.Skipped:
			gdm.adFinished = true;
			break;
		case ShowResult.Failed:
			gdm.adFinished = true;
			break;
		}
	}
}
