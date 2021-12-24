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

        //Debug.Log($"!!!���� ����� �� �����, �� ������� ������ (DownArrow), ���� ������ (UpArrow)!!! \n���� ����� �������, ����� (Space)");
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
                secondText.text = $"����� �������! {guess}\n\n����� Space ��� ��������!";
            }
        }
        
        // ����� ����
        if (Input.GetKeyDown(KeyCode.Space) && gameOver)
        {
            ResetValue();
        }

    }

    private void GuessMethod()
    {
        scoreText.text = $"���-�� �������: {++score}";
        guess = (minValue + maxValue) / 2;
        secondText.text = $"��� �����...{guess}?\n\n���� ��, ����� Enter!";
    }
    private void ResetValue()
    {
        gameOver = false;
        maxValue = defMaxValue;
        minValue = defMinValue;
        score = defScore;
        guess = defGuess;

        mainText.text = $"������� ����� �� {minValue} �� {maxValue}.";
        scoreText.text = $"���-�� �������: {score}";
        secondText.color = new Color(0.7f, 0.06f, 0.06f);
        secondText.text = "����� UpArrow, ����� ������!";
    }
}
