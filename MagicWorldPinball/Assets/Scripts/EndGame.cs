using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public GameObject spawnPoint;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.transform.position = spawnPoint.transform.position;
    }
}
