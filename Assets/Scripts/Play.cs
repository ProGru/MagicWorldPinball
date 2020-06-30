using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    public void NewGame()
    { 
        PlayerPrefs.SetInt("Mode", 0);
        SceneManager.LoadScene("SampleScene"); 
    }

    public void LoadGame()
    { 
        PlayerPrefs.SetInt("Mode", 1);
        SceneManager.LoadScene("SampleScene"); 
    }
}
