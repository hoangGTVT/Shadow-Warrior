using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MenuPlayer : MonoBehaviour
{
    public PlayerSkinController skinController;
    public ClothersController clothersController;
    public PlayerManager playerManager;
    public PlayerLife playerLife;
    public BackPack backpack;
    [Header("Icon")]
    public Image iconAo;
    public Image iconQuan;
    public Image iconGang;
    public Image iconGiay;
    public Image iconRada;
    public Image iconSkin1;
    public Image iconSkin2;
    public Image iconBackPack;
    public GameObject[] iconC;
    [Header("Clother")]
    public Image iconClother;
    public TextMeshProUGUI nameClother;
    public TextMeshProUGUI[] descriptionClother;
    [Header("Skin")]
    public GameObject iconSkin;
    public Image iconskin;
    public TextMeshProUGUI nameSkin;
    public TextMeshProUGUI atk;
    public TextMeshProUGUI hp;
    public TextMeshProUGUI ki;
    public TextMeshProUGUI def;
    public TextMeshProUGUI crit;
    public TextMeshProUGUI critDMG;
    public TextMeshProUGUI Stamina;

    public GameObject showInfoSkin;
    public int indexRemove;
   
    void Update()
    {
        ShowIcon();
    }

    public void ShowAo()
    {
        iconClother.sprite = clothersController.GetSpriteAo();
        nameClother.text = clothersController.GetNameAo().ToString();
        descriptionClother[1].text= "DEF + "+clothersController.GetDefAo().ToString();
        descriptionClother[0].text = "";
        descriptionClother[2].text = "";
    }
    public void ShowQuan()
    {
        iconClother.sprite = clothersController.GetSpriteQuan();
        nameClother.text = clothersController.GetNameQuan().ToString();
        descriptionClother[1].text = "HP + " + clothersController.GetHPQuan().ToString();
        descriptionClother[0].text = "";
        descriptionClother[2].text = "";
    }
    public void ShowGang()
    {
        iconClother.sprite = clothersController.GetSpriteGang();
        nameClother.text = clothersController.GetNameGang().ToString();
        descriptionClother[1].text = "ATK + " + clothersController.GetATKGang().ToString();
        descriptionClother[0].text = "";
        descriptionClother[2].text = "";
    }
    public void ShowGiay()
    {
        iconClother.sprite = clothersController.GetSpriteGiay();
        nameClother.text = clothersController.GetNameGiay().ToString();
        descriptionClother[1].text = "KI + " + clothersController.GetKIGiay().ToString();
        descriptionClother[0].text = "";
        descriptionClother[2].text = "";
    }
    public void ShowRada()
    {
        iconClother.sprite = clothersController.GetSpriteRaDa();
        nameClother.text = clothersController.GetNameRaDa().ToString();
        descriptionClother[0].text = "Crit + " + clothersController.GetCritRada().ToString();
        descriptionClother[1].text = "CritDMG + " + clothersController.GetCritDMGRada().ToString();
        descriptionClother[2].text = "Stamina + " + clothersController.GetStaminaRaDa().ToString();
    }

    public void ShowSkin()
    {
        if (skinController.isSkin == true)
        {
            showInfoSkin.SetActive(true);
            iconskin.sprite = skinController.skinSO[skinController.skinIndex].GetSprite();
            nameSkin.text = skinController.skinSO[skinController.skinIndex].GetName();
            atk.text = "ATK + " + skinController.skinSO[skinController.skinIndex].GetATK().ToString() + "%";
            def.text = "DEF + " + skinController.skinSO[skinController.skinIndex].GetDef().ToString() + "%";
            hp.text = "HP + " + skinController.skinSO[skinController.skinIndex].GetHP().ToString() + "%";
            ki.text = "KI + " + skinController.skinSO[skinController.skinIndex].GetKI().ToString() + "%";
            crit.text = "Crit + " + skinController.skinSO[skinController.skinIndex].GetCritRate().ToString() + "%";
            critDMG.text = "CritDMG + " + skinController.skinSO[skinController.skinIndex].GetCritDMG().ToString() + "%";
            Stamina.text = "Stamina + " + skinController.skinSO[skinController.skinIndex].GetStamina().ToString() + "%";
        }
        
    }
    public void SetIndexRomove(int index) { indexRemove = index; }
    public void RemoveSkin()
    {
        skinController.SetIsSkin(false);
        skinController.SetSkinIndex(skinController.GetSkinIndexLevel());
        playerManager.SetData();
        playerManager.SetTotalData();
    }
    public void RemoveBackPack()
    {
        backpack.SetIsBackPack(false);
        playerManager.SetData();
        playerManager.SetTotalData();
    }
    public void RemoveAo()
    {
        clothersController.SetIsAo(false);
        playerManager.SetData();
        playerManager.SetTotalData();
        
    }
    
    public void RemoveQuan()
    {
        clothersController.SetIsQuan(false);
        playerManager.SetData();
        playerManager.SetTotalData();
        
    }
    public void RemoveGang()
    {
        clothersController.SetIsGang(false);
        playerManager.SetData();
        playerManager.SetTotalData();
        
    }
    public void RemoveGiay()
    {
        clothersController.SetIsGiay(false);
        playerManager.SetData();
        playerManager.SetTotalData();
           
    }
    public void RemoveRada()
    {
        clothersController.SetIsRaDa(false);
        playerManager.SetData();
        playerManager.SetTotalData();
        
    }

    
    public void Removeclother() {
        switch (indexRemove)
        {
            case 0:
                RemoveAo();
                break;
            case 1: RemoveQuan();
                break;
            case 2: RemoveGang();
                break;
            case 3: RemoveGiay();
                break;
            case 4: RemoveRada();
                break;
            case 5: RemoveSkin();
                break;
            case 6: RemoveBackPack();
                break;
            
        }
    }
    public void ShowIcon()
    {
        iconSkin2.sprite = skinController.skinSO[skinController.skinIndex].GetSprite();
        if (skinController.isSkin == true)
        {
            iconSkin.SetActive(true);
            iconSkin1.sprite = skinController.skinSO[skinController.skinIndex].GetSprite();

        }
        else { iconSkin.SetActive(false); }
        if (clothersController.GetIsAo() == true)
        {
            iconC[0].SetActive(true);
            iconAo.sprite = clothersController.GetSpriteAo();
        }
        else { iconC[0].SetActive(false); }


        if (clothersController.GetIsQuan() == true)
        {
            iconC[1].SetActive(true);
            iconQuan.sprite = clothersController.GetSpriteQuan();
        }
        else { iconC[1].SetActive(false); }


        if (clothersController.GetIsGang() == true)
        {
            iconC[2].SetActive(true);
            iconGang.sprite = clothersController.GetSpriteGang();
        }
        else { iconC[2].SetActive(false); }


        if (clothersController.GetIsGiay() == true)
        {
            iconC[3].SetActive(true);
            iconGiay.sprite = clothersController.GetSpriteGiay();
        }
        else { iconC[3].SetActive(false); }


        if (clothersController.GetIsRaDa() == true)
        {
            iconC[4].SetActive(true);
            iconRada.sprite = clothersController.GetSpriteRaDa();
        }
        else { iconC[4].SetActive(false); }

        if (backpack.GetIsBackPack() == true)
        {
            iconC[5].SetActive(true);
            iconBackPack.sprite = backpack.GetSprite();
        }
        else { iconC[5].SetActive(false);}
 
    }

    public void ShowBackPack()
    {
        showInfoSkin.SetActive(true);
        iconskin.sprite = backpack.GetSprite();
        nameSkin.text = backpack.GetName();
        atk.text = "ATK + " + backpack.GetATK();
        def.text = "DEF + " + backpack.GetDEF();
        hp.text = "HP + " + backpack.GetHP();
        ki.text = "KI + " +backpack.GetKI();
        crit.text = "Crit + " + backpack.GetCrit() ;
        critDMG.text = "CritDMG + " + backpack.GetCritDMG();
        Stamina.text = "Stamina + " + backpack.GetSta();
    }

}
