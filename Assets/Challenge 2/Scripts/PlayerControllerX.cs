using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float dogIntervalCD = 1.0f;
    public float dogInterval;

    private void Start()
    {
        dogInterval = dogIntervalCD;
    }

    // Update is called once per frame
    void Update()
    {
        if (dogInterval > 0)
        {
            dogInterval = dogInterval - Time.deltaTime;
        }

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && dogInterval <= 0)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            dogInterval = dogIntervalCD;
        }
    }
}
