using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Manager : MonoBehaviour
{
    [Header("Ball")]
    public GameObject ball;

    [Header("Player 1")]
    public GameObject player1_Paddle;
    public GameObject player1_Goal;

    [Header("Player 2")]
    public GameObject player2_Paddle;
    public GameObject player2_Goal;

    [Header("Score UI")]
    public GameObject Player1_Text;
    public GameObject Player2_Text;

    private int Player1_Score;
    private int Player2_Score;

    public void Player1_Scored()
    {
        Player1_Score++;
        Player1_Text.GetComponent<TextMeshProUGUI>().text = Player1_Score.ToString();
        ResetPosition();
    }

    public void Player2_Scored()
    {
        Player2_Score++;
        Player2_Text.GetComponent<TextMeshProUGUI>().text = Player2_Score.ToString();
        ResetPosition();
    }

    private void ResetPosition()
    {
        ball.GetComponent<Ball>().Reset();
        player1_Paddle.GetComponent<Paddle>().Reset();
        player2_Paddle.GetComponent<Paddle>().Reset();
    }



}
