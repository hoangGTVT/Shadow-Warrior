using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIBar : MonoBehaviour
{
    public Slider[] slide;
    public GameObject[] slide1;
    private void Awake()
    {
        
    }
    public void setMaxValue(float value,int index)
    {
        SetCoolDowTime(index, true);
        slide[index].maxValue = value;
        slide[index].value = value;
    }
    public void setValue(float value, int index)
    {
        if (value > 0)
        {
            slide[index].value = value;
        }
        else
        {
            SetCoolDowTime(index, false);
        }
        

    }

    public void SetCoolDowTime(int index,bool state)
    {
        if (slide1!=null)
        {
            slide1[index].SetActive(state);
        }
        
    }
}
