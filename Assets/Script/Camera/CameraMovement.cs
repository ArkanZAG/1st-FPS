using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Vector2 playerTurn;
    [SerializeField] private Transform transformCamera;
    [SerializeField] private float cameraSensitivity;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        playerTurn.x += Input.GetAxis("Mouse X") * cameraSensitivity * Time.deltaTime;
        playerTurn.y += Input.GetAxis("Mouse Y") * cameraSensitivity * Time.deltaTime;
        transformCamera.localRotation = Quaternion.Euler(-playerTurn.y, 0, 0);
        transform.localRotation = Quaternion.Euler(0, playerTurn.x, 0);
    }
}
