using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HighScore : MonoBehaviour
{
    public static int highScore = 0;
    public Score currentScore;

    private void Start()
    {
        highScore = GetHighScore();
    }

    private void Update()
    {
            GetComponent<UnityEngine.UI.Text>().text = highScore.ToString();

    }

    public void SetHighscore()
    {
        if (currentScore.currentScore > highScore)
        {
            highScore = currentScore.currentScore;
            SaveHighScore(highScore);
        }
    }

    private int GetHighScore()
    {
        if (PlayerPrefs.HasKey("highscore"))
        {
            int highscore = PlayerPrefs.GetInt("highscore");
            return highscore;
        } 
        else
        {
            PlayerPrefs.SetInt("highscore", 0);
            PlayerPrefs.Save();
            return 0;
        }
    }

    private void SaveHighScore(int highscore)
    {
        PlayerPrefs.SetInt("highscore", highscore);
        PlayerPrefs.Save();
    }
}
