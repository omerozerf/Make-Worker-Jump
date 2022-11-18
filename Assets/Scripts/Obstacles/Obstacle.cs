using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private float speed;

    private void Update()
    {
        Movement();
        ObstacleAreaLimit();
    }

    private void Movement()
    {
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
