using UnityEngine.UI;
using UnityEngine;

public class SumNumbers : MonoBehaviour
{
    #region Variables

    public Text HeaderLabel;
    public Text NumLabel;
    public Text SumLabel;
    public Text ResetLabel;

    private const int _maxSum = 50;
    private int _sum;
    private int _num;
    private int _score;

    private bool _isGameOver;

    #endregion


    #region Unity lifecycle

    private void Start()
    {
        ResetValue();
    }

    private void Update()
    {
        if (!_isGameOver)
        {
            for (int number = 1; number <= 9; number++)
            {
                if (Input.GetKeyDown(number.ToString()))
                {
                    _num = number;
                    SumMethod();
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.Space) && _isGameOver)
        {
            ResetValue();
        }
    }

    #endregion


    #region Private methods

    private void SumMethod()
    {
        _score++;
        _sum += _num;
        NumLabel.text = $"{_num}";
        SumLabel.text = $"Сумма: {_sum} + {_num} = {_sum}";

        if (_sum >= _maxSum)
        {
            _isGameOver = true;
            HeaderLabel.text = $"Игра окончена! {_sum} >= {_maxSum}\n\nКол-во ходов: {_score}.";
            ResetLabel.gameObject.SetActive(true);
        }
    }

    private void ResetValue()
    {
        int _sumOld = 0;
        _sum = 0;
        _num = 0;
        _score = 0;
        _isGameOver = false;
        
        HeaderLabel.text = $"Нажимайте цифры на клавиатуре (от 1 до 9).";
         _sumOld = _sum;
        _sum += _num;
        NumLabel.text = $"{_num}";
        
        SumLabel.text = $"Сумма: {_sumOld} + {_num} = {_sum}";
        ResetLabel.gameObject.SetActive(false);
    }

    #endregion
}