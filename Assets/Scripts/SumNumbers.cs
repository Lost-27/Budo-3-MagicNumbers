using UnityEngine.UI;
using UnityEngine;

public class SumNumbers : MonoBehaviour
{
    private readonly int[] _numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    private int _maxSum = 50;
    private int _sum;
    private int _num;
    private int _score;

    private bool _gameOver;

    public Text mainText;
    public Text numText;
    public Text sumText;
    public Text restText;


    void Start()
    {
        _score = 0;
        _sum = 0;

        mainText.text = $"Нажимайте цифры на клавиатуре (от 1 до 9).";
        sumText.text = $"Сумма: {_sum} + {_num} = {_sum += _num}";
    }

    void Update()
    {
        if (!_gameOver)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                _num = _numbers[0];
                SumMethod();
            }

            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                _num = _numbers[1];
                SumMethod();
            }

            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                _num = _numbers[2];
                SumMethod();
            }

            if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                _num = _numbers[3];
                SumMethod();
            }

            if (Input.GetKeyDown(KeyCode.Alpha5))
            {
                _num = _numbers[4];
                SumMethod();
            }

            if (Input.GetKeyDown(KeyCode.Alpha6))
            {
                _num = _numbers[5];
                SumMethod();
            }

            if (Input.GetKeyDown(KeyCode.Alpha7))
            {
                _num = _numbers[6];
                SumMethod();
            }

            if (Input.GetKeyDown(KeyCode.Alpha8))
            {
                _num = _numbers[7];
                SumMethod();
            }

            if (Input.GetKeyDown(KeyCode.Alpha9))
            {
                _num = _numbers[8];
                SumMethod();
            }
        }
        
        if (Input.GetKeyDown(KeyCode.Space) && _gameOver)
        {
            ResetValue();
        }

    }

    private void SumMethod()
    {
        ++_score;
        numText.text = $"{_num}";
        sumText.text = $"Сумма: {_sum} + {_num} = {_sum += _num}";
        
        if (_sum >= _maxSum)
        {
            _gameOver = true;
            mainText.text = $"Игра окончена! {_sum} >= {_maxSum}\n\nКол-во ходов: {_score}.";
            restText.gameObject.SetActive(true);
        }
    }
    private void ResetValue()
    {
        _gameOver = false;
        _sum = 0;
        _num = 0;
        _score = 0;
        mainText.text = $"Нажимайте цифры на клавиатуре (от 1 до 9).";
        numText.text = $"{_num}";
        sumText.text = $"Сумма: {_sum} + {_num} = {_sum += _num}";
        restText.gameObject.SetActive(false);
    }
}
