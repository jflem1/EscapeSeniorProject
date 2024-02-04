using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float sensitivity = 2.0f;
    public float maxYAngle = 80.0f;
    private Vector2 currentRotation;

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        currentRotation.x -= mouseY * sensitivity;
        currentRotation.y += mouseX * sensitivity;

        currentRotation.x = Mathf.Clamp(currentRotation.x, -maxYAngle, maxYAngle);

        transform.localRotation = Quaternion.Euler(currentRotation.x, currentRotation.y, 0);
    }
}
