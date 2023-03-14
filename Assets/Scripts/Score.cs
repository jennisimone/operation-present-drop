using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static int score = 0;
    public int currentScore = 0;
    public UnityEngine.UI.Text scoreText;

    private void Start() 
    {
        score = 0;    
    }

    private void Update() 
    {
        currentScore = score;
        scoreText.text = score.ToString();
    }
}
