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
    private Vector3 originalPos;

    private Vector3 originalRot;

    private Vector3 newRot;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Started!");
        originalPos = transform.position;
        originalRot = new Vector3(transform.rotation.x, transform.rotation.y, transform.rotation.z);

    }

    private void OnMouseDown() 
    {
        if(!inFront){
            Debug.Log("Clicked1!");
            if(moving == false){
                moving = true;
            }
        }

        
    }

    void Update(){
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
            transform.eulerAngles = originalRot;
            if(transform.position == originalPos){
                moving2 = false;
                inFront = false;
            }
            
        }
            
                
    }
}

