using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Player player;
    int score;
    public Text scoreText;
    public GameObject playButton;
    public GameObject gameOverText;

    void Awake() {
        Application.targetFrameRate = 60;
        Pause();
    }

    public void Pause() {
        Time.timeScale = 0;
        player.enabled = false;
    }

    public void Play() {
        score = 0;
        scoreText.text = score.ToString();
        playButton.SetActive(false);
        gameOverText.SetActive(false);
        player.enabled = true;
        Time.timeScale = 1;
    }

    public void GameOver() {
        gameOverText.SetActive(true);
        playButton.SetActive(true);
        Pause();
    }

    public void IncreaseScore() {
        score++;
        scoreText.text = score.ToString();
    }
}
