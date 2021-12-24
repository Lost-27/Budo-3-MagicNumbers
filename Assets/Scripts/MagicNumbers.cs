using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class MagicNumbers : MonoBehaviour
{
    public int maxValue = 1000;
    public int minValue = 0;
    private int guess;
    private int score;

    bool gameOver;

    private int defMaxValue;
    private int defMinValue;
    private int defGuess;
    private int defScore;

    public Text mainText;
    public Text secondText;
    public Text scoreText;
    

    void Start()
    {
        score = 0;
        
        defScore = score;
        defGuess = guess;
        defMaxValue = maxValue;
        defMinValue = minValue;

        ResetValue();

        //Debug.Log($"!!!Если число не верно, то нажимай меньше (DownArrow), либо больше (UpArrow)!!! \nЕсли число угадано, нажми (Space)");
    }


    void Update()
    {
        if (!gameOver)
        {
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                maxValue = guess;
                GuessMethod();
            }

            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                minValue = guess;
                GuessMethod();
            }
            if (Input.GetKeyDown(KeyCode.Return))
            {
                gameOver = true;
                secondText.color = new Color(0.0f, 0.7f, 0.0f);
                secondText.text = $"Число угадано! {guess}\n\nНажми Space для рестарта!";
            }
        }
        
        // Сброс игры
        if (Input.GetKeyDown(KeyCode.Space) && gameOver)
        {
            ResetValue();
        }

    }

    private void GuessMethod()
    {
        scoreText.text = $"Кол-во попыток: {++score}";
        guess = (minValue + maxValue) / 2;
        secondText.text = $"Твоё число...{guess}?\n\nЕсли да, нажми Enter!";
    }
    private void ResetValue()
    {
        gameOver = false;
        maxValue = defMaxValue;
        minValue = defMinValue;
        score = defScore;
        guess = defGuess;

        mainText.text = $"Загадай число от {minValue} до {maxValue}.";
        scoreText.text = $"Кол-во попыток: {score}";
        secondText.color = new Color(0.7f, 0.06f, 0.06f);
        secondText.text = "Нажми UpArrow, чтобы начать!";
    }
}
