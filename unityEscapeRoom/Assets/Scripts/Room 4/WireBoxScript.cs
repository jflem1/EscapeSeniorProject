using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WireBoxScript : MonoBehaviour
{
    public Transform target;
    public float speed;
    private bool moving = false;
    private bool moving2 = false;
    public bool inFront = false;
    public float rotX;
    public float rotY;
    public float rotZ;
    private Vector3 originalPos;
    private bool canInteract = true;
    public bool allConnected = false;
    private Quaternion originalRot;

    private Vector3 newRot;
    public Vector3 WireBoxVector;
    private GameObject[] Wires = new GameObject[20];
    private int counter = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 10; i++){
            Wires[i] = GameObject.Find("Wire" + (i + 1) + "Start");
        }
        for(int i = 0; i < 10; i++){
            Wires[10 + i] = GameObject.Find("Wire" + (i + 1) + "End");
        }

        Debug.Log("Started!");
        originalPos = transform.position;
        originalRot = transform.rotation;
    //    originalRot = new Vector3(transform.rotation.x, transform.rotation.y, transform.rotation.z);
        
        GameObject.Find("WireBox_Back_Button").GetComponent<Renderer>().enabled = false;
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
    // Update is called once per frame
    void Update()
    {
        if(inFront){
            GameObject.Find("WireBox").GetComponent<BoxCollider>().enabled = false;
            for(int i = 0; i < 20; i++){
                Wires[i].GetComponent<LineRenderer>().enabled = true;
            }
        }
        else{
            GameObject.Find("WireBox").GetComponent<BoxCollider>().enabled = true;
            for(int i = 0; i < 20; i++){
                Wires[i].GetComponent<LineRenderer>().enabled = false;
            }
        }
        
        for(int i = 0; i < 20; i++){
            if(Wires[i] != null && Wires[i].GetComponent<CapsuleCollider>().enabled == false){
                Debug.Log("Connected " + i);
                counter++;
            }
        }
        if(counter >= 20){
            Debug.Log("All Connected");
            allConnected = true;
        }
        else{
            counter = 0;
        }

        MoveToFront();
        if (GameObject.Find("WireBox_Back_Button").GetComponent<BackArrowScript>().backButtonClicked) {
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

        /*
        if(moving == true){
            transform.position = Vector3.MoveTowards(transform.position, target.position + target.forward, speed);
            transform.right = target.position - target.position;
            newRot = new Vector3(target.rotation.x + rotX, target.rotation.y + rotY, target.rotation.z + rotZ);
        //    transform.rotation = originalRot;
            transform.eulerAngles = newRot;
            if(transform.position == target.position + target.forward){
                moving = false;
                inFront = true;
            }
            
        }    
        if(moving2 == true){
            transform.position = Vector3.MoveTowards(transform.position, originalPos, speed);
            transform.rotation = originalRot;
            if(transform.position == originalPos){
                moving2 = false;
                inFront = false;
            }
            
        } */
    }

    void MoveToFront() {
        if(moving == true){
            transform.position = Vector3.MoveTowards(transform.position, target.position + target.forward + WireBoxVector, speed);
            transform.right = target.position - target.position;
            newRot = new Vector3(target.rotation.x + rotX, target.rotation.y + rotY, target.rotation.z + rotZ);
            transform.eulerAngles = newRot;
            if(transform.position == target.position + target.forward + WireBoxVector){
                moving = false;
                inFront = true;                
                
                GameObject.Find("WireBox_Back_Button").GetComponent<Renderer>().enabled = true;
            }
            
        }   
    }

    void  MoveToOriginalPosition() {
        if(moving2 == true){
            Debug.Log("REACHED");
            transform.position = Vector3.MoveTowards(transform.position, originalPos, speed);
        //    transform.eulerAngles = originalRot;
            transform.rotation = originalRot;
            if(transform.position == originalPos){
                
                moving2 = false;
                inFront = false;
                GameObject.Find("WireBox_Back_Button").GetComponent<BackArrowScript>().backButtonClicked = false;
                GameObject.Find("WireBox_Back_Button").GetComponent<Renderer>().enabled = false;
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
