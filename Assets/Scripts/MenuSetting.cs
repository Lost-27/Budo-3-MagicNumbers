using System;
using UnityEngine;
using UnityEngine.UI;

public class MenuSetting : MonoBehaviour
{
    public InputField FromNum;
    public InputField ToNum;
    public MainGuessConfig guessConfig;

    private void Start()
    {
        OptionRangeValue();
    }

    public void OptionRangeValue()
    {
        if (FromNum.text != string.Empty && ToNum.text != string.Empty)
        {
            guessConfig.MinValue = int.Parse(FromNum.text);
            guessConfig.MaxValue = int.Parse(ToNum.text);
        }
        else if (FromNum.text != string.Empty && ToNum.text == string.Empty)
        {
            guessConfig.MinValue = int.Parse(FromNum.text);
            guessConfig.MaxValue = 1000;
        }
        else if (FromNum.text == string.Empty && ToNum.text != string.Empty)
        {
            guessConfig.MinValue = 0;
            guessConfig.MaxValue = int.Parse(ToNum.text);
        }
        else
        {
            guessConfig.MinValue = 0;
            guessConfig.MaxValue = 1000;
        }

        FromNum.GetComponent<InputField>().placeholder.GetComponent<Text>().text = Convert.ToString(guessConfig.MinValue);
        ToNum.GetComponent<InputField>().placeholder.GetComponent<Text>().text = Convert.ToString(guessConfig.MaxValue);
    }
}