using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreAdder : MonoBehaviour
{
    public int pointToAdd = 0;
    public AudioSource sound;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        BallControler.AddPoint(pointToAdd);
        sound.Play();
    }
}
