using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Inform : MonoBehaviour
{
    public static Inform instance;
    public GameObject _inform;
    public TextMeshProUGUI _informText;
    private void Awake()
    {

        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }


    }
    void Start()
    {
        
    }
    public void ShowInform(string number,string text)
    {
        _inform.SetActive(true);
        _informText.text = number+" "+text;
        Invoke("TurnOffInForm", 2f);
    }

    public void TurnOffInForm()
    {
        _inform.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
