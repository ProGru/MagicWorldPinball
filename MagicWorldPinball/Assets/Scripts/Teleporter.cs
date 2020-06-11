using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public Transform spawnPosition;

    public GameObject effect;

    public int secondToWait;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ball")
        {
            Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();
            StartCoroutine(BallBehavior(rb));

        }
    }

    IEnumerator BallBehavior(Rigidbody2D rb)
    {
        rb.simulated = false;
        rb.transform.position = this.transform.position;
        if (effect != null)
        {
            effect.SetActive(true);
            AudioMenager.teleport.Play();
        }
        yield return new WaitForSeconds(secondToWait);
        rb.gameObject.transform.position = spawnPosition.position;
        rb.simulated = true;
        if (effect != null)
        {
            effect.SetActive(false);
            AudioMenager.teleport.Play();
        }
    }

}
