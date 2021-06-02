using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text scoreText;
    public Text healthText;

    public GameObject pauseMenu;
    public Text finalScoreText;


    private int score;
    private int health;
    void Start()
    {
        score = 0;
        health = 3;
        scoreText.text = score.ToString();
        healthText.text = health.ToString();
        pauseMenu.gameObject.SetActive(false);
    }

    private void Update()
    {
        if(health <= 0)
        {
            GameOver();
        }
    }
    public void GameOver()
    {
        pauseMenu.gameObject.SetActive(true);
        finalScoreText.text = score.ToString();
        Time.timeScale = 0;
    }

    public void AddScore(int value)
    {
        score += value;
        scoreText.text = score.ToString();
    }

    public void AddHealth(int value)
    {
        health += value;
        healthText.text = health.ToString();
    }


}
