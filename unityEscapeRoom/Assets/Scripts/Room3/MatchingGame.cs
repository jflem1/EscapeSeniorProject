using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MatchingGame : MonoBehaviour
{
    public TMPro.TextMeshProUGUI[] cardTexts; // Array to hold the Text components of the words
    public GameObject[] cardObjects; // Array to hold the GameObjects of the words
    // public float flipTime = 0.5f; // Time to display the word before flipping back
    // public GameObject clockArrowObject;
    public GameObject popUpGameObject;
    public GameObject clueSolvedObject;


    private bool canClick = true; // Boolean to control clicking behavior
    private TMPro.TextMeshProUGUI firstClicked; // Store the first clicked word
    private TMPro.TextMeshProUGUI secondClicked; // Store the second clicked word
    private bool isMatching = false; // Flag to indicate if words are matching

    public int countMatched = 0;
    public bool gameSolved = false;

    GameObject firstClickedObject;
    GameObject secondClickedObject;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(GameObject.Find("Arrow").GetComponent<ClockArrowScript>().reachedGoalTime);
        countMatched = 0;
        
        // Initialize the arrays if they are not set
        if (cardTexts == null || cardTexts.Length == 0 || cardObjects == null || cardObjects.Length == 0)
        {
            Debug.LogError("Word Texts or Objects are not assigned!");
            return;
        }

        // // Attach click handlers to each word object
        // for (int i = 0; i < cardObjects.Length; i++)
        // {
        //     Debug.Log(i);
        //     // int index = i; // Capture the index for the lambda
        //     cardObjects[i].GetComponent<Button>().onClick.AddListener(() => CardClicked(i));
        //     // cardTexts[i].SetActive(false); // Hide all words initially
        // }

        // Hide all card texts initially
        foreach (TMPro.TextMeshProUGUI cardText in cardTexts)
        {
            cardText.gameObject.SetActive(false);
        }


         // Shuffle the words
        // ShuffleWords();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CardClicked(int index)
    {
        Debug.Log(index);
        // If clicking is disabled or the card is already matched, do nothing
        if (!canClick || cardTexts[index].gameObject.activeSelf)
            return;
        


        // If it's the first click
        if (firstClicked == null)
        {
            firstClickedObject = cardObjects[index];
            firstClicked = cardTexts[index];
            firstClicked.gameObject.SetActive(true); // Show the text of the first card
        }
        // If it's the second click
        else if (secondClicked == null)
        {
            secondClickedObject = cardObjects[index];
            secondClicked = cardTexts[index];
            secondClicked.gameObject.SetActive(true); // Show the text of the second card
            // yield return new WaitForSeconds(5); 

            // Check if the cards match
            if (firstClicked.text == secondClicked.text)
            {
                // Play match sound
                // AudioSource.PlayClipAtPoint(matchSound, Camera.main.transform.position);
                // Clear the clicked cards
                firstClicked = null;
                secondClicked = null;
                countMatched += 1;
                

                StartCoroutine(CardsMatched());

            }
            else
            {
                // If cards don't match, flip them back after flipTime
                StartCoroutine(FlipCardsBack());
            }

            if(countMatched >= 6) {
                gameSolved = true;
                StartCoroutine(GameSolved());
            }
        }
    }

    public IEnumerator GameSolved()
    {
        canClick = false; // Disable clicking temporarily
        yield return new WaitForSeconds(1f); // Wait for flipTime duration

        popUpGameObject.SetActive(false);
        clueSolvedObject.SetActive(true);

        canClick = true; // Re-enable clicking
    }

    public IEnumerator CardsMatched()
    {
        canClick = false; // Disable clicking temporarily
        yield return new WaitForSeconds(0.5f); // Wait for flipTime duration

        firstClickedObject.SetActive(false);
        secondClickedObject.SetActive(false);

        canClick = true; // Re-enable clicking
    }


    public IEnumerator FlipCardsBack()
    {
        canClick = false; // Disable clicking temporarily
        yield return new WaitForSeconds(0.5f); // Wait for flipTime duration

        // Hide the text of both cards
        firstClicked.gameObject.SetActive(false);
        secondClicked.gameObject.SetActive(false);

        // Clear the clicked cards
        firstClicked = null;
        secondClicked = null;

        canClick = true; // Re-enable clicking
    }

    // void ShuffleWords()
    // {
    //     // Fisher-Yates shuffle algorithm to shuffle the words
    //     for (int i = 0; i < cardTexts.Length; i++)
    //     {
    //         int randomIndex = Random.Range(i, cardTexts.Length);
    //         // Swap words
    //         TMPro.TextMeshProUGUI tempText = cardTexts[randomIndex];
    //         cardTexts[randomIndex] = cardTexts[i];
    //         cardTexts[i] = tempText;
    //     }
    // }
}
