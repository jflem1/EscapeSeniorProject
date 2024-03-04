using UnityEngine;

public class MouseLookAround : MonoBehaviour
{
    float rotationX = 0f;
    float rotationY = 0f;

    public float sensitivity = 10.0f;
    public Vector3 initialRotation = new Vector3(0f, 180f, 0f); // Initial starting rotation

    // Reference to the clipboard script
    public ClipBoard_Script clipboardScript;
    public BookScript bookScript;
    public LaptopScript laptopScript;
    public KeyPadZoomScript keypadScript;
    public PaintingScript paintingScript;
    public PaletteScript paletteScript;
    public BowlscoreScript bowlscoreScript;
    public PrinterScript printerScript;
    public ClockScript clockScript;
    public NotebookScript notebookScript;

    void Start()
    {
        // Set the initial rotation
        rotationX = initialRotation.x;
        rotationY = initialRotation.y;
        transform.localEulerAngles = initialRotation;

        clipboardScript = FindObjectOfType<ClipBoard_Script>();
        bookScript = FindObjectOfType<BookScript>();
        laptopScript = FindObjectOfType<LaptopScript>();
        keypadScript = FindObjectOfType<KeyPadZoomScript>();
        paintingScript = FindObjectOfType<PaintingScript>();
        paletteScript = FindObjectOfType<PaletteScript>();
        bowlscoreScript = FindObjectOfType<BowlscoreScript>();
        printerScript = FindObjectOfType<PrinterScript>();
        clockScript = FindObjectOfType<ClockScript>();
        notebookScript = FindObjectOfType<NotebookScript>();
    }

    void Update()
    {
        // Check if the clipboard is not in front of the camera
        if (clipboardScript != null && clipboardScript.inFront){
            rotationX = initialRotation.x;
            rotationY = initialRotation.y;
            transform.localEulerAngles = initialRotation;
        }
        else if(bookScript != null && bookScript.inFront){
            rotationX = initialRotation.x;
            rotationY = initialRotation.y;
            transform.localEulerAngles = initialRotation;
        }
        else if(laptopScript != null && laptopScript.inFront){
            rotationX = initialRotation.x;
            rotationY = initialRotation.y;
            transform.localEulerAngles = initialRotation;
        }
        else if(keypadScript != null && keypadScript.inFront){
            rotationX = initialRotation.x;
            rotationY = initialRotation.y;
            transform.localEulerAngles = initialRotation;
        }
        else if(paintingScript != null && paintingScript.inFront){
            rotationX = initialRotation.x;
            rotationY = initialRotation.y;
            transform.localEulerAngles = initialRotation;
        }
        else if (paletteScript != null && paletteScript.inFront){
            rotationX = initialRotation.x;
            rotationY = initialRotation.y;
            transform.localEulerAngles = initialRotation;
        }
        else if (bowlscoreScript != null && bowlscoreScript.inFront){
            rotationX = initialRotation.x;
            rotationY = initialRotation.y;
            transform.localEulerAngles = initialRotation;
        }
        else if (printerScript != null && printerScript.inFront){
            rotationX = initialRotation.x;
            rotationY = initialRotation.y;
            transform.localEulerAngles = initialRotation;
        }
        else if (clockScript != null && clockScript.inFront)
        {
            rotationX = initialRotation.x;
            rotationY = initialRotation.y;
            transform.localEulerAngles = initialRotation;
        }
        else if (notebookScript != null && notebookScript.inFront)
        {
            rotationX = initialRotation.x;
            rotationY = initialRotation.y;
            transform.localEulerAngles = initialRotation;
        }
        else
        {
            rotationY += Input.GetAxis("Mouse X") * sensitivity;
            rotationX += Input.GetAxis("Mouse Y") * -1 * sensitivity;

            // Clamp vertical rotation to prevent flipping
            rotationX = Mathf.Clamp(rotationX, -90f, 90f);

            transform.localEulerAngles = new Vector3(rotationX, rotationY, 0);


        }
    }
}