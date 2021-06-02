using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject projectileSpawnPoint;

    public float speed = 25.0f;
    public float xRange = 15.0f;

    public float yRangeA = 8f;
    public float yRangeB = 2f;
    public GameObject projectilePrefab;

    private float HorizontalInput;
    private float verticalInput;

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject.Instantiate(projectilePrefab, projectileSpawnPoint.transform.position, projectilePrefab.transform.rotation);
        }
    }

    public void PlayerMovement()
    {
        HorizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        if(transform.position.z >= yRangeA)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, yRangeA);
        }else if(transform.position.z <= yRangeB)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, yRangeB);
        }

        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        transform.Translate(Vector3.right * Time.deltaTime * speed * HorizontalInput);
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);


    }
}
