using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnTouch : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ball")
        {
            BallControler.PlaySparkleAnimation();
            Destroy(this.gameObject);
            Debug.Log("Destroy");
        }
    }

}
