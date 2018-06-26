using System.Collections;
using System.Collections.Generic;

using UnityEngine;
#if UNITY_IOS
using UnityEngine.SocialPlatforms.GameCenter;
#endif
using UnityEngine.SocialPlatforms;

public class SocialPlatformManager
{

    float scoreToSubmit = 0;

    public SocialPlatformManager()
    {
        Authenticate();
    }
    void Authenticate()
    {
#if UNITY_IOS
        if (Application.platform == RuntimePlatform.IPhonePlayer)
        {
            Debug.Log("We're on iPhone");
            Social.localUser.Authenticate(ProcessAuthentication);
        }
#endif
    }
    void ProcessAuthentication(bool success)
    {
        #if UNITY_IOS
        if (success)
        {
            //Debug.Log("Aunthenticated");
        }
        else
        {
            System.Action act = () => Authenticate();
           // Debug.Log("Authentication Failed");
            GameDataManger.manager.ShowYesBox(act,"GameCenter Authentication failed. Would you like to try again?");
        }
#endif
    }

    public void ShowLeaderBoard()
    {
#if UNITY_IOS
        if (Application.platform == RuntimePlatform.IPhonePlayer)
        {
            Social.ShowLeaderboardUI();
        }
        else
        {
            GameDataManger.manager.ShowMessage("Error", "Leaderboard functionality is only available on iOS.");
        }
#endif
    }

    public void SubmitHighScoreInfiniteMode(float score)
    {
#if UNITY_IOS
        if (Application.platform == RuntimePlatform.IPhonePlayer)
        {
            scoreToSubmit = score;
            long highScore = (long)score; // Gamecenter requires a long variable
            Social.ReportScore(highScore, "TMT_InfiniteModeScore", HighScoreCheck);
        }

#endif
    }

    void HighScoreCheck(bool result)
    {
#if UNITY_IOS
        if (result)
        {
            //Debug.Log("score submission successful");
            GameDataManger.manager.ShowMessage("Success", "Your high schore was submitted. ");
            ShowLeaderBoard();
        }

        else
        {
            //Debug.Log("score submission failed");
            System.Action act = () => RetryInfiniteModeScoreSubmit ();
            GameDataManger.manager.ShowYesBox(act, "Error: Your high schore was not submitted. Retry?");
        }
#endif
    }

    void RetryInfiniteModeScoreSubmit()
    {
        SubmitHighScoreInfiniteMode(scoreToSubmit);
    }

}
