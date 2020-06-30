using System.Collections;
using System.Collections.Generic;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeToCredits : MonoBehaviour
{
    public void OnMouseClick()
    {
        BallControler.UnlockAchivement(GPGSIds.achievement_hidden_achievement_2); 
        SceneManager.LoadScene("Credits"); 
    }
}
