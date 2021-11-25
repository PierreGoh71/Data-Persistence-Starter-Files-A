using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine;

public class DisplayScore : MonoBehaviour
{
    public TMP_InputField nameInputField;

    public TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "BestScore: " + MenuManager.Instance.BestScoreName + " : " + MenuManager.Instance.BestScore;

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void EnteredName(string name)
    {
        Debug.Log(nameInputField.text);
        MenuManager.Instance.PlayerName = nameInputField.text;
    }

    
}
