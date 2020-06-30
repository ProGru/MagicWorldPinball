using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeToScore : MonoBehaviour
{
    public void OnMouseClick()
    { 
        SceneManager.LoadScene("HighScores"); 
    }
}
