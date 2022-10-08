using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    private TMP_Text scoreText;
    private int score = 0;

    void Start()
    {
        instance = this;
        scoreText = GetComponent<TMP_Text>();
    }

    public void AddScore(int score)
    {
        this.score += score;
        UpdateScoreText();
    }

    public void ResetScore()
    {
        score = 0;
        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        scoreText.text = score.ToString();
    }
}
