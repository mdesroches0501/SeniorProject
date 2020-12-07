using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public GameObject scoreBox1;
    public GameObject scoreBox2;
    
    public intVar score1;
    public intVar score2;

    // Update is called once per frame
    void Update()
    {
        scoreBox1.GetComponent<Text>().text = "" + score1.getValue();
        scoreBox2.GetComponent<Text>().text = "" + score2.getValue();
    }
}
