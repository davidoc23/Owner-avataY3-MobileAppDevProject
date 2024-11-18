using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnInterval = 3f;
    public float enemyLifespan = 5f; 
    public float spawnAreaWidth = 10f;

    private float nextSpawnTime;

    void Update()
    {
        if (Time.time > nextSpawnTime)
        {
            SpawnEnemy();
            nextSpawnTime = Time.time + spawnInterval;
        }
    }

    void SpawnEnemy()
    {
        float randomX = Random.Range(-spawnAreaWidth / 2, spawnAreaWidth / 2);
        Vector3 spawnPosition = new Vector3(randomX, transform.position.y, 0f);
        GameObject enemy = Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
        
        // Schedule destruction of the enemy after lifespan
        Destroy(enemy, enemyLifespan);
    }
}
