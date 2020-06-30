using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarellBehavior : MonoBehaviour
{

    public Vector2 forceToADD;
    public Transform spawnPosition;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ball")
        {
            Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();
            rb.velocity = Vector2.zero;
            rb.angularVelocity = 0;
            rb.gameObject.transform.position = spawnPosition.position;
            rb.AddForce(forceToADD);
            AudioMenager.explosion.Play();
            Debug.Log("add");
        }

    }
}
