using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMovement : MonoBehaviour
{
    
    [SerializeField] private Rigidbody playerRigidbody;
    [SerializeField] private float playerMovementSpeed;
    [SerializeField] private Vector3 movementDirection;


    private void Movement()
    { 
        float horizontalInput = Input.GetAxis("Vertical"); 
        float verticalInput = Input.GetAxis("Horizontal");
        
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        Vector3 right = transform.TransformDirection(Vector3.right);

        movementDirection = (forward * horizontalInput) + (right * verticalInput);

        playerRigidbody.linearVelocity = movementDirection * (playerMovementSpeed * Time.deltaTime);
    }

    private void Update()
    {
        Movement();
    }
}
