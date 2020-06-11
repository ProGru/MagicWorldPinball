using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreAdder : MonoBehaviour
{
    public int pointToAdd = 0;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ball")
        {
            BallControler.AddPoint(pointToAdd);
            AudioMenager.sound.Play();
            Scores.hitTargets++;
        }
    }
}
