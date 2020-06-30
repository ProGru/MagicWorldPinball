
using UnityEngine;
using UnityEngine.UI;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;

public class LogIn : MonoBehaviour
{
    public Button buttonLog;
    public static PlayGamesPlatform platform;
    void Start()
    {
        if (platform == null)
        {
            PlayGamesClientConfiguration config = new PlayGamesClientConfiguration.Builder().Build();
            PlayGamesPlatform.InitializeInstance(config);
            PlayGamesPlatform.DebugLogEnabled = true;
            PlayGamesPlatform.Activate();

            platform = PlayGamesPlatform.Activate();
        }
    
        PlayGamesPlatform.Instance.Authenticate(SignInInteractivity.CanPromptOnce, (result) =>{
        // handle results
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
