
using UnityEngine;
using UnityEngine.UI;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;

public class LogIn : MonoBehaviour
{
    public Button buttonLog;
    void Start()
    {
        Log();
    }
    public void Log()
    {
         PlayGamesClientConfiguration config = new PlayGamesClientConfiguration.Builder().Build();
         PlayGamesPlatform.InitializeInstance(config);
         PlayGamesPlatform.Activate();
         SignIn();
    }
    void SignIn()
    {
        Debug.Log("Going to log in to GPG");
        Social.localUser.Authenticate(success => 
        { 
            if (success)
            {
               Debug.Log("Process completed successfully!");
               buttonLog.interactable = false;

            }
            else
            {
                Debug.Log("Login failed!");
                buttonLog.interactable = true;
            }
        });
    }

    public static void ShowAchivementsUI()
    {
        Social.ShowAchievementsUI();
    }

    public static void ShowLeaderboardUI()
    {
        PlayGamesPlatform.Instance.ShowLeaderboardUI(GPGSIds.leaderboard_leaderboard_1_student_3);
    }

}
