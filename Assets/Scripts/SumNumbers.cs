using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SumNumbers : MonoBehaviour
{
    private int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    private int maxSum = 50;
    private int sum;
    private int num;
    private int score;

    bool gameOver;

    public Text mainText;
    public Text numText;
    public Text sumText;
    public Text restText;


    void Start()
    {
        score = 0;
        sum = 0;

        mainText.text = $"Нажимайте цифры на клавиатуре (от 1 до 9).";
        sumText.text = $"Сумма: {sum} + {num} = {sum += num}";
    }

    void Update()
    {
        if (!gameOver)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                num = numbers[0];
                SumMethod();
            }

            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                num = numbers[1];
                SumMethod();
            }

            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                num = numbers[2];
                SumMethod();
            }

            if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                num = numbers[3];
                SumMethod();
            }

            if (Input.GetKeyDown(KeyCode.Alpha5))
            {
                num = numbers[4];
                SumMethod();
            }

            if (Input.GetKeyDown(KeyCode.Alpha6))
            {
                num = numbers[5];
                SumMethod();
            }

            if (Input.GetKeyDown(KeyCode.Alpha7))
            {
                num = numbers[6];
                SumMethod();
            }

            if (Input.GetKeyDown(KeyCode.Alpha8))
            {
                num = numbers[7];
                SumMethod();
            }

            if (Input.GetKeyDown(KeyCode.Alpha9))
            {
                num = numbers[8];
                SumMethod();
            }
        }
        
        if (Input.GetKeyDown(KeyCode.Space) && gameOver)
        {
            ResetValue();
        }

    }

    private void SumMethod()
    {
        ++score;
        numText.text = $"{num}";
        sumText.text = $"Сумма: {sum} + {num} = {sum += num}";
        
        if (sum >= maxSum)
        {
            gameOver = true;
            mainText.text = $"Игра окончена! {sum} >= {maxSum}\n\nКол-во ходов: {score}.";
            restText.gameObject.SetActive(true);
        }
    }
    private void ResetValue()
    {
        gameOver = false;
        sum = 0;
        num = 0;
        score = 0;
        mainText.text = $"Нажимайте цифры на клавиатуре (от 1 до 9).";
        numText.text = $"{num}";
        sumText.text = $"Сумма: {sum} + {num} = {sum += num}";
        restText.gameObject.SetActive(false);
    }
}
