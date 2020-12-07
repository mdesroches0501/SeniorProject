/*
 * Jake Lahr
 * Magic Integrated 
 * March 10, 2020
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mathQuestion : MonoBehaviour
{
    public intVar answer;
    public GameObject buttonText1;
    public GameObject buttonText2;
    public GameObject buttonText3;
    public GameObject buttonText4;

    public int displayAns;
    private int wrongAnswer1, wrongAnswer2, wrongAnswer3;
    public intVar answerButton; //choose which button will have the right answer

    public void display()
    {
        // Right answer location (button).
        answerButton.SetValue(Random.Range(0, 4));

        //right answer
        displayAns = answer.intValue;

        //wrong answers
        wrongAnswer1 = Random.Range(-9, 9) + answer.getValue();
        while ((wrongAnswer1 == displayAns))
        {
            wrongAnswer1 = Random.Range(-9, 9) + answer.getValue();
        }

        wrongAnswer2 = Random.Range(-9, 9) + answer.getValue();
        //check if same
        while ((wrongAnswer2 == wrongAnswer1) || (wrongAnswer2 == displayAns))
        {
            wrongAnswer2 = Random.Range(-9, 9) + answer.getValue();
        }

        wrongAnswer3 = Random.Range(-9, 9) + answer.getValue();
        while ((wrongAnswer3 == wrongAnswer2) || (wrongAnswer3 == wrongAnswer1) || (wrongAnswer3 == displayAns))
        {
            wrongAnswer3 = Random.Range(-9, 9) + answer.getValue();
        }

        switch (answerButton.intValue)
        {
            case 0:
                buttonText1.GetComponent<Text>().text = "" + displayAns;
                buttonText2.GetComponent<Text>().text = "" + wrongAnswer1;
                buttonText3.GetComponent<Text>().text = "" + wrongAnswer2;
                buttonText4.GetComponent<Text>().text = "" + wrongAnswer3;
                break;
            case 1:
                buttonText1.GetComponent<Text>().text = "" + wrongAnswer1;
                buttonText2.GetComponent<Text>().text = "" + displayAns;
                buttonText3.GetComponent<Text>().text = "" + wrongAnswer2;
                buttonText4.GetComponent<Text>().text = "" + wrongAnswer3;
                break;
            case 2:
                buttonText1.GetComponent<Text>().text = "" + wrongAnswer1;
                buttonText2.GetComponent<Text>().text = "" + wrongAnswer2;
                buttonText3.GetComponent<Text>().text = "" + displayAns;
                buttonText4.GetComponent<Text>().text = "" + wrongAnswer3;
                break;
            case 3:
                buttonText1.GetComponent<Text>().text = "" + wrongAnswer1;
                buttonText2.GetComponent<Text>().text = "" + wrongAnswer2;
                buttonText3.GetComponent<Text>().text = "" + wrongAnswer3;
                buttonText4.GetComponent<Text>().text = "" + displayAns;
                break;
            default: 
                break;
        }
    }
}
