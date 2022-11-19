using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ObstaclesSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] obstacles;
    [SerializeField] private float spawnRatePerSecond;
    public GameManager gameManager;

    private void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    private void Update()
    {
        if (gameManager.isGameOver)
        {
            StopAllCoroutines();
        }
    }

    private IEnumerator SpawnRoutine()
    {
        var waitTime = 1f / spawnRatePerSecond;
        while (true)
        {
            yield return new WaitForSeconds(waitTime);
            
            SpawnRandomObstacle();
        }
    }
    
    private void SpawnRandomObstacle()
    {
        var randomObstacleIndex = Random.Range(0, obstacles.Length);
        var randomObstaclePrefab = obstacles[randomObstacleIndex];
        var newPosition = transform.position + new Vector3(22f, 0f, 0f);
        Instantiate(randomObstaclePrefab, newPosition, randomObstaclePrefab.transform.rotation, transform);
    }
    
}
