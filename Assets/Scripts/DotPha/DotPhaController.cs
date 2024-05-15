using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DotPhaController : MonoBehaviour
{

    public PlayerManager playerManager;
    public ItemController itemController;
    public GameObject upFinish;
    public GameObject upfail;
    [Header("TextDotPha")]
    public TextMeshProUGUI[] text1;
    public Image[] spriteinfo;
    public Sprite[] bua;
    [Header("TextInfo")]
    public TextMeshProUGUI[] text2;
    public Image spriteinfo2;
    [Header("Nâng cấp")]
    public int goldNC;
    public int diamondNC;
    public int daNC;
    [Header("Level")]
    public int _levelHP;
    public int _levelKI;
    public int _levelATK;
    public int _levelDEF;
    public int _levelCrit;
    public int _levelCritDMG;
    public int _levelStamina;
    [Header("Chỉ số ")]
    public int _hpDotPha;
    public int _kiDotPha;
    public int _atkDotPha;
    public int _defDotPha;
    public int _critDotPha;
    public int _critDMGDotPha;
    public int _staminaDotPha;
    [Header("Nguyen lieu")]
    public int _buadoDP;
    public int _buavangDP;
    public int _buacamDP;
    public int _buatimDP;
    public int _buaxanhduongDP;
    public int _buaxanhlaDP;
    public int _buaxamDP;
    [Header("Gold")]
    public int _goldHP;
    public int _goldKI;
    public int _goldATK;
    public int _goldDEF;
    public int _goldCrit;
    public int _goldCritDMG;
    public int _goldStamina;
    [Header("Diamond")]
    public int _diamondHP;
    public int _diamondKI;
    public int _diamondATK;
    public int _diamondDEF;
    public int _diamondCrit;
    public int _diamondCritDMG;
    public int _diamondStamina;
    public List<string> names = new List<string>() { "1 sao", "2 sao", "3 sao", "4 sao", "5 sao","6 sao", "7 sao" };
    public Sprite[] sprites;
    public int indexDotPha;
   
    private const int _maxLevel = 20;

    //GetValue
    public int GetLevelHP() { return _levelHP; }
    public int GetLevelKI() { return _levelKI;}
    public int GetLevelATK() { return _levelATK; }
    public int GetLevelDEF() { return _levelDEF; }
    public int GetLevelCrit() { return _levelCrit; }
    public int GetLevelCritDMG() {  return _levelCritDMG; }
    public int GetLevelStamina() {  return _levelStamina; }
    public int GetHpDotPha() { return _hpDotPha = _levelHP * 1500; }
    public int GetKiDotPha() { return _kiDotPha= _levelKI * 1500; }
    public int GetAtkDotPha() { return _atkDotPha = _levelATK * 100; }
    public int GetDefDotPha() { return _defDotPha = _levelDEF *25; }
    public int GetCritDotPha() { return _critDotPha = _levelCrit * 1; }
    public int GetCritDMGDotPha() { return _critDMGDotPha = _levelCritDMG * 2; }
    public int GetStaminaDotPha() { return _staminaDotPha = _levelStamina * 300; }

    public int GetBuaDoDP() { return _buadoDP=_levelHP*daNC+daNC; }
    public int GetBuaCamDP() { return _buacamDP=_levelCritDMG* daNC + daNC; }
    public int GetBuaVangDP() { return _buavangDP=_levelCrit * daNC + daNC; }
    public int GetBuaXamDP() { return _buaxamDP=_levelDEF * daNC + daNC; }
    public int GetBuaXanhDuongDP() { return _buaxanhduongDP=_levelKI * daNC + daNC; }
    public int GetBuaXanhLaDP() { return _buaxanhlaDP=_levelStamina * daNC + daNC; }
    public int GetBuaTimDP() { return _buatimDP=_levelATK * daNC + daNC; }

    public int GetGoldHP() { return _goldHP = _levelHP * goldNC + goldNC; }
    public int GetGoldKI() { return _goldKI = _levelKI * goldNC + goldNC; }
    public int GetGoldATK() { return _goldATK = _levelATK * goldNC + goldNC; }
    public int GetGoldDEF() { return _goldDEF = _levelDEF * goldNC + goldNC; }
    public int GetGoldCrit() { return _goldCrit = _levelCrit * goldNC + goldNC; }
    public int GetGoldCritDMG() { return _goldCritDMG = _levelCritDMG * goldNC + goldNC; }
    public int GetGoldStamina() { return _goldStamina = _levelStamina * goldNC + goldNC; }

    public int GetDiamondHP() { return _diamondHP = _levelHP * diamondNC + diamondNC; }
    public int GetDiamondKI() { return _diamondKI=_levelKI * diamondNC + diamondNC; }
    public int GetDiamondATK() { return _diamondATK = _levelATK * diamondNC + diamondNC; }
    public int GetDiamondDEF() { return _diamondDEF = _levelDEF * diamondNC + diamondNC; }
    public int GetDiamondCrit() { return _diamondCrit = _levelCrit * diamondNC + diamondNC; }
    public int GetDiamondCritDMG() { return _diamondCritDMG = _levelCritDMG * diamondNC + diamondNC; }
    public int GetDiamondStamina() { return _diamondStamina = _levelStamina * diamondNC + diamondNC; }

    public int GetIndexDotPha() { return indexDotPha; }
    public Sprite GetSpriteDotPha() { return sprites[indexDotPha]; }    
    public string GetName() { return names[indexDotPha]; }
    //SetValue
    public void PlusLevelHP() { _levelHP++; }
    public void PlusLevelKI() { _levelKI++; }
    public void PlusLevelATK() { _levelATK++; }
    public void PlusLevelDEF() { _levelDEF++; }
    public void PlusLevelCrit() { _levelCrit++; }
    public void PlusLevelCritDMG() { _levelCritDMG++; }
    public void PlusLevelStamina() { _levelStamina++; }
    
    public void SetIndex(int index) { indexDotPha = index; }

    //ShowInfoDotPha
    public void ShowInfoDotPha()
    {
        switch (indexDotPha)
        {
            case 0:
                spriteinfo[0].sprite = sprites[0];
                spriteinfo[1].sprite = bua[0];
                text1[0].text = "Cấp " + GetLevelHP();
                text1[1].text = GetBuaDoDP().ToString();
                text1[2].text = GetGoldHP().ToString();
                text1[3].text = GetDiamondHP().ToString();

                break;
            case 1:
                spriteinfo[0].sprite = sprites[1];
                spriteinfo[1].sprite = bua[1];
                text1[0].text = "Cấp " + GetLevelKI();
                text1[1].text = GetBuaXanhDuongDP().ToString();
                text1[2].text = GetGoldKI().ToString();
                text1[3].text = GetDiamondKI().ToString();
                break;
            case 2:
                spriteinfo[0].sprite = sprites[2];
                spriteinfo[1].sprite = bua[2];
                text1[0].text = "Cấp " + GetLevelATK();
                text1[1].text = GetBuaTimDP().ToString();
                text1[2].text = GetGoldATK().ToString();
                text1[3].text = GetDiamondATK().ToString();
                break;
            case 3:
                spriteinfo[0].sprite = sprites[3];
                spriteinfo[1].sprite = bua[3];
                text1[0].text = "Cấp " + GetLevelDEF();
                text1[1].text = GetBuaXamDP().ToString();
                text1[2].text = GetGoldDEF().ToString();
                text1[3].text = GetDiamondDEF().ToString();
                break;
            case 4:
                spriteinfo[0].sprite = sprites[4];
                spriteinfo[1].sprite = bua[4];
                text1[0].text = "Cấp " + GetLevelCrit();
                text1[1].text = GetBuaVangDP().ToString();
                text1[2].text = GetGoldCrit().ToString();
                text1[3].text = GetDiamondCrit().ToString();
                break;
            case 5:
                spriteinfo[0].sprite = sprites[5];
                spriteinfo[1].sprite = bua[5];
                text1[0].text = "Cấp " + GetLevelCritDMG();
                text1[1].text = GetBuaCamDP().ToString();
                text1[2].text = GetGoldCritDMG().ToString();
                text1[3].text = GetDiamondCritDMG().ToString();
                break;
            case 6:
                spriteinfo[0].sprite = sprites[6];
                spriteinfo[1].sprite = bua[6];
                text1[0].text = "Cấp " + GetLevelStamina();
                text1[1].text = GetBuaXanhLaDP().ToString();
                text1[2].text = GetGoldStamina().ToString();
                text1[3].text = GetDiamondStamina().ToString();
                break;

        }
    }

    public void ShowInfo()
    {
        switch (indexDotPha)
        {
            case 0:
                spriteinfo2.sprite = sprites[0];
                text2[0].text= "Cấp " + GetLevelHP();
                text2[1].text = "Ngọc Đột Phá " + GetName();
                text2[2].text = "HP + " + GetHpDotPha();
                break;
            case 1:
                spriteinfo2.sprite = sprites[1];
                text2[0].text = "Cấp " + GetLevelKI();
                text2[1].text = "Ngọc Đột Phá " + GetName();
                text2[2].text = "KI + " + GetKiDotPha();
                break;
            case 2:
                spriteinfo2.sprite = sprites[2];
                text2[0].text = "Cấp " + GetLevelATK();
                text2[1].text = "Ngọc Đột Phá " + GetName();
                text2[2].text = "Tấn Công + " + GetAtkDotPha();
                break;
            case 3:
                spriteinfo2.sprite = sprites[3];
                text2[0].text = "Cấp " + GetLevelDEF();
                text2[1].text = "Ngọc Đột Phá " + GetName();
                text2[2].text = "Giáp + " + GetDefDotPha();
                break;
            case 4:
                spriteinfo2.sprite = sprites[4];
                text2[0].text = "Cấp " + GetLevelCrit();
                text2[1].text = "Ngọc Đột Phá " + GetName();
                text2[2].text = "Chí Mạng + " + GetCritDotPha()+"%";
                break;
            case 5:
                spriteinfo2.sprite = sprites[5];
                text2[0].text = "Cấp " + GetLevelCritDMG();
                text2[1].text = "Ngọc Đột Phá " + GetName();
                text2[2].text = "Sát Thương Chí Mạng + " + GetCritDMGDotPha()+"%";
                break;
            case 6:
                spriteinfo2.sprite = sprites[6];
                text2[0].text = "Cấp " + GetLevelStamina();
                text2[1].text = "Ngọc Đột Phá " + GetName();
                text2[2].text = "Thể Lực + " + GetStaminaDotPha();
                break;
            
        }
    }
   public void UpLevel()
    {
        switch (indexDotPha)
        {
            case 0:
                if (CheckHP()==true) {
                    PlusLevelHP();
                    
                    playerManager.SetData();
                    playerManager.SetTotalData();
                }
                
                break;
            case 1:
                if (CheckKI() == true)
                {
                    PlusLevelKI();
                    
                    playerManager.SetData();
                    playerManager.SetTotalData();
                }
                
                break;
            case 2:
                if (CheckATK() == true)
                {
                    PlusLevelATK();
                    
                    playerManager.SetData();
                    playerManager.SetTotalData();
                }
                
                break;
            case 3:
                if (CheckDEF() == true)
                {
                    PlusLevelDEF();
                   
                    playerManager.SetData();
                    playerManager.SetTotalData();
                }
                
                break;
            case 4:
                if (CheckCrit() == true)
                {
                    PlusLevelCrit();
                    
                    playerManager.SetData();
                    playerManager.SetTotalData();
                }
                
                break;
            case 5:
                if (CheckCritDMG() == true)
                {
                    PlusLevelCritDMG();
                    
                    playerManager.SetData();
                    playerManager.SetTotalData();
                }
                
                break;
            case 6:
                if (CheckStamina() == true)
                {
                    PlusLevelStamina();
                   
                    playerManager.SetData();
                    playerManager.SetTotalData();
                }
                
                break;

        }
    }

    public bool CheckHP()
    {
        if (GetLevelHP() < _maxLevel && itemController.GetGold() >= GetGoldHP() && itemController.GetDiamond() >= GetDiamondHP() && itemController.GetBuaDo() >= GetBuaDoDP())
        {
            itemController.MinusBuaDo(GetBuaDoDP());
            itemController.MinusGold(GetGoldHP());
            itemController.MinusDiamond(GetDiamondHP());
            upFinish.SetActive(true);
            return true;
        }
        else
        {
            upfail.SetActive(true);
            return false;
        }
    }
    public bool CheckKI()
    {
        if (GetLevelKI() < _maxLevel && itemController.GetGold() >= GetGoldKI() && itemController.GetDiamond() >= GetDiamondKI() && itemController.GetBuaXanhDuong() >= GetBuaXanhDuongDP())
        {
            itemController.MinusXanhDuong(GetBuaXanhDuongDP());
            itemController.MinusGold(GetGoldKI());
            itemController.MinusDiamond(GetDiamondKI());
            upFinish.SetActive(true);
            return true;
        }
        else
        {
            upfail.SetActive(true);
            return false;
        }
    }
    public bool CheckATK()
    {
        if (GetLevelATK() < _maxLevel && itemController.GetGold() >= GetGoldATK() && itemController.GetDiamond() >= GetDiamondATK() && itemController.GetBuaTim() >= GetBuaTimDP())
        {
            itemController.MinusBuaTim(GetBuaTimDP());
            itemController.MinusGold(GetGoldATK());
            itemController.MinusDiamond(GetDiamondATK());
            upFinish.SetActive(true);
            return true;
        }
        else
        {
            upfail.SetActive(true);
            return false;
        }
    }
    public bool CheckDEF()
    {
        if (GetLevelDEF() < _maxLevel && itemController.GetGold() >= GetGoldDEF() && itemController.GetDiamond() >= GetDiamondDEF() && itemController.GetBuaXam() >= GetBuaXamDP())
        {
            itemController.MinusBuaxam(GetBuaXamDP());
            itemController.MinusGold(GetGoldDEF());
            itemController.MinusDiamond(GetDiamondDEF());
            upFinish.SetActive(true);
            return true;
        }
        else
        {
            upfail.SetActive(true);
            return false;
        }
    }
    public bool CheckCrit()
    {
        if (GetLevelCrit() < _maxLevel && itemController.GetGold() >= GetGoldCrit() && itemController.GetDiamond() >= GetDiamondCrit() && itemController.GetBuaVang() >= GetBuaVangDP())
        {
            itemController.MinusBuaVang(GetBuaVangDP());
            itemController.MinusGold(GetGoldCrit());
            itemController.MinusDiamond(GetDiamondCrit());
            upFinish.SetActive(true);
            return true;
        }
        else
        {
            upfail.SetActive(true);
            return false;
        }
    }
    public bool CheckCritDMG()
    {
        if (GetLevelCritDMG() < _maxLevel && itemController.GetGold() >= GetGoldCritDMG() && itemController.GetDiamond() >= GetDiamondCritDMG() && itemController.GetBuaCam() >= GetBuaCamDP())
        {
            itemController.MinusBuacam(GetBuaCamDP());
            itemController.MinusGold(GetGoldCritDMG());
            itemController.MinusDiamond(GetDiamondCritDMG());
            upFinish.SetActive(true);
            return true;
        }
        else
        {
            upfail.SetActive(true);
            return false;
        }
    }
    public bool CheckStamina()
    {
        if (GetLevelStamina() < _maxLevel && itemController.GetGold() >= GetGoldStamina() && itemController.GetDiamond() >= GetDiamondStamina() && itemController.GetBuaxanhla() >= GetBuaXanhLaDP())
        {
            itemController.MinusXanhLa(GetBuaXanhLaDP());
            itemController.MinusGold(GetGoldStamina());
            itemController.MinusDiamond(GetDiamondStamina());
            upFinish.SetActive(true);
            return true;
        }
        else
        {
            upfail.SetActive(true);
            return false;
        }
    }
}
