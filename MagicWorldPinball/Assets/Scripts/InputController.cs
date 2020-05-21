using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{

    private Vector3 touchPoint;
    private Vector3 exitPoint;
    public BallControler ballControler;

    void Update()
    {
        StartingSpring();
    }

    public void StartingSpring()
    {
        if (ballControler.gameEnded)
        {
            if (Input.GetMouseButtonDown(0))
            {
                touchPoint = Input.mousePosition;
            }
            if (Input.GetMouseButtonUp(0))
            {
                exitPoint = Input.mousePosition;
                ballControler.Restart(Vector3.Distance(touchPoint, exitPoint) * 2);
            }
        }
    }
}
