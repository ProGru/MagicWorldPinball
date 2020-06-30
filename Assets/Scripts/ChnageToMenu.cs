using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChnageToMenu : MonoBehaviour
{
    public void OnMouseClick()
    { 
        SceneManager.LoadScene("MainMenu"); 
    }
}
