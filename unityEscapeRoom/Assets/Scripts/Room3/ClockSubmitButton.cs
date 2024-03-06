using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockSubmitButton : MonoBehaviour
{
    public bool submitButtonClicked = false;

    // Start is called before the first frame update
    void Start()
    {
        submitButtonClicked = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Debug.Log("Submit button clicked");
        // clipboard.OnBackButtonClick();
        submitButtonClicked = true;
        
    }
}
