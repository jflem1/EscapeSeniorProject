using UnityEngine;
using System.Collections;

public class ClockArrowScript : MonoBehaviour {

	//-- set start time 00:00
    public int minutes = 0;
    public int hour = 0;
	public int seconds = 0;
	public bool realTime=true;
	
	public GameObject pointerSeconds;
    public GameObject pointerMinutes;
    public GameObject pointerHours;

    public GameObject popUpGameObject;
    public GameObject clueSolvedObject;

    public ClockScript clockScript;
    
    //-- time speed factor
    public float clockSpeed = 1.0f;     // 1.0f = realtime, < 1.0f = slower, > 1.0f = faster

    //-- internal vars
    float msecs=0;

    public bool reachedGoalTime = false;

void Start() 
{
    
    pointerSeconds.GetComponent<Renderer>().enabled = false;

    popUpGameObject.SetActive(false);
    clueSolvedObject.SetActive(false);
	//-- set real time
	if (realTime)
	{
		hour=System.DateTime.Now.Hour;
		minutes=System.DateTime.Now.Minute;
		seconds=System.DateTime.Now.Second;
	}
}

void Update() 
{
    if (!clockScript.inFront){
        minutes = 0;
        hour = 0;
    }
    //-- calculate time
    msecs += Time.deltaTime * clockSpeed;
    if(msecs >= 1.0f)
    {
        msecs -= 1.0f;
        seconds++;
        if(seconds >= 60)
        {
            seconds = 0;
            minutes++;
            if(minutes > 60)
            {
                minutes = 0;
                hour++;
                if(hour >= 24)
                    hour = 0;
            }
        }
    }


    //-- calculate pointer angles
    float rotationSeconds = (360.0f / 60.0f)  * seconds;
    float rotationMinutes = (360.0f / 60.0f)  * minutes;
    float rotationHours   = ((360.0f / 12.0f) * hour) + ((360.0f / (60.0f * 12.0f)) * minutes);

    //-- draw pointers
    pointerSeconds.transform.localEulerAngles = new Vector3(0.0f, 0.0f, rotationSeconds);
    pointerMinutes.transform.localEulerAngles = new Vector3(0.0f, 0.0f, rotationMinutes);
    pointerHours.transform.localEulerAngles   = new Vector3(0.0f, 0.0f, rotationHours);


    if (GameObject.Find("Submit_Button").GetComponent<ClockSubmitButton>().submitButtonClicked)
    {
        // Debug.Log("Back button clicked again");
        CheckTime();
        

    }
    else {
        // Allow players to adjust time using mouse left button click
        if (Input.GetMouseButtonDown(0)) // Left mouse button click
        {
            minutes += 5; // Increment minutes by 5
            if (minutes >= 60)
            {
                minutes = 0;
                hour++;
                if (hour >= 24)
                    hour = 0;
            }

            // // Check if it's 5:45
            // if (hour == 1 && minutes == 15)
            // {
            //     reachedGoalTime = true;
            //     Debug.Log("Reached 5:45!");
            //     popUpGameObject.SetActive(true);
            // }
        }
        // Allow players to adjust time using mouse left button click
        else if (Input.GetMouseButtonDown(1)) // Left mouse button click
        {
            minutes -= 5; // Decrement minutes by decrementValue
            if (minutes < 0)
            {
                minutes += 60;
                hour--;
                if (hour < 0)
                    hour = 23;
            }

            // // Check if it's 5:45
            // if (hour == 1 && minutes == 15)
            // {
            //     reachedGoalTime = true;
            //     Debug.Log("Reached 5:45!");
            //     popUpGameObject.SetActive(true);
            // }
        }
    }
    



    // // Allow players to adjust time using keyboard inputs
    //     if (Input.GetKeyDown(KeyCode.UpArrow)) // Increase time by one hour
    //     {
    //         hour++;
    //         if (hour >= 24)
    //             hour = 0;
    //     }
    //     else if (Input.GetKeyDown(KeyCode.DownArrow)) // Decrease time by one hour
    //     {
    //         hour--;
    //         if (hour < 0)
    //             hour = 23;
    //     }
    //     else if (Input.GetKeyDown(KeyCode.RightArrow)) // Increase time by one minute
    //     {
    //         minutes++;
    //         if (minutes >= 60)
    //         {
    //             minutes = 0;
    //             hour++;
    //             if (hour >= 24)
    //                 hour = 0;
    //         }
    //     }
    //     else if (Input.GetKeyDown(KeyCode.LeftArrow)) // Decrease time by one minute
    //     {
    //         minutes--;
    //         if (minutes < 0)
    //         {
    //             minutes = 59;
    //             hour--;
    //             if (hour < 0)
    //                 hour = 23;
    //         }
    //     }

    }


        public void CheckTime() // Function called by the button
        {
            // Check if it's 1:15
            if (hour == 0 && minutes == 5)
            {
                reachedGoalTime = true;
                Debug.Log("Reached 1:15!");
                popUpGameObject.SetActive(true);
                GameObject.Find("Submit_Button").GetComponent<Renderer>().enabled = false;
            }
            else
            {
                reachedGoalTime = false;
                Debug.Log("Not yet reached 1:15!");
                popUpGameObject.SetActive(false);
            }

            GameObject.Find("Submit_Button").GetComponent<ClockSubmitButton>().submitButtonClicked = false;
        }
}
