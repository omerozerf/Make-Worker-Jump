using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody body;
    [SerializeField] private float speed;
    public PlayerAnimator animator;
    public GameManager gameManager;

    private void Start()
    {
        animator.Run();
    }

    private void Update()
    {
        Jump();
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && transform.position.y < 0.15f && !gameManager.isGameOver)
        { 
            body.AddForce(0f, speed, 0f, ForceMode.Impulse);
            animator.Jump();
        } 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Obstacle obstacle))
        {
            gameManager.isGameOver = true;
            animator.Die();
        }
    }
}
