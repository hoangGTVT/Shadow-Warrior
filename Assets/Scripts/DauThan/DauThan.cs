using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DauThan : MonoBehaviour
{
    public Slider slider;
    public float timecool = 90;
    public TextMeshProUGUI textMeshPro;
    public GameObject dauthan;
    public PlayerManager playerManager;
    public PlayerLife playerLife;
    public void SetMaxValue()
    {
        slider.maxValue = timecool;
        slider.value = timecool;
    }

    public void SetValue(float h) {
        
        if (h > 0)
        {
            slider.value = h;
        }else dauthan.SetActive(false);
    }
    void Start()
    {
        SetMaxValue();
    }

    // Update is called once per frame
    void Update()
    {
        if (timecool > 0)
        {
            timecool -= 2 * Time.deltaTime;
            
            
        }
        float time2 = (float)Math.Round(timecool, 1);
        SetValue(time2);
        textMeshPro.text = time2.ToString();if (time2 <= 0&& dauthan.activeSelf) { dauthan.SetActive(false);}
    }

    public void HeathHPDauThan()
    {
        playerManager.HealHP(playerLife.GetHPTotal()/5);
        playerManager.HealKi(playerLife.GetKITotal() / 5);
        timecool = 60;
        dauthan.SetActive(true);
    }
}
