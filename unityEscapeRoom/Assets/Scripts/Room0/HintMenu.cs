using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintMenu : MonoBehaviour
{
    public bool hintClicked = false;

    public GameObject hintMenuObject;
    public GameObject hintButtonObject;
    public GameObject pauseButtonObject;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        hintMenuObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // if (hintClicked == true) {

        // }
    }

    public void hintClickedFunc()
    {
        hintClicked = !hintClicked;
        hintMenuObject.SetActive(hintClicked);
        hintButtonObject.SetActive(!hintClicked);
        pauseButtonObject.SetActive(!hintClicked);

    }


}
