using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClipBoard_Script : MonoBehaviour
{
    public Transform target;
    public float speed;
    public bool moving = false;
    private bool moving2 = false;
    public bool inFront = false;
    public float rotX;
    public float rotY;
    public float rotZ;
    public Vector3 originalPos;
    private bool canInteract = true;

    public Vector3 originalRot;

    public Vector3 newRot;
    public Vector3 clipboardVector;
    // Start is called before the first frame update
    
    void Start()
    {
        Debug.Log("Started!");
        originalPos = transform.position;
        originalRot = new Vector3(transform.rotation.x, transform.rotation.y, transform.rotation.z);
        // backArrowScript = GameObject.Find("Back_Button").GetComponent<BackArrowScript>();
        GameObject.Find("Clipboard_Back_Button").GetComponent<Renderer>().enabled = false;
    }

    private void OnMouseDown() 
    {
        if(!inFront && canInteract)
        {
            Debug.Log("Clicked1!");
            if(moving == false){
                moving = true;
                inFront = true;
            }
        }
    }

    void Update(){
        MoveToFront();

        // Make sure the object in find is the same name as the button
        if (GameObject.Find("Clipboard_Back_Button").GetComponent<BackArrowScript>().backButtonClicked) {
            Debug.Log("Back button clicked again");
            if(inFront)
            {
                Debug.Log("Move back");
                if(moving2 == false){
                    moving2 = true;
                    inFront = false;
                }
            }
            MoveToOriginalPosition();  

        }

  
    }

    void MoveToFront() {
        if(moving == true){
            transform.position = Vector3.MoveTowards(transform.position, target.position + target.forward + clipboardVector, speed);
            transform.right = target.position - target.position;
            newRot = new Vector3(target.rotation.x + rotX, target.rotation.y + rotY, target.rotation.z + rotZ);
            transform.eulerAngles = newRot;
            if(transform.position == target.position + target.forward + clipboardVector){
                moving = false;
                inFront = true;                
                
                GameObject.Find("Clipboard_Back_Button").GetComponent<Renderer>().enabled = true;
            }
            
        }   
    }
    void  MoveToOriginalPosition() {
        if(moving2 == true){
            Debug.Log("REACHED");
            transform.position = Vector3.MoveTowards(transform.position, originalPos + clipboardVector, speed);
            if(transform.position == originalPos + clipboardVector){
                
                moving2 = false;
                inFront = false;
                GameObject.Find("Clipboard_Back_Button").GetComponent<BackArrowScript>().backButtonClicked = false;
                GameObject.Find("Clipboard_Back_Button").GetComponent<Renderer>().enabled = false;
                //transform.eulerAngles = originalRot;    
            }

            
        }
    }

    public void DisableInteraction()
    {
        canInteract = false;
    }

    public void EnableInteraction()
    {
        canInteract = true;
    }
}
