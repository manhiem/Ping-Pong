using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Goal : MonoBehaviour
{
    public bool isPlayer1Goal;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Ball"))
        {
        if(!isPlayer1Goal)
        {
            GameObject.Find("GameManager").GetComponent<Manager>().Player1_Scored();

        }
        else
        {
            GameObject.Find("GameManager").GetComponent<Manager>().Player2_Scored();
        }
        }
    }
}
