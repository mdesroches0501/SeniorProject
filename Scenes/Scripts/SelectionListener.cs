using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionListener : MonoBehaviour
{
    // Each player's currently selected button.
    public intVar player1SelectedButton;
    public intVar player2SelectedButton;

    // Each player's correct answer button.
    public intVar player1AnswerButton;
    public intVar player2AnswerButton;

    // Keys used by each player to select an answer.
    public KeyCode player1SelectionKey;
    public KeyCode player2SelectionKey;

    // Delta time that needs to pass before a selection can be made again.
    public float player1KeyTimer, player2KeyTimer;
    
    public intVar player1Score, player2Score;

    // Delta time remaining
    private float player1Time, player2Time;
    
    private int i1, i2;

    void Start()
    {
        player1Time = player2Time = 0;
        player1Score.SetValue(0); 
        player2Score.SetValue(0);
        i1 = 0;
        i2 = 0;
    }

    void Update()
    {
        player1Time += Time.deltaTime;
        player2Time += Time.deltaTime;

        if (Input.GetKeyDown(player1SelectionKey) && player1Time >= player1KeyTimer)
        {
            if(player1SelectedButton.intValue == player1AnswerButton.intValue)
            {
                // Raise player 1 right answer event.
                Debug.Log("Player1 Correct!");
                player1Score.SetValue(i1 += 10);
            }
            else
            {
                // Raise player 1 wrong answer event.
                Debug.Log("Player1 Incorrect!");
            }

            player1Time = 0;
        }

        if (Input.GetKeyDown(player2SelectionKey) && player2Time >= player2KeyTimer)
        {
            if (player2SelectedButton.intValue == player2AnswerButton.intValue)
            {
                // Raise player 2 right answer event.
                Debug.Log("Player2 Correct!");
                player2Score.SetValue(i2 += 10);
            }
            else
            {
                // Raise player 2 wrong answer event.
                Debug.Log("Player2 Incorrect!");
            }

            player2Time = 0;
        }
    }
}
