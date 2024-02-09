using UnityEngine;

public class MouseLookAround : MonoBehaviour
{
    float rotationX = 0f;
    float rotationY = 0f;

    public float sensitivity = 10.0f;
    public Vector3 initialRotation = new Vector3(0f, 180f, 0f); // Initial starting rotation

    // Reference to the clipboard script
    public ClipBoard_Script clipboardScript;

    void Start()
    {
        // Set the initial rotation
        rotationX = initialRotation.x;
        rotationY = initialRotation.y;
        transform.localEulerAngles = initialRotation;

        clipboardScript = FindObjectOfType<ClipBoard_Script>();
    }

    void Update()
    {
        // Check if the clipboard is not in front of the camera
        if (clipboardScript != null && !clipboardScript.inFront)
        {
            rotationY += Input.GetAxis("Mouse X") * sensitivity;
            rotationX += Input.GetAxis("Mouse Y") * -1 * sensitivity;

            // Clamp vertical rotation to prevent flipping
            rotationX = Mathf.Clamp(rotationX, -90f, 90f);

            transform.localEulerAngles = new Vector3(rotationX, rotationY, 0);
        }
        else
        {
            rotationX = initialRotation.x;
            rotationY = initialRotation.y;
            transform.localEulerAngles = initialRotation;
        }
    }
}