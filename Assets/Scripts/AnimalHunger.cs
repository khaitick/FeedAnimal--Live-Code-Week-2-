using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimalHunger : MonoBehaviour
{
    public Slider healthSlider;
    public int takeDamage;
    public int scoreFed;
    public int amountToBeFed;
    private int currentFed = 0;
    private GameManager gameManager;

    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

        healthSlider.maxValue = amountToBeFed;
        healthSlider.value = 0;
        healthSlider.fillRect.gameObject.SetActive(false);
    }

    public void FeedAnimal()
    {
        currentFed += takeDamage;
        healthSlider.fillRect.gameObject.SetActive(true);
        healthSlider.value = currentFed;

        if(currentFed >= amountToBeFed)
        {
            gameManager.AddScore(scoreFed);
            Destroy(gameObject);
        }
    }
}
