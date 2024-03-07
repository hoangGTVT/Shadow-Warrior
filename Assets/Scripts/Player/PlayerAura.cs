using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAura : MonoBehaviour
{
    public GameObject[] aura;
    public int _auraIndex;
    public int _preIndex;
    private void Awake()
    {
        _auraIndex = 0;
    }
    void Start()
    {
        //CheckAua();
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.B))
        {
             ChangeAura();
        }
    }

    public void ChangeAura()
    {
        _preIndex = _auraIndex;
        if (_auraIndex < aura.Length - 1)
        {
            _auraIndex++;
        }
        else _auraIndex = 0;


        SetAura();
        TurnOffAura();
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
    public void SetAura() {
        if (aura[_auraIndex].activeSelf)
        {
            return;
        }else
        aura[_auraIndex].SetActive(true);
        
    }

    public void TurnOffAura()
    {
        aura[_preIndex].SetActive(false);
    }

    public void TurnOffAura1()
    {
        aura[_auraIndex].SetActive(false);
    }

}
