using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    private int score = 0;
    [SerializeField] private GameObject scoreCounter;
    private TMP_Text scoreText;

    void Start()
    {
        scoreText = scoreCounter.GetComponent<TMP_Text>();
    }

    /// <summary>
    /// Increases the score by a set amount.
    /// </summary>
    /// <param name="score"></param> The amount the score increases by.
    public void AddScore(int score)
    {
        this.score += score;
        scoreText.text = this.score.ToString();
    }

    /// <summary>
    /// Increases the score by one.
    /// </summary>
    public void AddScore()
    {
        AddScore(1);
    }

    /// <summary>
    /// Sets the score to zero.
    /// </summary>
    public void ResetScore()
    {
        score = 0;
        scoreText.text = "0";
    }

    /// <summary>
    /// Reloads the game scene to restart the game.
    /// </summary>
    public void ResetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
