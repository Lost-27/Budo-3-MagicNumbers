using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu(fileName = nameof(MainGuessConfig), menuName = "Configs/MainGuess")]
public class MainGuessConfig : ScriptableObject
{
    #region Variables

    public int Guess;
    public int MaxValue;
    public int MinValue;
    public bool IsMoreButtonActive;
    public bool IsLessButtonActive;
    public bool IsTrueButtonActive;

    #endregion

    #region Public methods

    public void LoadScene(int index)
    {
        SceneManager.LoadScene(index);
    }

    public void ResetActiveScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Quit()
    {
        EditorApplication.isPlaying = false;
        Application.Quit();
    }

    public void LessBtnPressed()
    {
        IsLessButtonActive = true;
    }

    public void MoreBtnPressed()
    {
        IsMoreButtonActive = true;
    }
    public void TrueBtnPressed()
    {
        IsTrueButtonActive = true;
    }

    #endregion
}