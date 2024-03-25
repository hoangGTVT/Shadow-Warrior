using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIBarPlayer : MonoBehaviour
{
    public static UIBarPlayer Instance;
    public Slider[] _slide;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    public void SetHP(int hp)
    {
        _slide[0].value = hp;
    }

    public void SetMaxHP(int hp)
    {
        _slide[0].maxValue = hp;
        _slide[0].value=hp;
    }

    public void SetKI(int hp)
    {
        _slide[1].value = hp;
    }

    public void SetMaxKI(int hp)
    {
        _slide[1].maxValue = hp;
        _slide[1].value = hp;
    }
}
