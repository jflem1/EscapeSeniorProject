using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchingGame : MonoBehaviour
{
    public TMPro.TextMeshProUGUI[] wordTexts; // Array to hold the Text components of the words
    public GameObject[] wordObjects; // Array to hold the GameObjects of the words
    public float flipTime = 2f; // Time to display the word before flipping back
    // public GameObject clockArrowObject;
    public GameObject popUpGameObject;


    private bool canClick = true; // Boolean to control clicking behavior
    private TMPro.TextMeshProUGUI firstClicked; // Store the first clicked word
    private TMPro.TextMeshProUGUI secondClicked; // Store the second clicked word
    private bool isMatching = false; // Flag to indicate if words are matching

    public bool clockClueSolved;



    

    // Start is called before the first frame update
    void Start()
    {
      
        
        // Initialize the arrays if they are not set
        if (wordTexts == null || wordTexts.Length == 0 || wordObjects == null || wordObjects.Length == 0)
        {
            Debug.LogError("Word Texts or Objects are not assigned!");
            return;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
