using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public float spawnRadius = 10f;

    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemy();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemy()
    {
        if(enemyPrefabs.Length == 0)
        {
            Debug.Log("No Enemy prefabs assigned.");
            return;
        }

        //Randomly select enemy prefab from array
        GameObject randomEnemyPrefab = enemyPrefabs[Random.Range(0, enemyPrefabs.Length)];

        foreach(GameObject enemyPrefab in enemyPrefabs)
        {
            //Randomly generate spawn position within spawn radius
            Vector3 spawnPosition = transform.position + Random.insideUnitSphere * spawnRadius;
            spawnPosition.y = 0f;

            Instantiate(randomEnemyPrefab, spawnPosition, Quaternion.identity);
        }
        
    }
}
