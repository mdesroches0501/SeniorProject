using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class keySelection : MonoBehaviour
{
    public intVar selectedButton;

    private Button _button;

    public int buttonValue;
    // Start is called before the first frame update
    void Start()
    {
        _button = GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        if (selectedButton.intValue == buttonValue)
        {
            FadeToColor(_button.colors.highlightedColor);
        }
        else
        {
            FadeToColor(_button.colors.normalColor);
        }
    }

    void FadeToColor(Color color)
    {
        Graphic graphic = GetComponent<Graphic>();
        graphic.CrossFadeColor(color, _button.colors.fadeDuration, true, true);
    }
}
