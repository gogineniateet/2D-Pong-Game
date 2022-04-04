using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float ballSpeed;
    Rigidbody2D ball;
    ScoreManager score;
    public Vector3 startPosition;

    void Start()
    {
        ball = gameObject.GetComponent<Rigidbody2D>();
        score = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        transform.position = startPosition;
        LaunchBall();
    }

    public void RestartPosition()
    {
        ball.velocity = Vector3.zero;
        transform.position = startPosition;
        LaunchBall();
    }

    private void LaunchBall()
    {
        float x = Random.Range(-1, 2);
        float y = Random.Range(-1, 2);
        if (x == 0)
            x = -1;
        else if (y == 0)
            y = -1;

        ball.velocity = new Vector2(ballSpeed * x, ballSpeed * y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "LeftGoal")
        {
            score.Score2Calculator(1);
        }
        else if (collision.gameObject.tag == "RightGoal")
        {
            score.Score1Calculator(1);
        }
    }


}
