using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class BackArrowScript : MonoBehaviour
{
    private Renderer _renderer;
   // [SerializeField] ClipBoard_Script clipboard;
   public ClipBoard_Script clipboard;
    // Start is called before the first frame update
    void Start()
    {
        clipboard = FindObjectOfType<ClipBoard_Script>();
        _renderer.enabled = false;
    }

    private void OnMouseDown(){
        _renderer.enabled = false;
        clipboard.inFront = false;
    }

    void Update(){
        if(clipboard.inFront){
            _renderer.enabled = true;
        }
    }
}
