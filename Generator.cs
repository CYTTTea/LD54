using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{

    public GameObject[] objectsToClone; 
    public int numberOfClones = 5; 

    private void Start()
    {
        CloneRandomObject();
    }

    private void CloneRandomObject()
    {
        for (int i = 0; i < numberOfClones; i++)
        {

            int randomIndex = Random.Range(0, objectsToClone.Length);
            GameObject objectToClone = objectsToClone[randomIndex];


            GameObject clone = Instantiate(objectToClone);

            clone.SetActive(true);

            Vector3 spawnPosition = GetRandomSpawnPosition();
            clone.transform.position = spawnPosition;
        }
    }

    private Vector3 GetRandomSpawnPosition()
    {

        float randomX = Random.Range(-10f, 10f);
        float randomY = Random.Range(-10f, 10f);
        Vector3 randomPosition = new Vector3(randomX, randomY, 0f);
        return randomPosition;
    }
}

