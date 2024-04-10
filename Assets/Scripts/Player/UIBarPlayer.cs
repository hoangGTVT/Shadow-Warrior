using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Unity.Mathematics;


public class UIBarPlayer : MonoBehaviour
{
    public static UIBarPlayer Instance;
    public Slider[] _slide;
    public GameObject[] _textPopUp;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
    

    public void SetHP(long hp)
    {
        _slide[0].value = hp;
    }

    public void SetMaxHP(long hp)
    {
        _slide[0].maxValue = hp;
       
    }

    public void SetKI(long hp)
    {
        _slide[1].value = hp;
    }

    public void SetMaxKI(long hp)
    {
        _slide[1].maxValue = hp;
        
    }
}
