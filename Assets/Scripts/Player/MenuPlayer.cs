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
    public SkinManager skinManager;
    public BackPackManager backPackManager;
    public ClotherManager clotherManager;
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
    public GameObject ShowInfoClother;
    public int indexRemove;
   
    void Update()
    {
        ShowIcon();
    }

    public void ShowAo()
    {
        if(clothersController.isAo==true)
        {
            ShowInfoClother.SetActive(true);
            iconClother.sprite = clothersController.GetSpriteAo();
            nameClother.text = clothersController.GetNameAo().ToString();
            descriptionClother[1].text = "Giáp + " + clothersController.GetDefAo().ToString();
            descriptionClother[0].text = "";
            descriptionClother[2].text = "";
        }
        
    }
    public void ShowQuan()
    {
        if (clothersController.isQuan == true)
        {
            ShowInfoClother.SetActive(true);
            iconClother.sprite = clothersController.GetSpriteQuan();
            nameClother.text = clothersController.GetNameQuan().ToString();
            descriptionClother[1].text = "HP + " + clothersController.GetHPQuan().ToString();
            descriptionClother[0].text = "";
            descriptionClother[2].text = "";
        }
        
    }
    public void ShowGang()
    {
        if (clothersController.isGang == true)
        {
            ShowInfoClother.SetActive(true);
            iconClother.sprite = clothersController.GetSpriteGang();
            nameClother.text = clothersController.GetNameGang().ToString();
            descriptionClother[1].text = "Tấn Công + " + clothersController.GetATKGang().ToString();
            descriptionClother[0].text = "";
            descriptionClother[2].text = "";
        }
       
    }
    public void ShowGiay()
    {
        if (clothersController.isGiay == true)
        {
            ShowInfoClother.SetActive(true);
            iconClother.sprite = clothersController.GetSpriteGiay();
            nameClother.text = clothersController.GetNameGiay().ToString();
            descriptionClother[1].text = "KI + " + clothersController.GetKIGiay().ToString();
            descriptionClother[0].text = "";
            descriptionClother[2].text = "";
        }
       
    }
    public void ShowRada()
    {
        if (clothersController.isRaDa == true)
        {
            ShowInfoClother.SetActive(true);
            iconClother.sprite = clothersController.GetSpriteRaDa();
            nameClother.text = clothersController.GetNameRaDa().ToString();
            descriptionClother[0].text = "Chí Mạng + " + clothersController.GetCritRada().ToString()+"%";
            descriptionClother[1].text = "Sát Thương Chí Mạng + " + clothersController.GetCritDMGRada().ToString() + "%";
            descriptionClother[2].text = "Thể Lực + " + clothersController.GetStaminaRaDa().ToString();
        }
        
    }

    public void ShowSkin()
    {
        if (skinController.isSkin == true)
        {
            showInfoSkin.SetActive(true);
            iconskin.sprite = skinController.skinSO[skinController.skinIndex].GetSprite();
            nameSkin.text = skinController.skinSO[skinController.skinIndex].GetName();
            atk.text = "Tấn Công + " + skinController.skinSO[skinController.skinIndex].GetATK().ToString() + "%";
            def.text = "Giáp + " + skinController.skinSO[skinController.skinIndex].GetDef().ToString() + "%";
            hp.text = "HP + " + skinController.skinSO[skinController.skinIndex].GetHP().ToString() + "%";
            ki.text = "KI + " + skinController.skinSO[skinController.skinIndex].GetKI().ToString() + "%";
            crit.text = "Chí Mạng + " + skinController.skinSO[skinController.skinIndex].GetCritRate().ToString() + "%";
            critDMG.text = "Sát Thương Chí Mạng + " + skinController.skinSO[skinController.skinIndex].GetCritDMG().ToString() + "%";
            Stamina.text = "Thể Lực + " + skinController.skinSO[skinController.skinIndex].GetStamina().ToString() + "%";
        }
        
    }
    public void SetIndexRomove(int index) { indexRemove = index; }
    public void RemoveSkin()
    {
        skinManager.PlusSkin(skinController.GetSkinIndex()-11);
        skinController.SetIsSkin(false);
        skinController.SetSkinIndex(skinController.GetSkinIndexLevel());
        
        playerManager.SetData();
        playerManager.SetTotalData();
    }
    public void RemoveBackPack()
    {
        backPackManager.PlusBackPack(backpack.GetIndexBP());
        backpack.SetIsBackPack(false);
        playerManager.SetData();
        playerManager.SetTotalData();
    }
    public void RemoveAo()
    {
        clotherManager.PlusAo(clothersController.GetIndexClother());
        clothersController.SetIsAo(false);
        playerManager.SetData();
        playerManager.SetTotalData();
        
    }
    
    public void RemoveQuan()
    {
        clotherManager.PlusQuan(clothersController.GetIndexQuan());
        clothersController.SetIsQuan(false);
        playerManager.SetData();
        playerManager.SetTotalData();
        
    }
    public void RemoveGang()
    {
        clotherManager.PlusGang(clothersController.GetIndexgang());
        clothersController.SetIsGang(false);
        playerManager.SetData();
        playerManager.SetTotalData();
        
    }
    public void RemoveGiay()
    {
        clotherManager.PlusGiay(clothersController.GetIndexgiay());
        clothersController.SetIsGiay(false);
        playerManager.SetData();
        playerManager.SetTotalData();
           
    }
    public void RemoveRada()
    {
        clotherManager.PlusRada(clothersController.GetIndexRada());
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
        if (backpack.isBackPack == true)
        {
            showInfoSkin.SetActive(true);
            iconskin.sprite = backpack.GetSprite();
            nameSkin.text = backpack.GetName();
            atk.text = "Tấn Công + " + backpack.GetATK();
            def.text = "Giáp + " + backpack.GetDEF();
            hp.text = "HP + " + backpack.GetHP();
            ki.text = "KI + " + backpack.GetKI();
            crit.text = "Chí Mạng + " + backpack.GetCrit()+"%";
            critDMG.text = "Sát Thương Chí Mạng + " + backpack.GetCritDMG()+"%";
            Stamina.text = "Thể Lực + " + backpack.GetSta();
        }
       
    }

}
