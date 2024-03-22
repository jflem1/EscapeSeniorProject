using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HintText : MonoBehaviour
{
    public Dictionary<string, string[]> sceneHintMap = new Dictionary<string, string[]>(); 
    public TMPro.TextMeshProUGUI[] hintTextObjects;
    // Start is called before the first frame update
    void Start()
    {
        sceneHintMap.Add("Room 1 - Marston", new string[] { "Hint1 for Scene1", "Hint2 for Scene1", "Hint3 for Scene1" });
        sceneHintMap.Add("Room 2 - Reitz Union", new string[] { "Hint1 for Scene2", "Hint2 for Scene2", "Hint3 for Scene2" });
        sceneHintMap.Add("Room 3 - Southwest Rec", new string[] { "Hint1 for Scene3", "Hint2 for Scene3", "Hint3 for Scene3" });
        sceneHintMap.Add("Room 4 - Malachowsky Hall", new string[] { "Hint1 for Scene4", "Hint2 for Scene4", "Hint3 for Scene4" });
        sceneHintMap.Add("Room 5 - Century Tower", new string[] { "Hint1 for Scene5", "Hint2 for Scene5", "Hint3 for Scene5" });
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SelectHint(int hintNum) 
    {
  
        // Get the current scene name
        string currentSceneName = SceneManager.GetActiveScene().name;
        // Check if the current scene name exists in the map
        if (sceneHintMap.ContainsKey(currentSceneName))
        {
            // Update the hint text with one of the texts from the array corresponding to the current scene
            // hintTextObject.gameObject.SetActive(true);
            string[] hints = sceneHintMap[currentSceneName];
            if (hints.Length > 0)
            {
                // int randomIndex = Random.Range(0, hints.Length); // Pick a random hint

                // hintTextObject.text = hints[randomIndex];

                // hintTextObject1.text = hints[0];
                // hintTextObject2.text = hints[1];
                // hintTextObject3.text = hints[2];
                hintTextObjects[hintNum-1].text = hints[hintNum-1];
            }
            else
            {
                Debug.LogWarning("No hint available for scene: " + currentSceneName);
            }
        }
        else
        {
            Debug.LogWarning("No hint available for scene: " + currentSceneName);
        }
    }
}
