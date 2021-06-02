using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public GameObject[] enemyPrefabs;
    private float spawnRangeX = 15.0f;
    private float spawnPositionZ = 30.0f;

    private float spawnEnemyX = 30.0f;
    private float spawnEnemyZMin = 1.5f;
    private float spawnEnemyZMax = 15f;

    public float startDelay = 2.0f;
    public float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnAnimal", startDelay, spawnInterval);
        InvokeRepeating("SpawnEnemy", startDelay * 2, spawnInterval * 2);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SpawnAnimal()
    {
        int randomAnimalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPosition = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPositionZ);
        GameObject.Instantiate(animalPrefabs[randomAnimalIndex], spawnPosition, animalPrefabs[randomAnimalIndex].transform.rotation);
    }
    public void SpawnEnemy()
    {
        int randomAnimalIndex = Random.Range(0, enemyPrefabs.Length);
        float spawnEnemyX_temp = Random.Range(0, 2) == 0 ? spawnEnemyX : -spawnEnemyX;
        Vector3 spawnPosition = new Vector3(spawnEnemyX_temp, 0 ,Random.Range(spawnEnemyZMin, spawnEnemyZMax));
        GameObject enemy = Instantiate(enemyPrefabs[randomAnimalIndex], spawnPosition, enemyPrefabs[randomAnimalIndex].transform.rotation);
        if (spawnEnemyX_temp < 0)
        {
            enemy.transform.rotation = enemy.transform.rotation * Quaternion.Euler(0, 90f, 0);
        }
        else
        {
            enemy.transform.rotation = enemy.transform.rotation * Quaternion.Euler(0, -90f, 0);
        }
    }
}
