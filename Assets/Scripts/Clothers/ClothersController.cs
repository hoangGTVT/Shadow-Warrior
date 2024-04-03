using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class ClothersController : MonoBehaviour
{
    [Header("�o")]
    public ClothesSO[] clothesSOs;
    [Header("Quan")]
    public ClothesSO[] pan;
    [Header("g�ng")]
    public ClothesSO[] gang;
    [Header("gi�y")]
    public ClothesSO[] giay;
    [Header("rada")]
    public ClothesSO[] rada;
    public int indexClothers;
    public int indexquan;
    public int indexgang;
    public int indexgiay;
    public int indexrada;
    
    //ao
    public Sprite GetSpriteAo() { return clothesSOs[indexClothers].GetSprite(); }
    public int GetIDAo() { return clothesSOs[indexClothers].GetID(); }
    public string GetNameAo()  { return clothesSOs[indexClothers].GetName(); } 
    public int GetDefAo() { return clothesSOs[indexClothers].GetDef(); }
    public int GetPriceGoldAo() { return clothesSOs[indexClothers].GetPriceGold(); }
    public int GetPriceDiamondAo() { return clothesSOs[indexClothers ].GetPriceDiamond(); }
    //quan
    public Sprite GetSpriteQuan() { return pan[indexquan].GetSprite(); }
    public int GetIDQuan() { return pan[indexquan].GetID(); }
    public string GetNameQuan() { return pan[indexquan].GetName(); }
    public int GetHPQuan() { return pan[indexquan].GetHP(); }
    public int GetPriceGoldQuan() { return pan[indexquan].GetPriceGold(); }
    public int GetPriceDiamondQuan() { return pan[indexquan].GetPriceDiamond(); }
    //gang
    public Sprite GetSpriteGang() { return gang[indexgang].GetSprite(); }
    public int GetIDGang() { return gang[indexgang].GetID(); }
    public string GetNameGang() { return gang[indexgang].GetName(); }
    public int GetATKGang() { return gang[indexgang].GetATK(); }
    public int GetPriceGoldGang() { return gang[indexgang].GetPriceGold(); }
    public int GetPriceDiamondGang() { return gang[indexgang].GetPriceDiamond(); }
    //Giay
    public Sprite GetSpriteGiay() { return giay[indexgiay].GetSprite(); }
    public int GetIDGiay() { return giay[indexgiay].GetID(); }
    public string GetNameGiay() { return giay[indexgiay].GetName(); }
    public int GetKIGiay() { return giay[indexgiay].GetKI(); }
    public int GetPriceGoldGiay() { return giay[indexgiay].GetPriceGold(); }
    public int GetPriceDiamondGiay() { return giay[indexgiay].GetPriceDiamond(); }
    //rada
    public Sprite GetSpriteRaDa() { return rada[indexrada].GetSprite(); }
    public int GetIDRaDa() { return rada[indexrada].GetID(); }
    public string GetNameRaDa() { return rada[indexrada].GetName(); }
    public int GetCritRada()
    {
        return rada[indexrada].GetCritRate();
        
    }
    public int GetCritDMGRada()
    {
        return rada[indexrada].GetCritDMG();

    }
    public int GetStaminaRaDa() { return rada[indexrada].GetStamina(); }
    public int GetPriceGoldRaDa() { return rada[indexrada].GetPriceGold(); }
    public int GetPriceDiamondRaDa() { return rada[indexrada].GetPriceDiamond(); }
    //index
    public void SetIndexClother(int index) { indexClothers = index; }
    public int GetIndexClother() { return indexClothers; }
    public void SetIndexQuan(int index) { indexquan = index; }
    public int GetIndexQuan() { return indexquan; }
    public void SetIndexgang(int index) { indexgang = index; }
    public int GetIndexgang() { return indexgang; }
    public void SetIndexgiay(int index) { indexgiay = index; }
    public int GetIndexgiay() { return indexgiay; }
    public void SetIndexRada(int index) { indexrada = index; }
    public int GetIndexRada() { return indexrada; }
    void Start()
    {
        SetIndexClother(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}