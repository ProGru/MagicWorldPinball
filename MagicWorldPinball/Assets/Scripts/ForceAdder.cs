using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceAdder : MonoBehaviour
{
    public float force1;
    public float force2;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        BallControler.AddForceToBall(force1, force2);
    }
}
