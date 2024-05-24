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
    [SerializeField] private GameObject deathScreen;

    void Start()
    {
        scoreText = scoreCounter.GetComponent<TMP_Text>();
    }

    public void AddScore(int score)
    {
        this.score += score;
        scoreText.text = this.score.ToString();
    }

    public void AddScore()
    {
        AddScore(1);
    }

    public void ResetScore()
    {
        score = 0;
        scoreText.text = "0";
    }

    public void ResetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
