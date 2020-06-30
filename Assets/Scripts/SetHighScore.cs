using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SetHighScore : MonoBehaviour
{
    public TextMeshProUGUI score1;
    public TextMeshProUGUI score2;
    public TextMeshProUGUI score3;

    void Awake()
    {
        SetScores();
    }
    public void SetScores(){
        int score1value = 0;
        int score2value = 0;
        int score3value = 0;
        if (PlayerPrefs.HasKey("Score1"))
        {
            score1value = PlayerPrefs.GetInt("Score1");
        }
        if (PlayerPrefs.HasKey("Score2"))
        {
            score2value = PlayerPrefs.GetInt("Score2");
        }
        if (PlayerPrefs.HasKey("Score3"))
        {
            score3value = PlayerPrefs.GetInt("Score3");
        }
        score1.SetText(score1value.ToString());
        score2.SetText(score2value.ToString());
        score3.SetText(score3value.ToString());
    }
    public void ClearSave()
    { 
        PlayerPrefs.DeleteKey("SavedScore");
    }
    public void ClearScores()
    { 
        PlayerPrefs.SetInt("Score1", 0);
        PlayerPrefs.SetInt("Score2", 0);
        PlayerPrefs.SetInt("Score3", 0);
        SetScores();
    }
}
