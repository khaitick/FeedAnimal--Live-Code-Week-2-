using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    

    private float topBound = 35.0f;
    private float bottomBound = -15.0f;

    private float horizontalBound = 35.0f;

    private GameManager gameManager;

    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z >= topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z <= bottomBound)
        {
            gameManager.AddScore(-200);
            Destroy(gameObject);
        }
        else if (transform.position.x > horizontalBound || transform.position.x < -horizontalBound)
        {
            Destroy(gameObject);
        }
    }
}
