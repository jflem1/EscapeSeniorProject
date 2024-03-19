using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClockAdjustment : MonoBehaviour
{
        // Start is called before the first frame update
    public GameObject clockArrow;



    public int hour;
    public int minutes;

    public string timeType;
    public string adjustType;

    void Start()
    {
        hour = clockArrow.GetComponent<ClockArrowScript>().hour;
        minutes = clockArrow.GetComponent<ClockArrowScript>().minutes;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // GameObject.Find("Keypad_Back_Button").GetComponent<BackArrowScript>().backButtonClicked = false;
    // GameObject.Find("Keypad_Back_Button").GetComponent<Renderer>().enabled = false;

    void OnMouseDown()
    {
        if (timeType == "Hour") // Check if the clicked object is ArrowUp
        {
            if (adjustType == "Up") 
            {
                clockArrow.GetComponent<ClockArrowScript>().hour++; // Increment hour by 1
                if (clockArrow.GetComponent<ClockArrowScript>().hour > 12) // Reset hour to 1 after 12
                    clockArrow.GetComponent<ClockArrowScript>().hour = 1;
            }
            else if (adjustType == "Down")
            {
                clockArrow.GetComponent<ClockArrowScript>().hour--; // Decrement hour by 1
                if (clockArrow.GetComponent<ClockArrowScript>().hour < 1) // Reset hour to 12 after 1
                    clockArrow.GetComponent<ClockArrowScript>().hour = 12;
            }
            
        }
        else if (timeType == "Minutes") // Check if the clicked object is ArrowDown
        {
            if (adjustType == "Up") 
            {
                clockArrow.GetComponent<ClockArrowScript>().minutes += 5; // Increment minutes by 5
                if (clockArrow.GetComponent<ClockArrowScript>().minutes >= 60)
                {
                    clockArrow.GetComponent<ClockArrowScript>().minutes = 0;
                    clockArrow.GetComponent<ClockArrowScript>().hour++;
                    if (clockArrow.GetComponent<ClockArrowScript>().hour == 12) // Reset hour to 1 after 11
                        clockArrow.GetComponent<ClockArrowScript>().hour = 1;
                }
            }
            else if (adjustType == "Down")
            {
                clockArrow.GetComponent<ClockArrowScript>().minutes -= 5; // Decrement minutes by 5
                if (clockArrow.GetComponent<ClockArrowScript>().minutes < 0)
                {
                    clockArrow.GetComponent<ClockArrowScript>().minutes += 60;
                    clockArrow.GetComponent<ClockArrowScript>().hour--;
                    if (clockArrow.GetComponent<ClockArrowScript>().hour == 0) // Reset hour to 11 after 12
                        clockArrow.GetComponent<ClockArrowScript>().hour = 11;
                }
            }
        }

        Debug.Log("Current Hour: " + clockArrow.GetComponent<ClockArrowScript>().hour);
        Debug.Log("Current Minutes: " + clockArrow.GetComponent<ClockArrowScript>().minutes);

    }
}
