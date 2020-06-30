using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AllowLoad : MonoBehaviour
{
    // Start is called before the first frame update
    public Button buttonLoad;
    void Awake()
    {
        buttonLoad.interactable = false;
        if (PlayerPrefs.HasKey("SavedScore"))
        {
            buttonLoad.interactable = true;
        }
        else
        {
            Debug.Log("no SavedScore");
        }
    }
}
