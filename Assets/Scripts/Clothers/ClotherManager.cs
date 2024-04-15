using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClotherManager : MonoBehaviour
{
    [Header("Ao")]
    public int[] _ao;
   
    [Header("Quan")]
    public int[] _quan;
    
    [Header("Gang")]
    public int[] _gang;
    
    [Header("Giay")]
    public int[] _giay;
   
    [Header("Rada")]
    public int[] _rada;
   
    //GetValue SetValue
    //Ao
    public int GetAo(int index) { return _ao[index]; }
    

    public void PlusAo(int index) {
        _ao[index]++;
    }

    public void MinusAo(int index)
    {
        _ao[index]--;
    }


    //Quan
    public int GetQuan(int index) { return _quan[index]; }
    

    public void PlusQuan(int index)
    {
        _quan[index]++;
    }
    public void MinusQuan(int index) { _quan[index]--;}

    //Gang
    public int GetGang(int index) { return _gang[index]; }
    

    public void PlusGang(int index)
    {
        _gang[index]++;
    }
    public void MinusGang(int index) { _gang[index]--;}



    //Giay
    public int GetGiay(int index) { return _giay[index]; }
   

    public void PlusGiay(int index)
    {
        _giay[index]++;

    }
    public void MinusGiay(int index) { _giay[index]--;}



    //rada
    public int GetRada(int index) { return _rada[index]; }
    

    public void PlusRada(int index)
    {
        _rada[index]++;
    }
    public void MinusRada(int index) { _rada[index]--; }    
    


    // Update is called once per frame
    void Update()
    {
        
    }
}
