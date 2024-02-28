using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// /Users/christinelin/Documents/Classes/Senior Project/EscapeSeniorProject/unityEscapeRoom/Temp/Compiled-Standard.shader
public class PaletteRevealNumber : MonoBehaviour
{
    public GameObject numberObject;
    public int numberToShow = 5;


    public bool revealed = false;
    private Vector3 initialPosition;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Clicked Number");
        // initialPosition = transform.position;
        // GameObject.Find("yellow-num").GetComponent<Renderer>().enabled = false;
        numberObject.GetComponent<Renderer>().enabled = false;
        // this.raycastTarget = false;
    }

    void OnMouseDown()
    {
        Debug.Log("Clicked Number");
        if (revealed == false)
        {
            numberObject.GetComponent<Renderer>().enabled = true;
            // numberObject.SetActive(true); // Activate the object that reveals the number
            // You can set the number to display in the numberObject here
            revealed = true;
        }
    }

    void OnMouseExit()
    {
        if (revealed)
        {
            numberObject.GetComponent<Renderer>().enabled = false; // Deactivate the object that reveals the number
            revealed = false;
            // transform.position = initialPosition; // Put the object back to its initial position
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}





