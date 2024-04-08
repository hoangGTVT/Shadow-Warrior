using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAura : MonoBehaviour
{
    public GameObject[] aura;
    public int _auraIndex;
    public bool isAura;
    public int _preIndex;
    
    void Start()
    {
        SetIsAura(false);
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }

    public bool GetIsAura() { return isAura; }
    public void SetIsAura(bool Aura) { isAura = Aura; }
    public void SetIndexAura(int index)
    {
        _auraIndex=index;
        TurnOnAura();
        if (index > 0) { TurnOffAura(index - 1); }
        

    }

    public void ChangeAura()
    {
        _preIndex = _auraIndex;
        if (_auraIndex < aura.Length - 1)
        {
            _auraIndex++;
        }
        else _auraIndex = 0;


        
        
    }
    /*public void CheckAua()
    {
        for (int i = 0; i < aura.Length; i++)
        {
            if (aura[i].activeSelf)
            {
                return;
            }
            else
            {
                SetAura();
                return;
            }
        }
    }*/
    

    public void TurnOffAura(int index)
    {
        aura[index].SetActive(false);
    }
    public void TurnOffAura1()
    {
        aura[_auraIndex].SetActive(false);
    }

    public void TurnOnAura()
    {
        aura[_auraIndex].SetActive(true);
    }

}
