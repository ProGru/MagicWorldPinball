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
    public static GameObject sparkles;
    public GameObject sparklesObject;
    public int playTime;
    public static BallControler ballControler;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sparkles = sparklesObject;
        ballControler = this;
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
        if (Scores.maxScore < score)
        {
            Scores.maxScore = score;
        }
        score = 0;
        SetScore();
        Scores.plays++;
        AudioMenager.rune.Play();
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

    public static void PlaySparkleAnimation()
    {
        sparkles.transform.position = rb.transform.position;
        ballControler.PlayEffect();
    }


    public void PlayEffect()
    {
        StartCoroutine(BallBehavior());
    }

    public IEnumerator BallBehavior()
    {
        sparkles.SetActive(true);
        yield return new WaitForSeconds(playTime);
        sparkles.SetActive(false);
    }
}
