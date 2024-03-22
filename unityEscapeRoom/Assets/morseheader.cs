using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class morseheader : MonoBehaviour
{
    public WireBoxScript wireboxScript;
    // Start is called before the first frame update
    void Start()
    {
        wireboxScript = FindObjectOfType<WireBoxScript>();
        GameObject.Find("Morse Code Header").GetComponent<Renderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(wireboxScript.allConnected){
            GameObject.Find("Morse Code Header").GetComponent<Renderer>().enabled = true;
        }
    }
}
