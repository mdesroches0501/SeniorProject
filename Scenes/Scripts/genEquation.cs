/*
 * Jake Lahr
 * Magic Integrated 
 * March 10, 2020
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class genEquation : MonoBehaviour
{
    public GameObject TextBox1;
    public GameObject TextBox2;
    public intVar levelSelect;
    public intVar answer1;
    public intVar answer2;
    public int firstNumber;
    public int secNumber;
    public int eq;
    public int level;
    // Start is called before the first frame update
    private void Start()
    {
            levelSelect.SetValue(level);
    }
    public int randNum()
    {
        return Random.Range(1, 10);
    }

    public void randEqa(int p)
    {
        firstNumber = randNum();
        secNumber = randNum();
        //if levelSelect equals 1 the equation is (+,-)
        if (levelSelect)
        {
            eq = Random.Range(0, 2);
            if (eq == 0)
            {
                if(p == 1)
                {
                    TextBox1.GetComponent<Text>().text = firstNumber + " - " + secNumber;
                    answer1.SetValue(firstNumber - secNumber);
                }
                if(p == 2)
                {
                    TextBox2.GetComponent<Text>().text = firstNumber + " - " + secNumber;
                    answer2.SetValue(firstNumber - secNumber);
                }
            }
            else
            {
                if(p == 1)
                {
                    TextBox1.GetComponent<Text>().text = firstNumber + " + " + secNumber;
                    answer1.SetValue(firstNumber + secNumber);
                }
                if(p == 2)
                {
                    TextBox2.GetComponent<Text>().text = firstNumber + " + " + secNumber;
                    answer2.SetValue(firstNumber + secNumber);
                }
            }
        }
    }
}
