/*
 * Jake Lahr, Alexandra Pasinski
 * Magic Integrated
 * March 10, 2020
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class keyCycle : MonoBehaviour
{
    public int numOfChoices = 4;

    // Unity variables for other scripts to use to check what each player has selected as an answer.
    public intVar buttonNum;
    public intVar buttonNum2;
    
    public KeyCode player1UpKey;
    public KeyCode player1DownKey;
    public KeyCode player2UpKey;
    public KeyCode player2DownKey;

    // Delta time that needs to pass before a key can be pressed again.
    public float player1KeyTimer, player2KeyTimer;

    // Delta time remaining
    private float player1TimeLeft, player2TimeLeft;

    private int p1 = 0;
    private int p2 = 0;

    void Awake()
    {
        buttonNum.SetValue(p1);
        buttonNum2.SetValue(p2);
    }

    // Update is called once per frame
    void Update()
    {
        player1TimeLeft += Time.deltaTime;
        player2TimeLeft += Time.deltaTime;

        // Increment or decrement player 1 answer selection with a timer to prevent input spam.
        if (Input.GetKeyDown(player1UpKey) && p1 > 0 && player1TimeLeft >= player1KeyTimer)
        {
            buttonNum.SetValue(--p1);
            player1TimeLeft = 0;
        }
        else if (Input.GetKeyDown(player1DownKey) && p1 < numOfChoices - 1 && player1TimeLeft >= player1KeyTimer)
        {
            buttonNum.SetValue(++p1);
            player1TimeLeft = 0;
        }

        // Increment or decrement player 1 answer selection with a timer to prevent input spam.
        if (Input.GetKeyDown(player2UpKey) && p2 > 0 && player2TimeLeft >= player2KeyTimer)
        {
            buttonNum2.SetValue(--p2);
            player2TimeLeft = 0;
        }
        else if (Input.GetKeyDown(player2DownKey) && p2 < numOfChoices - 1 && player2TimeLeft >= player2KeyTimer)
        {
            buttonNum2.SetValue(++p2);
            player2TimeLeft = 0;
        }
    }
}
