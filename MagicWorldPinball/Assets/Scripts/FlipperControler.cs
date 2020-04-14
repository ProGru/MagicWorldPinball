using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipperControler : MonoBehaviour
{
    public HingeJoint2D lefthingeJoint2D;
    public HingeJoint2D righthingeJoint2D;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    IEnumerator FlipperRight()
    {
        righthingeJoint2D.useMotor = true;
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(0.1f);

        righthingeJoint2D.useMotor = false;
    }

    IEnumerator FlipperLeft()
    {
        lefthingeJoint2D.useMotor = true;
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(0.1f);

        lefthingeJoint2D.useMotor = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            StartCoroutine(FlipperLeft());
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            StartCoroutine(FlipperRight());
        }

    }
}
