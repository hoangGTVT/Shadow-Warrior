using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class ClothersController : MonoBehaviour
{
    public ClothesSO[] clothesSOs;
    public int indexClothers;
    

    public Sprite GetSprite() { return clothesSOs[indexClothers].GetSprite(); }

    public int GetID() { return clothesSOs[indexClothers].GetID(); }
    public string GetName()  { return clothesSOs[indexClothers].GetName(); } 
    public int GetHP() { return clothesSOs[indexClothers].GetHP(); }
    public int Getenegy() { return clothesSOs[indexClothers].Getenegy(); }
    public int GetDef() { return clothesSOs[indexClothers].GetDef(); }
    public int GetCritRate() { return clothesSOs[indexClothers].GetCritRate(); }
    public int GetCritDMG() { return clothesSOs[indexClothers].GetCritDMG(); }
    public int GetATK() { return clothesSOs[indexClothers].GetATK(); }
    public int GetStamina() { return clothesSOs[indexClothers].GetStamina(); }

    //index
    public void SetIndexClother(int index) { indexClothers = index; }
    public int GetIndexClother() { return indexClothers; }
    void Start()
    {
        SetIndexClother(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
