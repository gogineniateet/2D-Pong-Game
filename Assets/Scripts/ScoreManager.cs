using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int score1;
    public int score2;
    public Text score1Text;
    public Text score2Text;
    PlayerController player1;
    PlayerController player2;
    BallController ball;

    private void Start()
    {
        player1 = GameObject.Find("Player 1").GetComponent<PlayerController>();
        player2 = GameObject.Find("Player 2").GetComponent<PlayerController>();
        ball = GameObject.Find("Ball").GetComponent<BallController>();
    }

    public void Score1Calculator(int scoreValue1)
    {
        score1 = score1 + scoreValue1;
        score1Text.text = score1.ToString();
        ResetGame();
    }

    public void Score2Calculator(int scoreValue2)
    {
        score2 = score2 + scoreValue2;
        score2Text.text = score2.ToString();
        ResetGame();
    }

    public void ResetGame()
    {
        ball.RestartPosition();
        player1.RestartGame();
        player2.RestartGame();
    }

}
