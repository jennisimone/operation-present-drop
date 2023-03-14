using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdFlyComponent : MonoBehaviour
{
    public GameManager gameManager;
    public HighScore highScore;
    public float velocity = 2;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() {
        if (gameManager.canPlay) {
            if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space)) {
                Time.timeScale = 1;
                rb.velocity = Vector2.up * velocity;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        gameManager.GameOver();
        highScore.SetHighscore();
    }
}
