using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnX = 10.0f;
    private float spawnXRight = 15.0f;
    private float spawnZ = 20.0f;
    private float spawnZUp = 15.0f;
    private float spawnZLow = 2.0f;
    private float startDelay = 2.0f;
    private float spawnInt = 1.5f;
    
    // Start is called before the first frame update
   //Invooke repeating calls the spawn random animal function to spawn random animal given a specific time interval
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInt);
    }

    // Update is called once per frame
    void Update()
    {

    }

    //New function that spawn rangdom animals that are in the animal prefabs array
    void SpawnRandomAnimal()
    {
        if (GameManager.isGameActive)
        {
            //Randomly generate animals for each direction they are spawning from
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            int animalIndex2 = Random.Range(0, animalPrefabs.Length);
            int animalIndex3 = Random.Range(0, animalPrefabs.Length);

            //generating random animals from the top of the screen
            Vector3 spawnPos = new Vector3(Random.Range(-spawnX, spawnX), 0, spawnZ);
            Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(0, 180, 0));

            //generating random animals from the right of the screen
            Vector3 spawnPosRight = new Vector3(spawnXRight, 0, Random.Range(spawnZLow, spawnZUp));
            Instantiate(animalPrefabs[animalIndex2], spawnPosRight, Quaternion.Euler(0, -90, 0));

            //generating random animals from the left of the screen
            Vector3 spawnPosLeft = new Vector3(-spawnXRight, 0, Random.Range(spawnZLow, spawnZUp));
            Instantiate(animalPrefabs[animalIndex3], spawnPosLeft, Quaternion.Euler(0, 90, 0));

        }


    }
}
