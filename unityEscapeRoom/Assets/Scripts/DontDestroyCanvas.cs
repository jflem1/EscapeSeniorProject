using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyCanvas : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject canvas = GameObject.Find("Pause Menu Canvas");
        DontDestroyOnLoad(canvas);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
