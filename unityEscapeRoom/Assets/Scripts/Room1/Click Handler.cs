using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickHandler : MonoBehaviour
{
    public bool doorLocked;
    private Renderer _renderer;
    // Start is called before the first frame update
    void Start()
    {
        _renderer = GetComponent<Renderer>();
    }


    private void OnMouseDown() 
    {
        if (doorLocked == false) {
            Debug.Log(doorLocked);
            Debug.Log("Clicked on an unlocked door!");
            SceneManager.LoadScene("Room 2 - Reitz Union");
        }
        else {
            Debug.Log(doorLocked);
            Debug.Log("Clicked on a locked door!");
        }
    }
    public void unlockDoor() {
        this.doorLocked = false;
        Debug.Log(doorLocked);
        Debug.Log("Unlock function entered!");
    }
}
