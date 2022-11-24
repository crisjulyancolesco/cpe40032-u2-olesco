using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 18;
    private float spawnPosZ = 30;
    private float startDelay = 2;
    private float spawnInterval = 2;

    // Start is called before the first frame update
    void Start()
    {
        // To repeatedly spawn random animal at a interval
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // New method to spawn an animal
    void SpawnRandomAnimal()
    {
        // Random spawn of animals, its range, and its x position
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
