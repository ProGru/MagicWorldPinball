﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public BallControler ballControler;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        ballControler.GameOver();
    }
}
