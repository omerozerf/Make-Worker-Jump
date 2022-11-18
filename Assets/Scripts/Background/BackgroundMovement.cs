using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovement : MonoBehaviour
{

    [SerializeField] private float speed;

    private void Update()
    {
        XMovement();
    }

    private void XMovement()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}
