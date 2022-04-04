using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int score1;
    public int score2;
    public Text score1Text;
    public Text score2Text;
    PlayerController player1;
    PlayerController player2;
    BallController ball;
    public GameObject resetPanel;

    private void Start()
    {
        player1 = GameObject.Find("Player 1").GetComponent<PlayerController>();
        player2 = GameObject.Find("Player 2").GetComponent<PlayerController>();
        ball = GameObject.Find("Ball").GetComponent<BallController>();
    }
    private void Update()
    {
        
    }
    public void Score1Calculator(int scoreValue1)
    {
        score1 = score1 + scoreValue1;
        score1Text.text = score1.ToString();
        ResetGame();
        if(score1 == 5)
        {
            resetPanel.SetActive(true);
            Debug.Log("Player 2 WON");
        }
    }

    public void Score2Calculator(int scoreValue2)
    {
        score2 = score2 + scoreValue2;
        score2Text.text = score2.ToString();
        ResetGame();
        if (score2 == 5)
        {
            resetPanel.SetActive(true);
            Debug.Log("Player 1 WON");
        }
    }
    public void TaskOnClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ResetGame()
    {
        ball.RestartPosition();
        //player1.RestartGame();
        //player2.RestartGame();
    }

}
