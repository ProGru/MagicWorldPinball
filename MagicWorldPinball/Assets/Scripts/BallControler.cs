using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BallControler : MonoBehaviour
{
    static Rigidbody2D  rb;
    public float moveSpeed = 2f;
    public GameObject startPosition;
    public bool gameEnded = true;
    public GameObject popupPrefab;
    public TextMeshProUGUI scoreText;
    static public int score = 0;

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
        Instantiate(popupPrefab, startPosition.transform.position, Quaternion.identity, this.transform);
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
        Nudding();
        SetScore();
    }

    public void Nudding()
    {
        rb.AddForce(new Vector2(Input.acceleration.x * moveSpeed, 0));
    }

    public void SetScore()
    {
        scoreText.SetText(score.ToString());
    }

    public static void AddPoint(int points)
    {
        score += points;
    }

    public static void AddForceToBall(float force1, float force2)
    {
        rb.AddForce(new Vector2(force1, force2));
    }
}
