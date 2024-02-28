using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTimer : MonoBehaviour
{
    // public TMPro.TextMeshProUGUI timerText;
    public float timer = 0;
    public bool gamePaused = true;


    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);

    }

    // Update is called once per frame
    void Update()
    {
        if (gamePaused == false) {
            timer += Time.deltaTime; 
            Debug.Log(timer);
        }

    }

    public void PauseTime()
    {
        gamePaused = !gamePaused;
    }
}
