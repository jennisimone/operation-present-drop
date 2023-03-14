﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public bool canPlay;

    private void Start() {
        canPlay = true;
        gameOverCanvas.SetActive(false);
        Time.timeScale = 1;
    }

    public void GameOver() {
        canPlay = false;
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void Replay() {
        SceneManager.LoadScene(1);
    }

    public void Back() {
        SceneManager.LoadScene(0);
    }
}
