using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIBoss : MonoBehaviour
{
    public Slider[] slider;


    public void SetMaxHP(int hp)
    {
        slider[0].maxValue = hp;
        slider[0].value = hp;
    }

    public void SetHp(int hp)
    {
        slider[0].value = hp;
    }
    public void SetMaxKI(int hp)
    {
        slider[1].maxValue = hp;
        
    }

    public void SetKI(int hp)
    {
        slider[1].value = hp;
    }
}
