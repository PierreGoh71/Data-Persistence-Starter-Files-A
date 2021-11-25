using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using TMPro;

public class MenuHandler : MonoBehaviour
{
    public TMP_InputField Input;
    public void NewPlayerName(TMP_InputField Input)
    {
        if (Input.text == "")
        {
            return;
        }
        else
        {
            string PlayerName = Input.text;
            MenuManager.Instance.PlayerName = PlayerName;
            SceneManager.LoadScene(1);
        }
    }

    public void Start()
    {
        if (MenuManager.Instance.PlayerName != null)
        {
            Input.text = MenuManager.Instance.PlayerName;
        }
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }

}
