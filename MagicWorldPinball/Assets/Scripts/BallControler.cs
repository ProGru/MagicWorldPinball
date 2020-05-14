using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControler : MonoBehaviour
{
    Rigidbody2D rb;
    public float moveSpeed = 2f;
    public GameObject startPosition;
    public bool gameEnded = true;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void GameOver()
    {
        gameEnded = true;
        rb.transform.position = startPosition.transform.position;
        rb.simulated = false;
    }

    public void Restart(float force)
    {
        gameEnded = false;
        rb.simulated = true;
        rb.position = startPosition.transform.position;
        rb.velocity = Vector3.zero;
        rb.angularVelocity = 0f;
        rb.AddForce(new Vector2(0, force));
    }


    private void FixedUpdate()
    {
        rb.AddForce(new Vector2(Input.acceleration.x*moveSpeed, 0));
    }
}
