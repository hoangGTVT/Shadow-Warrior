using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackPack : MonoBehaviour
{
    public GameObject[] backpack;
    public BackPackSO[] backPackSOs;
    int indexBackPack;

    public void SetIndexBP(int index) { indexBackPack = index; }
    public int GetIndexBP() {  return indexBackPack; }

    public int GetId() { return backPackSOs[indexBackPack].GetID(); }
    public Sprite GetSprite() { return backPackSOs[indexBackPack].GetSprite(); }
    public string GetName() { return backPackSOs[indexBackPack].GetName(); }
    public int GetHP() { return backPackSOs[indexBackPack].GetHP(); }  
    public int GetMP() { return backPackSOs[indexBackPack].Getenegy(); }
    public int GetATK() { return backPackSOs[indexBackPack].GetATK(); } 
    public int GetDEF() { return backPackSOs[indexBackPack].GetDef(); }
    public int GetCrit() { return backPackSOs[indexBackPack].GetCritRate(); }
    public int GetCritDMG() { return backPackSOs[indexBackPack].GetCritDMG(); }
    public int GetSta() { return backPackSOs[indexBackPack].GetStamina(); }


}
