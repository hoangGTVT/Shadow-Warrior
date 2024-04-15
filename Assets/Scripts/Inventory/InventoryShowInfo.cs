using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InventoryShowInfo : MonoBehaviour
{
    [Header("Script")]
    public PlayerSkinController skinController;
    public SkinManager skinManager;
    public ItemManager itemManager;
    public ItemController itemController;
    public PlayerLife playerLife;
    public BackPack backPack;
    public BackPackManager backPackManager;

    public ClothersController clothersController;
    public ClotherManager clotherManager;
    [Header("objcet")]
    //Item
    public int indexItem;
    public Image iconItem;
    public TextMeshProUGUI nameIcon;
    //clother
    public int indexAo;
    public int indexQuan;
    public int indexGang;
    public int indexGiay;
    public int indexRada;
    public int indexBackPack;
    public Image iconClother;
    public TextMeshProUGUI[] textClother;
    //skin 
    public int indexSkin;
    public Image iconSkin;
    public TextMeshProUGUI[] textSkin;

    //indexEquip/Sell
    public int indexInventory;
    public int indexClother;
    private void OnEnable()
    {

    }

    //SetValue/Getvalue
    public int GetIndexItem() { return indexItem; }
    public int GetIndexAo() { return indexAo; }
    public int GetIndexQuan() { return indexQuan; }
    public int GetIndexGang() { return indexGang; }
    public int GetIndexGiay() { return indexGiay; }
    public int GetIndexRada() { return indexRada; }
    public int GetIndexBackPack() { return indexBackPack; }
    public int GetIndexSkin() { return indexSkin; }
    public int GetIndexInventory() { return indexInventory; }
    public int GetIndexClother() { return indexClother; }

    public void SetIndexInventory(int index) { indexInventory = index; }
    public void SetIndexClother(int index) { indexClother = index; }
    public void SetIndexItem(int index) { indexItem = index; }
    public void SetIndexAo(int index) { indexAo = index; }
    public void SetIndexQuan(int index) { indexQuan = index; }
    public void SetIndexGang(int index) { indexGang = index; }
    public void SetIndexGiay(int index) { indexGiay = index; }
    public void SetIndexRada(int index) { indexRada = index; }
    public void SetIndexBackPack(int index) { indexBackPack = index; }
    public void SetIndexSkin(int index) { indexSkin = index; }

    public void ShowInfoBackPack()
    {
        iconSkin.sprite = backPack.backPackSOs[indexBackPack].GetSprite();
        textSkin[0].text = backPack.backPackSOs[indexBackPack].GetName();
        textSkin[1].text = "Tấn Công + " + backPack.backPackSOs[indexBackPack].GetATK().ToString();
        textSkin[2].text = "Giáp + " + backPack.backPackSOs[indexBackPack].GetDef().ToString();
        textSkin[3].text = "HP + " + backPack.backPackSOs[indexBackPack].GetHP().ToString();
        textSkin[4].text = "KI + " + backPack.backPackSOs[indexBackPack].GetKI().ToString();
        textSkin[5].text = "Chí Mạng + " + backPack.backPackSOs[indexBackPack].GetCritRate().ToString() + "%";
        textSkin[6].text = "Sát Thương Chí Mạng + " + backPack.backPackSOs[indexBackPack].GetCritDMG().ToString() + "%";
        textSkin[7].text = "Thể Lực + " + backPack.backPackSOs[indexBackPack].GetStamina().ToString();
    }

    public void ShowInfoSkin()
    {
        iconSkin.sprite = skinController.skinSO[indexSkin].GetSprite();
        textSkin[0].text = skinController.skinSO[indexSkin].GetName();
        textSkin[1].text = "Tấn Công + " + skinController.skinSO[indexSkin].GetATK().ToString() + "%";
        textSkin[2].text = "Giáp + " + skinController.skinSO[indexSkin].GetDef().ToString() + "%";
        textSkin[3].text = "HP + " + skinController.skinSO[indexSkin].GetHP().ToString() + "%";
        textSkin[4].text = "KI + " + skinController.skinSO[indexSkin].GetKI().ToString() + "%";
        textSkin[5].text = "Chí Mạng + " + skinController.skinSO[indexSkin].GetCritRate().ToString() + "%";
        textSkin[6].text = "Sát Thương Chí Mạng + " + skinController.skinSO[indexSkin].GetCritDMG().ToString() + "%";
        textSkin[7].text = "Thể Lực + " + skinController.skinSO[indexSkin].GetStamina().ToString() + "%";
    }
    public void ShowInfoItem()
    {
        iconItem.sprite = itemManager.itemConsumeSOs[indexItem].GetIcon();
        nameIcon.text = itemManager.itemConsumeSOs[indexItem].GetName().ToString();
    }

    public void ShowInfoAo()
    {
        iconClother.sprite = clothersController.clothesSOs[indexAo].GetSprite();
        textClother[0].text = clothersController.clothesSOs[indexAo].GetName().ToString();
        textClother[1].text = "";
        textClother[3].text = "";
        textClother[2].text = "Giáp + " + clothersController.clothesSOs[indexAo].GetDef().ToString();
    }
    public void ShowInfoQuan()
    {
        iconClother.sprite = clothersController.pan[indexQuan].GetSprite();
        textClother[0].text = clothersController.pan[indexQuan].GetName().ToString();
        textClother[2].text = "HP + " + clothersController.pan[indexQuan].GetHP().ToString();
        textClother[1].text = "";
        textClother[3].text = "";
    }
    public void ShowInfoGang()
    {
        iconClother.sprite = clothersController.gang[indexGang].GetSprite();
        textClother[0].text = clothersController.gang[indexGang].GetName().ToString();
        textClother[2].text = "Tấn Công + " + clothersController.gang[indexGang].GetATK().ToString();
        textClother[1].text = "";
        textClother[3].text = "";
    }
    public void ShowInfoGiay()
    {
        iconClother.sprite = clothersController.giay[indexGiay].GetSprite();
        textClother[0].text = clothersController.giay[indexGiay].GetName().ToString();
        textClother[2].text = "KI + " + clothersController.giay[indexGiay].GetKI().ToString();
        textClother[1].text = "";
        textClother[3].text = "";
    }
    public void ShowInfoRada()
    {
        iconClother.sprite = clothersController.rada[indexRada].GetSprite();
        textClother[0].text = clothersController.rada[indexRada].GetName().ToString();
        textClother[1].text = "Chí Mạng + " + clothersController.rada[indexRada].GetCritRate().ToString() + "%";
        textClother[2].text = "Sát Thương Chí Mạng + " + clothersController.rada[indexRada].GetCritDMG().ToString() + "%";
        textClother[3].text = "Thể Lực + " + clothersController.rada[indexRada].GetStamina().ToString();
    }

    //equip
    public void EquipItem()
    {
        switch (indexInventory)
        {
            case 0:
                EquipSkin();
                break;
            case 1:
                switch (indexClother)
                {
                    case 0:

                        CheckLevelAo();
                        break;
                    case 1:
                        CheckLevelQuan();
                        break;
                    case 2:
                        CheckLevelGang();
                        break;
                    case 3:
                        CheckLevelGiay();
                        break;
                    case 4:
                        CheckLevelRada();
                        break;
                }
                break;
            case 2:
                EquipBackPack();
                break;
        }

    }

    //Skin
    public void EquipSkin()
    {
        if (playerLife.GetLevel() >= 15)
        {
            if (skinController.GetSkinIndex() >= 11 && skinController.GetIsSkin() == true) { skinManager.PlusSkin(skinController.GetSkinIndex() - 11); }

            skinController.SetSkin(indexSkin);

            skinManager.MinusSkin(indexSkin - 11);

        }
        else Inform.instance.ShowFail("15");
    }
    //BackPack
    public void EquipBackPack()
    {
        if (playerLife.GetLevel() >= 12)
        {
            
            if (backPack.GetIsBackPack() == true) { backPackManager.PlusBackPack(backPack.GetIndexBP()); }

            backPack.SetBackPack(indexBackPack);
            backPackManager.MinusBackPack(indexBackPack);
        }
        else Inform.instance.ShowFail("12");

    }
    //Rada
    public void EuipRada()
    {
        if (clothersController.GetIsRaDa() == true) { clotherManager.PlusRada(clothersController.GetIndexRada()); }

        clothersController.SetRada(indexRada);
        clotherManager.MinusRada(indexRada);
       
    }
    public void CheckLevelRada()
    {
        switch (indexRada)
        {
            case 0:
                EuipRada();
                break;
            case 1:
                if (playerLife.GetLevel() >= 10)
                {
                    EuipRada();
                }
                else Inform.instance.ShowFail("10");
                break;
            case 2:
                if (playerLife.GetLevel() >= 15)
                {
                    EuipRada();
                }
                else Inform.instance.ShowFail("15");
                break;
            case 3:
                if (playerLife.GetLevel() >= 20)
                {
                    EuipRada();
                }
                else Inform.instance.ShowFail("20");
                break;
            case 4:
                if (playerLife.GetLevel() >= 25)
                {
                    EuipRada();
                }
                else Inform.instance.ShowFail("25");
                break;
        }
    }
    //giay
    public void EquipGiay()
    {
        if (clothersController.GetIsGiay() == true) { clotherManager.PlusGiay(clothersController.GetIndexgiay()); }

        clothersController.SetGiay(indexGiay);
        clotherManager.MinusGiay(indexGiay);
    }
    public void CheckLevelGiay() {
        switch (indexGiay)
        {
            case 0:
                EquipGiay();
                break;
            case 1:
                if (playerLife.GetLevel() >= 10)
                {
                    EquipGiay();
                }
                else Inform.instance.ShowFail("10");
                break;
            case 2:
                if (playerLife.GetLevel() >= 15)
                {
                    EquipGiay();
                }
                else Inform.instance.ShowFail("15");
                break;
            case 3:
                if (playerLife.GetLevel() >= 20)
                {
                    EquipGiay();
                }
                else Inform.instance.ShowFail("20");
                break;
            case 4:
                if (playerLife.GetLevel() >= 25)
                {
                    EquipGiay();
                }
                else Inform.instance.ShowFail("25");
                break;
        }
    }

    //Gang
    public void EquipGang()
    {
        if (clothersController.GetIsGang() == true) { clotherManager.PlusGang(clothersController.GetIndexgang()); }

        clothersController.SetGang(indexGang);
        clotherManager.MinusGang(indexGang);
    }

    public void CheckLevelGang()
    {
        switch (indexGang)
        {
            case 0:
                EquipGang();
                break;
            case 1:
                if (playerLife.GetLevel() >= 10)
                {
                    EquipGang();
                }
                else Inform.instance.ShowFail("10");
                break;
            case 2:
                if (playerLife.GetLevel() >= 15)
                {
                    EquipGang();
                }
                else Inform.instance.ShowFail("15");
                break;
            case 3:
                if (playerLife.GetLevel() >= 20)
                {
                    EquipGang();
                }
                else Inform.instance.ShowFail("20");
                break;
            case 4:
                if (playerLife.GetLevel() >= 25)
                {
                    EquipGang();
                }
                else Inform.instance.ShowFail("25");
                break;
        }
    }

    //EquipAO
    public void EquipAo()
    {
        if (clothersController.GetIsAo() == true) { clotherManager.PlusAo(clothersController.GetIndexClother()); }

        clothersController.SetAo(indexAo);
        clotherManager.MinusAo(indexAo);
    }
    public void CheckLevelAo()
    {
        switch (indexAo)
        {
            case 0:
                EquipAo();
                break;
            case 1:
                if (playerLife.GetLevel() >= 10)
                {
                    EquipAo();
                }
                else Inform.instance.ShowFail("10");
                break;
            case 2:
                if (playerLife.GetLevel() >= 15)
                {
                    EquipAo();
                }
                else Inform.instance.ShowFail("15");
                break;
            case 3:
                if (playerLife.GetLevel() >= 20)
                {
                    EquipAo();
                }
                else Inform.instance.ShowFail("20");
                break;
            case 4:
                if (playerLife.GetLevel() >= 25)
                {
                    EquipAo();
                }
                else Inform.instance.ShowFail("25");
                break;

        }
    }
    //EquipQuan 
    public void EquipQuan()
    {
        if (clothersController.GetIsQuan() == true) { clotherManager.PlusQuan(clothersController.GetIndexQuan()); }

        clothersController.SetQuan(indexQuan);
        clotherManager.MinusQuan(indexQuan);
    }
    public void CheckLevelQuan()
    {
        switch (indexQuan)
        {
            case 0:
                EquipQuan();
                break;
            case 1:
                if (playerLife.GetLevel() >= 10)
                {
                    EquipQuan();
                }
                else Inform.instance.ShowFail("10");
                break;
            case 2:
                if (playerLife.GetLevel() >= 15)
                {
                    EquipQuan();
                }
                else Inform.instance.ShowFail("15");
                break;
            case 3:
                if (playerLife.GetLevel() >= 20)
                {
                    EquipQuan();
                }
                else Inform.instance.ShowFail("20");
                break;
            case 4:
                if (playerLife.GetLevel() >= 25)
                {
                    EquipQuan();
                }
                else Inform.instance.ShowFail("25");
                break;
        }
    }
    public void SellItem()
    {
        switch (indexInventory)
        {
            case 0:
                skinManager.MinusSkin(indexSkin - 11);
                itemController.PlusGold(skinController.skinSO[indexSkin].GetPriceGold() / 5);
                int ig = skinController.skinSO[indexSkin].GetPriceGold() / 10;
                Inform.instance.ShowInform(ig.ToString(), "Gold");
                break;
            case 1:
                switch (indexClother)
                {
                    case 0:
                        int golg = clothersController.clothesSOs[indexAo].GetPriceGold()/5;
                        itemController.PlusGold(golg);
                        clotherManager.MinusAo(indexAo);
                        Inform.instance.ShowInform(golg.ToString(), "Gold");
                        break;
                    case 1:
                        int golg1 = clothersController.pan[indexQuan].GetPriceGold() / 5;
                        itemController.PlusGold(golg1);
                        clotherManager.MinusQuan(indexQuan);
                        Inform.instance.ShowInform(golg1.ToString(), "Gold");
                        break;
                    case 2:
                        int golg2 = clothersController.gang[indexGang].GetPriceGold() / 5;
                        itemController.PlusGold(golg2);
                        clotherManager.MinusGang(indexGang);
                        Inform.instance.ShowInform(golg2.ToString(), "Gold");
                        break;
                    case 3:
                        int golg3 = clothersController.giay[indexGiay].GetPriceGold() / 5;
                        itemController.PlusGold(golg3);
                        clotherManager.MinusGiay(indexGiay);
                        Inform.instance.ShowInform(golg3.ToString(), "Gold");
                        break;
                    case 4:
                        int golg4 = clothersController.rada[indexRada].GetPriceGold() / 5;
                        itemController.PlusGold(golg4);
                        clotherManager.MinusRada(indexRada);
                        Inform.instance.ShowInform(golg4.ToString(), "Gold");
                        break;
                }
                break;
            case 2:
                int gold5 = backPack.backPackSOs[indexBackPack].GetPriceGold()/5;
                itemController.PlusGold(gold5);
                backPackManager.MinusBackPack(indexBackPack);
                Inform.instance.ShowInform(gold5.ToString(), "Gold");
                break;
            
        }
    }
}
