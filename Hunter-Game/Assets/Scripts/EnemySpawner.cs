using UnityEngine;
using System.Collections.Generic;
using System.Collections;
public class EnemySpawner : MonoBehaviour
{
    public GameObject EnemyPrefab;

    public int minEnemiesPerBatch = 3;

    public int maxEnemiesPerBatch = 6;

    public float minSpawnInterval = 3f;

    public float maxSpawnInterval = 5f;

    public float spawnRadius = 2f;

    // Update is called once per frame
    void Start()
    {
        StartCoroutine(SpawnEnemies());
    }


    private IEnumerator SpawnEnemies()
    {
        while (true)
        {
            float interval = Random.Range(minSpawnInterval, maxSpawnInterval);
            yield return new WaitForSeconds(interval);

            int enemiesBatchSize = Random.Range(minEnemiesPerBatch, maxEnemiesPerBatch);
            for(int i = 0; i < enemiesBatchSize; i++)
            {
                Vector2 spawnOffset = Random.insideUnitSphere * spawnRadius;
                Vector2 spawnPostion = (Vector2)gameObject.transform.position * spawnOffset;

                Instantiate(EnemyPrefab, spawnPostion, Quaternion.identity);
            }

        }
    }
}
