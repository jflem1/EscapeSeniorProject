using UnityEngine;
using System.Collections;

public class ClockArrowScript : MonoBehaviour {

	//-- set start time 00:00
    public int minutes = 0;
    public int hour = 12;
	public int seconds = 0;
	public bool realTime=true;
	
	public GameObject pointerSeconds;
    public GameObject pointerMinutes;
    public GameObject pointerHours;

    public GameObject popUpGameObject;
    public GameObject clueSolvedObject;

    public ClockScript clockScript;

    public GameObject upHourObject;
    public GameObject downHourObject;
    public GameObject upMinObject;
    public GameObject downMinObject;

    public GameObject hourText;
    public GameObject minText;

    
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
        hour = 12;
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
        Debug.Log("Submit clicked again");
        CheckTime();
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
        if (hour == 2 && minutes == 5)
        {
            reachedGoalTime = true;
            Debug.Log("Reached 2:15!");
            popUpGameObject.SetActive(true);
            GameObject.Find("Submit_Button").GetComponent<Renderer>().enabled = false;
            upHourObject.GetComponent<Renderer>().enabled = false;
            downHourObject.GetComponent<Renderer>().enabled = false;
            upMinObject.GetComponent<Renderer>().enabled = false;
            downMinObject.GetComponent<Renderer>().enabled = false;
            hourText.GetComponent<Renderer>().enabled = false;
            minText.GetComponent<Renderer>().enabled = false;
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
