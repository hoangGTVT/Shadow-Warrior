using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShopController : MonoBehaviour
{
    [Header("textgold")]
    public TextMeshProUGUI gold;
    public TextMeshProUGUI diamond;
    public GameObject skin;
    public GameObject clother;
    public GameObject item;
    [Header("Script")]
    public ItemController itemController;
    public ItemManager itemManagers;
    public ClothersController clothersController;
    public PlayerSkinController skinController;
    public BackPack backPack;
    public ClotherManager clotherManager;
    public SkinManager skinManager;
    public BackPackManager backPackManager;
    [Header("everythings")]
    public int indexSkin;
    public int indexClother;
    public int indexItem;
    public int indexShop;
    public int indexItemPack;
    [Header("Skin")]
    public Image iconskin;
    public Image iconskin2;
    public TextMeshProUGUI[] textskin;
    public TextMeshProUGUI[] textskin2;
    [Header("Clother")]
    public Image iconclother;
    public TextMeshProUGUI[] textclother;
    public int indexAo;
    public int indexQuan;
    public int indexGang;
    public int indexGiay;
    public int indexRada;
    public int indexBackpack;
    [Header("Buy")]
    public GameObject buyFinish;
    public GameObject buyFail;

    public void Awake()
    {
        indexShop = 0;
    }
    public void OnEnable()
    {
        indexShop = 0;
        
        skin.SetActive(true);
        clother.SetActive(false); 
        item.SetActive(false);
    }

    private void FixedUpdate()
    {
        ShowGoldDiamond();
    }
    public int GetIndexAo() { return indexAo; }
    public int GetIndexQuan() { return indexQuan; }
    public int GetIndexGang() {  return indexGang; }
    public int GetIndexGiay() { return indexGiay; }
    public int GetIndexRada() {  return indexRada; }
    public int GetIndexShop() { return indexShop; }
    public int GetIndexClother() {  return indexClother; }
    public int GetIndexItem() {  return indexItem; }
    public int GetIndexSkin() { return indexSkin; }

    public void SetIndexBackPack(int index) { indexBackpack = index;}
    public void SetIndexItemPack(int index) { indexItemPack = index; }
    public void SetIndexAo(int index) { indexAo = index; }
    public void SetIndexQuan(int index) { indexQuan = index;}
    public void SetIndexGang(int index) { indexGang = index;}
    public void SetIndexGiay(int index) {  indexGiay = index;}
    public void setIndexRada(int index) { indexRada = index;}   
    public void SetIndexSkin(int index) {  indexSkin = index; }
    public void SetIndexClother(int index) { indexClother = index; }
    public void SetIndexItem(int index) { indexItem = index; }
    public void SetIndexShop(int index) { indexShop = index; }
    // Update is called once per frame
    

    public void ShowInfoSkin()
    {
        iconskin.sprite = skinController.skinSO[indexSkin].GetSprite();
        textskin[0].text = skinController.skinSO[indexSkin].GetName();
        textskin[1].text = "Tấn Công + " + skinController.skinSO[indexSkin].GetATK().ToString()+"%";
        textskin[2].text = "Giáp + " + skinController.skinSO[indexSkin].GetDef().ToString() + "%";
        textskin[3].text = "KI + " + skinController.skinSO[indexSkin].GetKI().ToString() + "%";
        textskin[4].text = "HP + " + skinController.skinSO[indexSkin].GetHP().ToString() + "%";
        textskin[5].text = "Chí Mạng + " + skinController.skinSO[indexSkin].GetCritRate().ToString() + "%";
        textskin[6].text = "Sát Thương Chí Mạng + " + skinController.skinSO[indexSkin].GetCritDMG().ToString() + "%";
        textskin[7].text = "Thể Lực + " + skinController.skinSO[indexSkin].GetStamina().ToString() + "%";
    }

    public void ShowInfoBackPack()
    {
        iconskin.sprite = backPack.backPackSOs[indexBackpack].GetSprite();
        textskin[0].text = backPack.backPackSOs[indexBackpack].GetName();
        textskin[1].text = "Tấn Công + " + backPack.backPackSOs[indexBackpack].GetATK().ToString();
        textskin[2].text = "Giáp + " + backPack.backPackSOs[indexBackpack].GetDef().ToString() ;
        textskin[3].text = "KI + " + backPack.backPackSOs[indexBackpack].GetKI().ToString();
        textskin[4].text = "HP + " + backPack.backPackSOs[indexBackpack].GetHP().ToString();
        textskin[5].text = "Chí Mạng + " + backPack.backPackSOs[indexBackpack].GetCritRate().ToString() + "%";
        textskin[6].text = "Sát Thương Chí Mạng + " + backPack.backPackSOs[indexBackpack].GetCritDMG().ToString() + "%";
        textskin[7].text = "Thể Lực + " + backPack.backPackSOs[indexBackpack].GetStamina().ToString();
    }

    public void ShowInfoClother()
    {
        switch (indexClother)
        {
            case 0:
                iconclother.sprite = clothersController.clothesSOs[indexAo].GetSprite();
                textclother[0].text = clothersController.clothesSOs[indexAo].GetName();
                textclother[1].text = "";
                textclother[2].text = "Giáp + " + clothersController.clothesSOs[indexAo].GetDef().ToString(); 
                textclother[3].text = "";
                break;
            case 1:
                iconclother.sprite = clothersController.pan[indexQuan].GetSprite();
                textclother[0].text = clothersController.pan[indexQuan].GetName();
                textclother[1].text = "";
                textclother[2].text = "HP + " + clothersController.pan[indexQuan].GetHP().ToString(); 
                textclother[3].text = "";
                break;
            case 2:
                iconclother.sprite = clothersController.gang[indexGang].GetSprite();
                textclother[0].text = clothersController.gang[indexGang].GetName();
                textclother[1].text = "";
                textclother[2].text = "Tấn Công + " + clothersController.gang[indexGang].GetATK().ToString(); 
                textclother[3].text = "";
                break;
            case 3:
                iconclother.sprite = clothersController.giay[indexGiay].GetSprite();
                textclother[0].text = clothersController.giay[indexGiay].GetName();
                textclother[1].text = "";
                textclother[2].text = "KI + " + clothersController.giay[indexGiay].GetKI().ToString(); 
                textclother[3].text = "";
                break;
            case 4:
                iconclother.sprite = clothersController.rada[indexRada].GetSprite();
                textclother[0].text = clothersController.rada[indexRada].GetName();
                textclother[1].text = "Chí Mạng + " + clothersController.rada[indexRada].GetCritRate().ToString()+"%";
                textclother[2].text = "Sát Thương Chí Mạng + " + clothersController.rada[indexRada].GetCritDMG().ToString()+"%"; 
                textclother[3].text = "Thể Lực + " + clothersController.rada[indexRada].GetStamina().ToString();
                break;
        }
    }

    public void ShowInfoBuySkin()
    {
        switch (indexShop)
        {
            case 0:
                iconskin2.sprite = skinController.skinSO[indexSkin].GetSprite();
                textskin2[0].text = skinController.skinSO[indexSkin].GetName();
                textskin2[1].text = skinController.skinSO[indexSkin].GetPriceGold().ToString("#,#");
                textskin2[2].text = skinController.skinSO[indexSkin].GetPriceDiamond().ToString("#,#");
                break;
            case 1:
                switch (indexClother)
                {
                    case 0:
                        iconskin2.sprite = clothersController.clothesSOs[indexAo].GetSprite();
                        textskin2[0].text = clothersController.clothesSOs[indexAo].GetName();
                        textskin2[1].text = clothersController.clothesSOs[indexAo].GetPriceGold().ToString("#,#");
                        textskin2[2].text = clothersController.clothesSOs[indexAo].GetPriceDiamond().ToString("#,#");
                        break;
                    case 1:
                        iconskin2.sprite = clothersController.pan[indexQuan].GetSprite();
                        textskin2[0].text = clothersController.pan[indexQuan].GetName();
                        textskin2[1].text = clothersController.pan[indexQuan].GetPriceGold().ToString("#,#");
                        textskin2[2].text = clothersController.pan[indexQuan].GetPriceDiamond().ToString("#,#");
                        break;
                    case 2:
                        iconskin2.sprite = clothersController.gang[indexGang].GetSprite();
                        textskin2[0].text = clothersController.gang[indexGang].GetName();
                        textskin2[1].text = clothersController.gang[indexGang].GetPriceGold().ToString("#,#");
                        textskin2[2].text = clothersController.gang[indexGang].GetPriceDiamond().ToString("#,#");
                        break;
                    case 3:
                        iconskin2.sprite = clothersController.giay[indexGiay].GetSprite();
                        textskin2[0].text = clothersController.giay[indexGiay].GetName();
                        textskin2[1].text = clothersController.giay[indexGiay].GetPriceGold().ToString("#,#");
                        textskin2[2].text = clothersController.giay[indexGiay].GetPriceDiamond().ToString("#,#");
                        break;
                    case 4:
                        iconskin2.sprite = clothersController.rada[indexRada].GetSprite();
                        textskin2[0].text = clothersController.rada[indexRada].GetName();
                        textskin2[1].text = clothersController.rada[indexRada].GetPriceGold().ToString("#,#");
                        textskin2[2].text = clothersController.rada[indexRada].GetPriceDiamond().ToString("#,#");
                        break;
                }
                break;
                
            case 2:
                switch (indexItemPack)
                {
                    case 0:
                        iconskin2.sprite = backPack.backPackSOs[indexBackpack].GetSprite();
                        textskin2[0].text = backPack.backPackSOs[indexBackpack].GetName();
                        textskin2[1].text = backPack.backPackSOs[indexBackpack].GetPriceGold().ToString("#,#");
                        textskin2[2].text = backPack.backPackSOs[indexBackpack].GetPriceDiamond().ToString("#,#");
                        break;
                    case 1:
                        iconskin2.sprite = itemManagers.itemConsumeSOs[indexItem].GetSprite();
                        textskin2[0].text = itemManagers.itemConsumeSOs[indexItem].GetName();
                        textskin2[1].text = itemManagers.itemConsumeSOs[indexItem].GetPriceGold().ToString("#,#");
                        textskin2[2].text = itemManagers.itemConsumeSOs[indexItem].GetPriceDiamond().ToString("#,#");
                        break;
                }
                break;
                
        }
        
    }

    public void ShowGoldDiamond()
    {
        gold.text = itemController.GetGold().ToString("#,#");
        diamond.text = itemController.GetDiamond().ToString("#,#");

    }


    public void BuyByGold()
    {
        switch (indexShop)
        {
            case 0:
                if (itemController.GetGold() >= skinController.skinSO[indexSkin].GetPriceGold())
                {
                    itemController.MinusGold(skinController.skinSO[indexSkin].GetPriceGold());
                    skinManager.PlusSkin(indexSkin - 11);
                    buyFinish.SetActive(true);
                }else buyFail.SetActive(true);
                break;
            case 1:
                switch (indexClother)
                {
                    case 0:
                        if (itemController.GetGold() >= clothersController.clothesSOs[indexAo].GetPriceGold())
                        {
                            itemController.MinusGold(clothersController.clothesSOs[indexAo].GetPriceGold());
                            clotherManager.PlusAo(indexAo);
                            buyFinish.SetActive(true);
                        }
                        else buyFail.SetActive(true);
                        break;
                    case 1:
                        if (itemController.GetGold() >= clothersController.pan[indexQuan].GetPriceGold())
                        {
                            itemController.MinusGold(clothersController.pan[indexQuan].GetPriceGold());
                            clotherManager.PlusQuan(indexQuan);
                            buyFinish.SetActive(true);
                        }
                        else buyFail.SetActive(true);
                        break;
                    case 2:
                        if (itemController.GetGold() >= clothersController.gang[indexGang].GetPriceGold())
                        {
                            itemController.MinusGold(clothersController.gang[indexGang].GetPriceGold());
                            clotherManager.PlusGang(indexGang);
                            buyFinish.SetActive(true);
                        }
                        else buyFail.SetActive(true);
                        break;
                    case 3:
                        if (itemController.GetGold() >= clothersController.giay[indexGiay].GetPriceGold())
                        {
                            itemController.MinusGold(clothersController.giay[indexGiay].GetPriceGold());
                            clotherManager.PlusGiay(indexGiay);
                            buyFinish.SetActive(true);
                        }
                        else buyFail.SetActive(true);
                        break;
                    case 4:
                        if (itemController.GetGold() >= clothersController.rada[indexRada].GetPriceGold())
                        {
                            itemController.MinusGold(clothersController.rada[indexRada].GetPriceGold());
                            clotherManager.PlusRada(indexRada);
                            buyFinish.SetActive(true);
                        }
                        else buyFail.SetActive(true);
                        break;
                }
            break;
            case 2:
                switch (indexItemPack)
                {
                    case 0:
                        if (itemController.GetGold() >= backPack.backPackSOs[indexBackpack].GetPriceGold())
                        {
                            itemController.MinusGold(backPack.backPackSOs[indexBackpack].GetPriceGold());
                            backPackManager.PlusBackPack(indexBackpack);
                            buyFinish.SetActive(true);
                        }else buyFail.SetActive(true);
                        break;
                    case 1:
                        if (itemController.GetGold() >= itemManagers.itemConsumeSOs[indexItem].GetPriceGold())
                        {
                            itemController.MinusGold(itemManagers.itemConsumeSOs[indexItem].GetPriceGold());
                            PlusBuyItem(indexItem - 4);
                            buyFinish.SetActive(true);
                        }
                        else buyFail.SetActive(true);
                        break;
                }
                
                break;
        }
    }
    public void BuyByDiamond()
    {
        switch (indexShop)
        {
            case 0:
                if (itemController.GetDiamond() >= skinController.skinSO[indexSkin].GetPriceDiamond())
                {
                    itemController.MinusDiamond(skinController.skinSO[indexSkin].GetPriceDiamond());
                    skinManager.PlusSkin(indexSkin - 11);
                    buyFinish.SetActive(true);
                }
                else buyFail.SetActive(true);
                break;
            case 1:
                switch (indexClother)
                {
                    case 0:
                        if (itemController.GetDiamond() >= clothersController.clothesSOs[indexAo].GetPriceDiamond())
                        {
                            itemController.MinusDiamond(clothersController.clothesSOs[indexAo].GetPriceDiamond());
                            clotherManager.PlusAo(indexAo);
                            buyFinish.SetActive(true);
                        }
                        else buyFail.SetActive(true);
                        break;
                    case 1:
                        if (itemController.GetDiamond() >= clothersController.pan[indexQuan].GetPriceDiamond())
                        {
                            itemController.MinusDiamond(clothersController.pan[indexQuan].GetPriceDiamond());
                            clotherManager.PlusQuan(indexQuan);
                            buyFinish.SetActive(true);
                        }
                        else buyFail.SetActive(true);
                        break;
                    case 2:
                        if (itemController.GetDiamond() >= clothersController.gang[indexGang].GetPriceDiamond())
                        {
                            itemController.MinusDiamond(clothersController.gang[indexGang].GetPriceDiamond());
                            clotherManager.PlusGang(indexGang);
                            buyFinish.SetActive(true);
                        }
                        else buyFail.SetActive(true);
                        break;
                    case 3:
                        if (itemController.GetDiamond() >= clothersController.giay[indexGiay].GetPriceDiamond())
                        {
                            itemController.MinusDiamond(clothersController.giay[indexGiay].GetPriceDiamond());
                            clotherManager.PlusGiay(indexGiay);
                            buyFinish.SetActive(true);
                        }
                        else buyFail.SetActive(true);
                        break;
                    case 4:
                        if (itemController.GetDiamond() >= clothersController.rada[indexRada].GetPriceDiamond())
                        {
                            itemController.MinusDiamond(clothersController.rada[indexRada].GetPriceDiamond());
                            clotherManager.PlusRada(indexRada);
                            buyFinish.SetActive(true);
                        }
                        else buyFail.SetActive(true);
                        break;
                }
                break;
            case 2:
                switch (indexItemPack)
                {
                    case 0:
                        if (itemController.GetDiamond() >= backPack.backPackSOs[indexBackpack].GetPriceDiamond())
                        {
                            itemController.MinusDiamond(backPack.backPackSOs[indexBackpack].GetPriceDiamond());
                            backPackManager.PlusBackPack(indexBackpack);
                            buyFinish.SetActive(true);
                        }
                        else buyFail.SetActive(true);
                        break;
                    case 1:
                        if (itemController.GetDiamond() >= itemManagers.itemConsumeSOs[indexItem].GetPriceDiamond())
                        {
                            itemController.MinusDiamond(itemManagers.itemConsumeSOs[indexItem].GetPriceDiamond());
                            PlusBuyItem(indexItem - 4);
                            buyFinish.SetActive(true);
                        }
                        else buyFail.SetActive(true);
                        break;
                }

                break;
        }
    }
    
    public void PlusBuyItem(int index)
    {
        switch (index)
        {
            case 0:
                itemController.PlusBuaCam(1);
                break;
            case 1:
                itemController.PlusBuaDo(1);
                break;
            case 2:
                itemController.PlusBuaVang(1);
                break;
            case 3:
                itemController.PlusBuaTim(1);
                break;
            case 4:
                itemController.PlusBuaXanhDuong(1);
                break;
            case 5:
                itemController.PlusBuaXanhLa(1);
                break;
            case 6:
                itemController.PlusBuaXam(1);
                break;
            case 7:
                itemController.PlusDaRuby(1);
                break;
            case 8:
                itemController.PlusDaTiTan(1);
                break;
            case 9:
                itemController.PlusDaThachAnh(1);
                break;
            case 10:
                itemController.PlusDaShaphia(1);
                break;
            case 11:
                itemController.PlusDaLucBao(1);
                break;
            case 12:
                itemController.PlusDaNguSac(1);
                break;

        }
    }
}
