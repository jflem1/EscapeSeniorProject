using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTimer : MonoBehaviour
{
    // public TMPro.TextMeshProUGUI timerText;
    public float timer = 0;
    public bool gamePaused = false;

    public GameObject pauseMenuObject;
    public GameObject pauseButtonObject;

    private MouseLookAround mouseLookScript;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        pauseMenuObject.SetActive(false);

        mouseLookScript = Camera.main.GetComponent<MouseLookAround>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gamePaused == false) {
            timer += Time.deltaTime; 
            Debug.Log(timer);

        }
        // else if(gamePaused == true){
        //     pauseMenuObject.SetActive(true);
        //     // GameObject.Find("Pause_Menu").GetComponent<Renderer>().enabled = true;
        //     // GameObject.Find("Pause_Button").GetComponent<Renderer>().enabled = false;
        // }

    }



    public void PauseTime()
    {
        gamePaused = !gamePaused;
        pauseMenuObject.SetActive(gamePaused);
        pauseButtonObject.SetActive(!gamePaused);

        if(mouseLookScript != null)
        {
            mouseLookScript.ToggleCameraPause(gamePaused);
        }
    }

    void OnMouseDown()
    {
        Debug.Log("Clicked Pause");
        gamePaused = !gamePaused;
    }
}
