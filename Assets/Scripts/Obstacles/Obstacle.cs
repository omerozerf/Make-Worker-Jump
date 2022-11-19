using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private float speed;
    
    
    
    private GameManager gameManager;

    private void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    private void Update()
    {
        Movement();
        ObstacleAreaLimit();
    }

    private void Movement()
    {
        if (gameManager.isGameOver)
        {
            return;
        }
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }

    private void ObstacleAreaLimit()
    {
        if (transform.position.x < -5f)
        {
            Destroy(gameObject);
        }
    }
}
