using System;
using TMPro;
using UnityEngine;

public class WinSetting : MonoBehaviour
{
    public MainGuessConfig guessConfig;
    public TextMeshProUGUI GuessLabel;

    void Start()
    {
        GuessLabel.text = Convert.ToString (guessConfig.Guess);
    }
}