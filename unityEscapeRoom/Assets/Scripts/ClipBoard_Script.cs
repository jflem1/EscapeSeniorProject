using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClipBoard_Script : MonoBehaviour
{
    public Transform target;
    public float speed;
    public bool inFront = false;
    private Transform temp;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Started!");
        temp = transform;
    }

    private void OnMouseDown() 
    {
        Debug.Log(temp.position);
        if(inFront){
            transform.position = temp.position;
            Debug.Log("Clicked2!"); 
        }
        else{
            Debug.Log("Clicked1!");
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed);
        }
        inFront = !inFront;
    }

    void Update(){
        
    }
}

