using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aggresiveanimales : MonoBehaviour
{
    float animalPrefabs;
    float lowSpawnRangeZ;
    float leftRightSwitcher;
    float timerHorizontal;
    float timerVertical;
    float spawnRangeX;
    float waitTime;
    float spawnPositionX;
    float spawnPositionZ;
    float highSpawnRangeZ;
    void Update()
    {
        timerVertical += Time.deltaTime;
        timerHorizontal += Time.deltaTime;
        SpawnRandomAnimalVertical();
        SpawnRandomAnimalHorizontal();

    }

    void SpawnRandomAnimalVertical()
    {
        //Create an animal index (has to be int, not float) with a new random range, from 0 to the length of animal prefabs (in this case, 3)
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        //Create a spawn position with a new vector3, which includes a random range that is defined.
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPositionZ);


        if (timerVertical >= waitTime)
        {
            //Start spawning animals based on the animal prefabs, at the spawn position, and at their current transform rotation.
            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation = Quaternion.Euler(0, 180, 0));
            timerVertical = 0.0f;
        }

    }

    void SpawnRandomAnimalHorizontal()
    {
        //Create an animal index (has to be int, not float) with a new random range, from 0 to the length of animal prefabs (in this case, 3)
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        //Create a spawn position with a new vector3, which includes a random range that is defined.
        Vector3 spawnPosLeft = new Vector3(spawnPositionX, 0, Random.Range(lowSpawnRangeZ, highSpawnRangeZ));
        Vector3 spawnPosRight = new Vector3(-spawnPositionX, 0, Random.Range(lowSpawnRangeZ, highSpawnRangeZ));

         (timerHorizontal >= waitTime && leftRightSwitcher)
        {
            //Start spawning animals based on the animal prefabs, at the spawn position, and at their current transform rotation.
            Instantiate(animalPrefabs[animalIndex], spawnPosLeft, animalPrefabs[animalIndex].transform.rotation = Quaternion.Euler(0, 90, 0));
            leftRightSwitcher = !leftRightSwitcher;

            timerHorizontal = 0.0f;
        }

        if (timerHorizontal < waitTime && !leftRightSwitcher) 
        {
            //Start spawning animals based on the animal prefabs, at the spawn position, and at their current transform rotation.
            Instantiate(animalPrefabs[animalIndex], spawnPosRight, animalPrefabs [animalIndex].transform.rotation = Quaternion.Euler(0, 270, 0));
            leftRightSwitcher = leftRightSwitcher;

            timerHorizontal = 0.0f;
        }

    }
}
