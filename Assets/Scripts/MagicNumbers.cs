using UnityEngine.UI;
using UnityEngine;

public class MagicNumbers : MonoBehaviour
{
    public int maxValue = 1000;
    public int minValue;
    private int _guess;
    private int _score;

    private bool _gameOver;

    private int _defMaxValue;
    private int _defMinValue;
    private int _defGuess;
    private int _defScore;

    public Text mainText;
    public Text secondText;
    public Text scoreText;
    

    void Start()
    {
        _score = 0;
        
        _defScore = _score;
        _defGuess = _guess;
        _defMaxValue = maxValue;
        _defMinValue = minValue;

        ResetValue();
        
    }


    void Update()
    {
        if (!_gameOver)
        {
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                maxValue = _guess;
                GuessMethod();
            }

            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                minValue = _guess;
                GuessMethod();
            }
            if (Input.GetKeyDown(KeyCode.Return))
            {
                _gameOver = true;
                secondText.color = new Color(0.0f, 0.7f, 0.0f);
                secondText.text = $"����� �������! {_guess}\n\n����� Space ��� ��������!";
            }
        }
        
        // ����� ����
        if (Input.GetKeyDown(KeyCode.Space) && _gameOver)
        {
            ResetValue();
        }

    }

    private void GuessMethod()
    {
        scoreText.text = $"���-�� �������: {++_score}";
        _guess = (minValue + maxValue) / 2;
        secondText.text = $"��� �����...{_guess}?\n\n���� ��, ����� Enter!";
    }
    private void ResetValue()
    {
        _gameOver = false;
        maxValue = _defMaxValue;
        minValue = _defMinValue;
        _score = _defScore;
        _guess = _defGuess;

        mainText.text = $"������� ����� �� {minValue} �� {maxValue}.";
        
        scoreText.text = $"���-�� �������: {_score}";
        
        secondText.color = new Color(0.7f, 0.06f, 0.06f);
        secondText.text = "����� UpArrow, ����� ������!";
    }
}
