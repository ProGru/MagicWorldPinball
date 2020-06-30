using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{

    private Vector3 touchPoint = Vector3.zero;
    private Vector3 exitPoint;
    public BallControler ballControler;
    public GameObject start;
    public GameObject end;
    public GameObject block;

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
                touchPoint = Vector3.zero;
                block.transform.position = start.transform.position;
            }
            else
            {
                if (touchPoint != Vector3.zero)
                {
                    float distance = Vector3.Distance(touchPoint, Input.mousePosition);
                    if (distance > 2000)
                    {
                        distance = 2000;
                    }

                    float SEdistance = Vector3.Distance(start.transform.position, end.transform.position);
                    block.transform.position = new Vector3(start.transform.position.x, start.transform.position.y - SEdistance * (distance / 2000),block.transform.position.z);
                }
            }
        }
    }
}
