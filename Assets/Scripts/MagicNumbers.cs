using UnityEngine.UI;
using UnityEngine;

public class MagicNumbers : MonoBehaviour
{
    #region Variables

    public int MaxValue = 1000;
    public int MinValue;
    public Text HeaderLabel;
    public Text ScoreLabel;
    public Text SecondLabel;

    private int _guess;
    private int _score;
    private int _defMaxValue;
    private int _defMinValue;

    private bool _isGameOver;

    #endregion


    #region Unity lifecycle

    void Start()
    {
        _defMaxValue = MaxValue;
        _defMinValue = MinValue;

        ResetValue();
    }


    void Update()
    {
        if (!_isGameOver)
        {
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                MaxValue = _guess;
                GuessMethod();
            }

            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                MinValue = _guess;
                GuessMethod();
            }

            if (Input.GetKeyDown(KeyCode.Return))
            {
                _isGameOver = true;
                SecondLabel.color = new Color(0.0f, 0.7f, 0.0f);
                SecondLabel.text = $"Число угадано! {_guess}\n\nНажмите Space для рестарта!";
            }
        }


        if (_isGameOver && Input.GetKeyDown(KeyCode.Space))
        {
            ResetValue();
        }
    }

    #endregion


    #region Private methods

    private void GuessMethod()
    {
        _score++;
        UpdateScoreLable();
        _guess = (MinValue + MaxValue) / 2;
        SecondLabel.text = $"Твоё число...{_guess}?\n\nЕсли да, нажми Enter!";
    }

    private void UpdateScoreLable()
    {
        ScoreLabel.text = $"Кол-во попыток: {_score}";
    }

    private void ResetValue()
    {
        _score = 0;
        _isGameOver = false;
        MaxValue = _defMaxValue;
        MinValue = _defMinValue;

        HeaderLabel.text = $"Загадай число от {MinValue} до {MaxValue}.";
        UpdateScoreLable();
        SecondLabel.color = new Color(0.7f, 0.06f, 0.06f);
        SecondLabel.text = "Нажмите UpArrow, чтобы начать!";
    }

    #endregion
}