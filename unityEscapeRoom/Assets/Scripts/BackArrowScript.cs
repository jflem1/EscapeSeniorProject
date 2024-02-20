using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class BackArrowScript : MonoBehaviour
{
    // private Renderer _renderer;
   // [SerializeField] ClipBoard_Script clipboard;
//    public ClipBoard_Script clipboard;

   public bool backButtonClicked = false;
    // Start is called before the first frame update
    void Start()
    {
        backButtonClicked = false;
    }

    // private void OnMouseDown(){
    //     _renderer.enabled = false;
    //     clipboard.inFront = false;
    // }


    private void OnMouseDown()
    {
        Debug.Log("Back button clicked");
        // clipboard.OnBackButtonClick();
        backButtonClicked = true;
        
    }

    
}
