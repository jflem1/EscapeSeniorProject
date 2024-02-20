using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerName : MonoBehaviour
{
    public string nameOfPlayer;
    public string saveName;

    public TMPro.TextMeshProUGUI inputText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // PlayerPrefs.GetString("name");
        // loadedName.text = nameOfPlayer;
        // Debug.Log(nameOfPlayer);
    }

    public void SetName(){
        saveName = inputText.text;
        PlayerPrefs.SetString("name", saveName);
        Debug.Log(saveName);
    }
}
