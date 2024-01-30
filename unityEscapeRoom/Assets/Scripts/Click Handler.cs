using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickHandler : MonoBehaviour
{

    private Renderer _renderer;
    // Start is called before the first frame update
    void Start()
    {
        _renderer = GetComponent<Renderer>();
    }

    private void OnMouseDown() 
    {
        Debug.Log("Clicked on a door!");
        SceneManager.LoadScene("Room 2 - Reitz Union");
    }
}
