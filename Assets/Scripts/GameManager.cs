using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float score = 0.0f;
    public bool gameOver = false;
    public UIManager uiManager;

    public void ScoreIncrease()
    {
        score += 0.02f;
        uiManager.SetScoreText((int)score);
    }

    public void DisplayFinalScore()
    {
        uiManager.SetFinalScore((int)score);
    }
}
