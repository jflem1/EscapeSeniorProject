using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Runtime.InteropServices;
using UnityEngine.SceneManagement;

public class Feedback_button_temporary : MonoBehaviour
{
    // Start is called before the first frame update
   // public GameObject button;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void openFeedback(){
        Debug.Log("clicked");
        Application.OpenURL("https://forms.gle/EpiGBa6kpgc7NoqM8");
    }
}
