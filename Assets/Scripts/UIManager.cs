using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text scoreText;
    public Text finalScore;

    public void SetScoreText(int score)
    {
        scoreText.text = "Score : " + score;
    }

    public void SetFinalScore(int score)
    {
        finalScore.text = "Final Score : " + score;
    }
}
