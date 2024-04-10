using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClotherManager : MonoBehaviour
{
    [Header("Ao")]
    public int _ao1;
    public int _ao2;
    public int _ao3;
    public int _ao4;
    public int _ao5;
    [Header("Quan")]
    public int _quan1;
    public int _quan2;
    public int _quan3;
    public int _quan4;
    public int _quan5;
    [Header("Gang")]
    public int _gang1;
    public int _gang2;
    public int _gang3;
    public int _gang4;
    public int _gang5;
    [Header("Giay")]
    public int _giay1;
    public int _giay2;
    public int _giay3;
    public int _giay4;
    public int _giay5;
    [Header("Rada")]
    public int _rada1;
    public int _rada2;
    public int _rada3;
    public int _rada4;
    public int _rada5;
    //GetValue SetValue
    //Ao
    public int GetAo1() { return _ao1; }
    public int GetAo2() { return _ao2; }
    public int GetAo3() { return _ao3; }
    public int GetAo4() { return _ao4; }
    public int GetAo5() { return _ao5; }

    public void PlusAo(int index) {
        switch (index)
        {
            case 0:
                _ao1++;
                break;
            case 1:
                _ao2++;
                break;
            case 2:
                _ao3++;
                break;
            case 3: _ao4++;
                break;
            case 4: _ao5++;
                break;
        }
    }


    //Quan
    public int GetQuan1() { return _quan1; }
    public int GetQuan2() { return _quan2; }
    public int GetQuan3() { return _quan3; }
    public int GetQuan4() { return _quan4; }
    public int GetQuan5() { return _quan5; }

    public void PlusQuan(int index)
    {
        switch (index)
        {
            case 0:
                _quan1++;
                break;
            case 1:
                _quan2++;
                break;
            case 2:
                _quan3++;
                break;
            case 3:
                _quan4++;
                break;
            case 4:
                _quan5++;
                break;
        }
    }

    //Gang
    public int GetGang1() { return _gang1; }
    public int GetGang2() { return _gang2; }
    public int GetGang3() { return _gang3; }
    public int GetGang4() { return _gang4; }
    public int GetGang5() { return _gang5; }

    public void PlusGang(int index)
    {
        switch (index)
        {
            case 0: _gang1++;
                break;
            case 1: _gang2++;
                break;
            case 2: _gang3++;
                break;
            case 3: _gang4++;
                break;
            case 4:
                _gang5++;
                break;
        }
    }



    //Giay
    public int GetGiay1() { return _giay1; }
    public int GetGiay2() { return _giay2; }
    public int GetGiay3() { return _giay3; }
    public int GetGiay4() { return _giay4; }
    public int GetGiay5() { return _giay5; }

    public void PlusGiay(int index)
    {
        switch (index)
        {
            case 0: _giay1++;
                break;
            case 1: _giay2++;
                break;
            case 2: _giay3++;
                break;
            case 3: _giay4++;
                break;
            case 4: _giay5++;
                break;
        }
    }



    //rada
    public int GetRada1() { return _rada1; }
    public int GetRada2() { return _rada2; }
    public int GetRada3() { return _rada3; }
    public int GetRada4() { return _rada4; }
    public int GetRada5() { return _rada5; }

    public void PlusRada(int index)
    {
        switch (index)
        {
            case 0: _rada1++;
                break; 
            case 1: _rada2++;
                break;
            case 2: _rada3++;
                break;
            case 3: _rada4++;
                break;
            case 4: _rada5++;
                break;
        }
    }
    


    // Update is called once per frame
    void Update()
    {
        
    }
}
