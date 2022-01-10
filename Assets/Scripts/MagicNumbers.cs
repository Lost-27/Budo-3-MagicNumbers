using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MagicNumbers : MonoBehaviour
{
    #region Variables

    public MainGuessConfig GuessConfig;

    public TextMeshProUGUI HeaderLabel;
    public TextMeshProUGUI ScoreLabel;
    public TextMeshProUGUI SecondLabel;

    private int _maxValue;
    private int _minValue;
    private int _guess;
    private int _score;

    private bool _isGameOver;

    #endregion


    #region Unity lifecycle

    private void Awake()
    {
        _maxValue = GuessConfig.MaxValue;
        _minValue = GuessConfig.MinValue;
    }

    private void Start()
    {
        HeaderLabel.text = $"Загадай число от {_minValue} до {_maxValue}.";
        UpdateScoreLable();
        GuessMethod();
    }


    private void Update()
    {
        if (!_isGameOver)
        {
            if (Input.GetKeyDown(KeyCode.DownArrow) || GuessConfig.IsLessButtonActive)
            {
                GuessConfig.IsLessButtonActive = false;
                _maxValue = _guess;
                GuessMethod();
            }

            if (Input.GetKeyDown(KeyCode.UpArrow) || GuessConfig.IsMoreButtonActive)
            {
                GuessConfig.IsMoreButtonActive = false;
                _minValue = _guess;

                GuessMethod();
            }

            if (Input.GetKeyDown(KeyCode.Return) || GuessConfig.IsTrueButtonActive)
            {
                GuessConfig.IsTrueButtonActive = false;
                GuessConfig.Guess = _guess;
                SceneManager.LoadScene(2);
            }
        }
    }

    #endregion


    #region Private methods

    private void GuessMethod()
    {
        _score++;
        UpdateScoreLable();
        _guess = (_minValue + _maxValue) / 2;
        SecondLabel.text = $"Твоё число...{_guess}?";
    }

    private void UpdateScoreLable()
    {
        ScoreLabel.text = $"Кол-во попыток: {_score}";
    }

    #endregion
}