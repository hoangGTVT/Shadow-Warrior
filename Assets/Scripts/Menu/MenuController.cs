using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public GameObject inputName;
    public TMP_InputField inputField;
    
    public string namePlayer;
    void Start()
    {
        /*PlayerPrefs.DeleteAll();*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void InputNamePlayer()
    {
        namePlayer=inputField.text;
        if (namePlayer.Length < 10)
        {
            PlayerPrefs.SetString("NamePlayer", namePlayer);
            inputName.SetActive(false);
        }
        else return;
    }
    public void LoadSence()
    {
        if (PlayerPrefs.GetString("NamePlayer") == "")
        {
            inputName.SetActive(true);
        }
        else
        {
            SceneManager.LoadScene("Game");
        }
        
    }
}
