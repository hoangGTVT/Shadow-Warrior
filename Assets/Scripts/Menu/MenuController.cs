using System.Collections;
using System.Collections.Generic;
using System.IO;
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
    public void DeleteData()
    {
        PlayerPrefs.DeleteAll();
        string[] filePaths = {
            Path.Combine(Application.persistentDataPath, "PlayerLife.json"),
            Path.Combine(Application.persistentDataPath, "Mission.json"),
            Path.Combine(Application.persistentDataPath, "SkinManager.json"),
            Path.Combine(Application.persistentDataPath, "BackPackManager.json"),
            Path.Combine(Application.persistentDataPath, "ClotherManager.json"),
            Path.Combine(Application.persistentDataPath, "Itemcontroller.json"),
    };

        foreach (string filePath in filePaths)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath); // Xóa tệp JSON
            }
        }
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
