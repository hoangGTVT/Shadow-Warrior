using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class SaoHoMenhController : MonoBehaviour
{
    public PlayerManager playerManager;
    public ItemController itemController;
    public GameObject upFinish;
    public GameObject upFail;
    [Header("TextDotPha")]
    public TextMeshProUGUI[] text1;
    public Image[] spriteinfo;
    public Sprite[] da;
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
    public int _hpSaoHoMenh;
    public int _kiSaoHoMenh;
    public int _atkSaoHoMenh;
    public int _defSaoHoMenh;
    public int _critSaoHoMenh;
    public int _critDMGSaoHoMenh;
    public int _staminaSaoHoMenha;
    [Header("Nguyen lieu")]
    //SaoHoMenhDo hp
    public int _daRubyHP;
    public int _daThachAnhHP;
    public int _daTitanHP;
    //SaoxanhDuong ki
    public int _daShaphiaKI;
    public int _daTiTanKI;
    public int _daRubyKI;
    //SaoTim atk
    public int _daThachAnhATK;
    public int _daShaphiaATK;
    public int _daLucBaoATK;
    //SaoHong Def
    public int _daRubyDEF;
    public int _daThachAnhDEF;
    public int _daLucBaoDef;
    //SaoVang crit
    public int _daRubyCrit;
    public int _daShaphiaCrit;
    public int _daLucBaoCrit;
    //SaoCam CritDMG
    public int _daTitanCritDMG;
    public int _daLucBaoCritDMG;
    public int _daShaphiaCritDMG;
    //SaoXanhLa Stamina
    public int _daTitanStamina;
    public int _daThachAnhStamina;
    public int _daShaphiaStamina;
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


    public List<string> names = new List<string>() { "Đỏ", "Xanh Dương", "Tím", "Hồng", "Vàng", "Cam", "Xanh Lá" };
    public Sprite[] sprites;
    public int indexSaoHoMenh;
    private const int _maxLevel = 20;

    //GetValue
    public int GetLevelHP() { return _levelHP; }
    public int GetLevelKI() { return _levelKI; }
    public int GetLevelATK() { return _levelATK; }
    public int GetLevelDEF() { return _levelDEF; }
    public int GetLevelCrit() { return _levelCrit; }
    public int GetLevelCritDMG() { return _levelCritDMG; }
    public int GetLevelStamina() { return _levelStamina; }
    public int GetHpSaoHoMenh() { return _hpSaoHoMenh=_levelHP*5; }
    public int GetKiSaoHoMenh() { return _kiSaoHoMenh=_levelKI*5; }
    public int GetAtkSaoHoMenh() { return _atkSaoHoMenh=_levelATK*5; }
    public int GetDefSaoHoMenh() { return _defSaoHoMenh=_levelDEF*2; }
    public int GetCritSaoHoMenh() { return _critSaoHoMenh=_levelCrit*1; }
    public int GetCritDMGSaoHoMenh() { return _critDMGSaoHoMenh=_levelCritDMG*2; }
    public int GetStaminaSaoHoMenh() { return _staminaSaoHoMenha=_levelStamina*3; }

    //HP
    public int GetDaRubyHP() { return _daRubyHP=_levelHP*daNC+daNC; }
    public int GetDaThachAnhHP() { return _daThachAnhHP = _levelHP*daNC +daNC ; }
    public int GetDaTiTanHP() { return _daTitanHP = _levelHP * daNC + daNC; }
    //Ki
    public int GetDaRubyKI() { return _daRubyKI = _levelKI * daNC + daNC; }
    public int GetDaTiTanKI() { return _daTiTanKI = _levelKI * daNC + daNC; }
    public int GetDaShaphiaKI() { return _daShaphiaKI = _levelKI * daNC + daNC; }
    //ATK
    public int GetDaShaphiaATK() { return _daShaphiaATK = _levelATK * daNC + daNC; }
    public int GetDaThachAnhATK() { return _daThachAnhATK = _levelATK * daNC +    daNC; }
    public int GetDaLucBaoATK() { return _daLucBaoATK = _levelATK * daNC + daNC; }
    //Def
    public int GetDaRubyDEF() { return _daRubyDEF = _levelDEF * daNC + daNC; }
    public int GetDaThachAnhDEF() { return _daThachAnhDEF = _levelDEF * daNC + daNC; }
    public int GetDaLucBaoDEF() { return _daLucBaoDef = _levelDEF * daNC + daNC; }
    //Crit
    public int GetDaRubyCrit() { return _daRubyCrit = _levelCrit * daNC + daNC; }
    public int GetDaShaphiaCrit() { return _daShaphiaCrit = _levelCrit * daNC +   daNC; }
    public int GetDaLucBaoCrit() { return _daLucBaoCrit = _levelCrit * daNC + daNC; }
    //CritDMG
    public int GetDaTiTanCritDMG() { return _daTitanCritDMG = _levelCritDMG * daNC + daNC; }
    public int GetDaShaphiaCritDMG() { return _daShaphiaCritDMG = _levelCritDMG * daNC + daNC; }
    public int GetDaLucBaoCritDMG() { return (_daLucBaoCritDMG) = _levelCritDMG * daNC + daNC; }
    //Stamina
    public int GetDaTiTanSta() { return _daTitanStamina = _levelStamina * daNC + daNC; }
    public int GetDaShaphiaSta() { return _daShaphiaStamina = _levelStamina * daNC + daNC; }
    public int GetDaThachAnhSta() { return _daThachAnhStamina = _levelStamina * daNC + daNC; }

    public int GetGoldHP() { return _goldHP = _levelHP * goldNC + goldNC; }
    public int GetGoldKI() { return _goldKI = _levelKI * goldNC + goldNC; }
    public int GetGoldATK() { return _goldATK = _levelATK * goldNC + goldNC; }
    public int GetGoldDEF() { return _goldDEF = _levelDEF * goldNC + goldNC; }
    public int GetGoldCrit() { return _goldCrit =   _levelCrit * goldNC + goldNC; }
    public int GetGoldCritDMG() { return _goldCritDMG = _levelCritDMG * goldNC + goldNC; }
    public int GetGoldStamina() { return _goldStamina = _levelStamina * goldNC + goldNC; }

    public int GetDiamondHP() { return _diamondHP = _levelHP * diamondNC + diamondNC; }
    public int GetDiamondKI() { return _diamondKI = _levelKI * diamondNC + diamondNC; }
    public int GetDiamondATK() { return _diamondATK = _levelATK * diamondNC + diamondNC; }
    public int GetDiamondDEF() { return _diamondDEF = _levelDEF * diamondNC + diamondNC; }
    public int GetDiamondCrit() { return _diamondCrit =     _levelCrit * diamondNC + diamondNC; }
    public int GetDiamondCritDMG() { return _diamondCritDMG = _levelCritDMG * diamondNC + diamondNC; }
    public int GetDiamondStamina() { return _diamondStamina = _levelStamina * diamondNC + diamondNC; }

    public int GetIndexDotPha() { return indexSaoHoMenh; }
    public Sprite GetSpriteDotPha() { return sprites[indexSaoHoMenh]; }
    public string GetName() { return names[indexSaoHoMenh]; }
    //SetValue
    public void PlusLevelHP() { _levelHP++; }
    public void PlusLevelKI() { _levelKI++; }
    public void PlusLevelATK() { _levelATK++; }
    public void PlusLevelDEF() { _levelDEF++; }
    public void PlusLevelCrit() { _levelCrit++; }
    public void PlusLevelCritDMG() { _levelCritDMG++; }
    public void PlusLevelStamina() { _levelStamina++; }
    
    public void SetIndex(int index) { indexSaoHoMenh = index; }

    
    //ShowInfo

    public void ShowInfoSaoHoMenh()
    {
        switch (indexSaoHoMenh)
        {
            case 0:
                spriteinfo2.sprite = sprites[0];
                text2[0].text = "Cấp " + GetLevelHP() ;
                text2[1].text = "Sao Hộ Mệnh " + GetName();
                text2[2].text="HP + "+GetHpSaoHoMenh() + "%";
                break;
            case 1:
                spriteinfo2.sprite = sprites[1];
                text2[0].text = "Cấp " + GetLevelKI();
                text2[1].text = "Sao Hộ Mệnh " + GetName();
                text2[2].text = "KI + " + GetKiSaoHoMenh() + "%";
                break;
            case 2:
                spriteinfo2.sprite = sprites[2];
                text2[0].text = "Cấp " + GetLevelATK();
                text2[1].text = "Sao Hộ Mệnh " + GetName();
                text2[2].text = "Tấn Công + " + GetAtkSaoHoMenh() + "%";
                break;
            case 3:
                spriteinfo2.sprite = sprites[3];
                text2[0].text = "Cấp " + GetLevelDEF();
                text2[1].text = "Sao Hộ Mệnh " + GetName();
                text2[2].text = "Giáp + " + GetDefSaoHoMenh() + "%";
                break;
            case 4:
                spriteinfo2.sprite = sprites[4];
                text2[0].text = "Cấp " + GetLevelCrit();
                text2[1].text = "Sao Hộ Mệnh " + GetName();
                text2[2].text = "Chí Mạng + " + GetCritSaoHoMenh() + "%";
                break;
            case 5:
                spriteinfo2.sprite = sprites[5];
                text2[0].text = "Cấp " + GetLevelCritDMG();
                text2[1].text = "Sao Hộ Mệnh " + GetName();
                text2[2].text = "Sát Thương Chí Mạng + " + GetCritDMGSaoHoMenh() + "%";
                break;
            case 6:
                spriteinfo2.sprite = sprites[6];
                text2[0].text = "Cấp " + GetLevelStamina();
                text2[1].text = "Sao Hộ Mệnh " + GetName();
                text2[2].text = "Thể lực + " + GetStaminaSaoHoMenh()+"%";
                break;
        }
    }


    public void ShowInfoNangCap()
    {
        switch (indexSaoHoMenh)
        {
            case 0:
                spriteinfo[0].sprite = sprites[0];
                spriteinfo[1].sprite = da[0];
                spriteinfo[2].sprite = da[1];
                spriteinfo[3].sprite = da[2];
                text1[0].text = "Cấp " + GetLevelHP();
                text1[1].text = GetDaRubyHP().ToString();
                text1[3].text = GetDaThachAnhHP().ToString();
                text1[2].text = GetDaTiTanHP().ToString();
                text1[4].text = GetGoldHP().ToString();
                text1[5].text = GetDiamondHP().ToString();
                break;
            case 1:
                spriteinfo[0].sprite = sprites[1];
                spriteinfo[1].sprite = da[0];
                spriteinfo[2].sprite = da[1];
                spriteinfo[3].sprite = da[3];
                text1[0].text = "Cấp " + GetLevelKI();
                text1[1].text = GetDaRubyKI().ToString();
                text1[2].text = GetDaTiTanKI().ToString();
                text1[3].text = GetDaShaphiaKI().ToString();
                text1[4].text = GetGoldKI().ToString();
                text1[5].text = GetDiamondKI().ToString();
                break;
            case 2:
                spriteinfo[0].sprite = sprites[2];
                spriteinfo[1].sprite = da[2];
                spriteinfo[2].sprite = da[3];
                spriteinfo[3].sprite = da[4];
                text1[0].text = "Cấp " + GetLevelATK();
                text1[1].text = GetDaThachAnhATK().ToString();
                text1[3].text = GetDaShaphiaATK().ToString();
                text1[2].text = GetDaLucBaoATK().ToString();
                text1[4].text = GetGoldATK().ToString();
                text1[5].text = GetDiamondATK().ToString();
                break;
            case 3:
                spriteinfo[0].sprite = sprites[3];
                spriteinfo[1].sprite = da[0];
                spriteinfo[2].sprite = da[2];
                spriteinfo[3].sprite = da[4];
                text1[0].text = "Cấp " + GetLevelDEF();
                text1[1].text = GetDaRubyDEF().ToString();
                text1[3].text = GetDaThachAnhDEF().ToString();
                text1[2].text = GetDaLucBaoDEF().ToString();
                text1[4].text = GetGoldDEF().ToString();
                text1[5].text = GetDiamondDEF().ToString();
                break;
            case 4:
                spriteinfo[0].sprite = sprites[4];
                spriteinfo[1].sprite = da[0];
                spriteinfo[2].sprite = da[3];
                spriteinfo[3].sprite = da[4];
                text1[0].text = "Cấp " + GetLevelCrit();
                text1[1].text = GetDaRubyCrit().ToString();
                text1[3].text = GetDaShaphiaCrit().ToString();
                text1[2].text = GetDaLucBaoCrit().ToString();
                text1[4].text = GetGoldCrit().ToString();
                text1[5].text = GetDiamondCrit().ToString();
                break;
            case 5:
                spriteinfo[0].sprite = sprites[5];
                spriteinfo[1].sprite = da[1];
                spriteinfo[2].sprite = da[3];
                spriteinfo[3].sprite = da[4];
                text1[0].text = "Cấp " + GetLevelCritDMG();
                text1[1].text = GetDaTiTanCritDMG().ToString();
                text1[3].text = GetDaShaphiaCritDMG().ToString();
                text1[2].text = GetDaLucBaoCritDMG().ToString();
                text1[4].text = GetGoldCritDMG().ToString();
                text1[5].text = GetDiamondCritDMG().ToString();
                break;
            case 6:
                spriteinfo[0].sprite = sprites[6];
                spriteinfo[1].sprite = da[1];
                spriteinfo[2].sprite = da[2];
                spriteinfo[3].sprite = da[3];
                text1[0].text = "Cấp " + GetLevelStamina();
                text1[1].text = GetDaTiTanSta().ToString();
                text1[3].text = GetDaThachAnhSta().ToString();
                text1[2].text = GetDaShaphiaSta().ToString();
                text1[4].text = GetGoldStamina().ToString();
                text1[5].text = GetDiamondStamina().ToString();
                break;
        
        }

        
    }
    public void UpLevel()
    {
        switch (indexSaoHoMenh)
        {
            case 0:
                if (CheckHP()==true)
                {
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
        if(GetLevelHP() < _maxLevel&& itemController.GetGold()>=GetGoldHP()&& itemController.GetDiamond()>=GetDiamondHP()&&itemController.GetDaRuby()>=GetDaRubyHP()&&
            itemController.GetDaTiTan() >= GetDaTiTanHP() && itemController.GetDaThachAnh() >= GetDaThachAnhHP())
        {
            itemController.MinusGold(GetGoldHP());
            itemController.MinusDiamond(GetDiamondHP());
            itemController.MinusDaRuby(GetDaRubyHP());
            itemController.MinusDaTiTan(GetDaTiTanHP());
            itemController.MinusThachAnh(GetDaTiTanHP());
            upFinish.SetActive(true);
            return true;
        }else upFail.SetActive(true); return false;
    }

    public bool CheckKI()
    {
        if (GetLevelKI() < _maxLevel && 
            itemController.GetGold() >= GetGoldKI() && 
            itemController.GetDiamond() >= GetDiamondKI() && 
            itemController.GetDaRuby() >= GetDaRubyKI() &&
            itemController.GetDaTiTan() >= GetDaTiTanKI() && 
            itemController.GetDaShaphia() >= GetDaShaphiaKI())
        {
            itemController.MinusGold(GetGoldKI());
            itemController.MinusDiamond(GetDiamondKI());
            itemController.MinusDaRuby(GetDaRubyKI());
            itemController.MinusDaTiTan(GetDaTiTanKI());
            itemController.MinusDaShaphia(GetDaShaphiaKI());
            upFinish.SetActive(true);
            return true;
        }
        else upFail.SetActive(true); return false;
    }

    public bool CheckATK()
    {
        if (GetLevelATK() < _maxLevel &&
            itemController.GetGold() >= GetGoldATK() &&
            itemController.GetDiamond() >= GetDiamondATK() &&
            itemController.GetDaThachAnh() >= GetDaThachAnhATK() &&
            itemController.GetDaShaphia() >= GetDaShaphiaATK() &&
            itemController.GetDaLucBao() >= GetDaLucBaoATK())
        {
            itemController.MinusGold(GetGoldATK());
            itemController.MinusDiamond(GetDiamondATK());
            itemController.MinusDaLucBao(GetDaLucBaoATK());
            itemController.MinusDaShaphia(GetDaShaphiaATK());
            itemController.MinusThachAnh(GetDaThachAnhATK());
            upFinish.SetActive(true);
            return true;
        }
        else upFail.SetActive(true); return false;
    }

    public bool CheckDEF()
    {
        if (GetLevelDEF() < _maxLevel &&
            itemController.GetGold() >= GetGoldDEF() &&
            itemController.GetDiamond() >= GetDiamondDEF() &&
            itemController.GetDaThachAnh() >= GetDaThachAnhDEF() &&
            itemController.GetDaRuby() >= GetDaRubyDEF() &&
            itemController.GetDaLucBao() >= GetDaLucBaoDEF())
        {
            itemController.MinusGold(GetGoldDEF());
            itemController.MinusDiamond(GetDiamondDEF());
            itemController.MinusDaLucBao(GetDaLucBaoDEF());
            itemController.MinusDaRuby(GetDaRubyDEF());
            itemController.MinusThachAnh(GetDaThachAnhDEF());
            upFinish.SetActive(true);
            return true;
        }
        else upFail.SetActive(true); return false;
    }

    public bool CheckCrit()
    {
        if (GetLevelCrit() < _maxLevel &&
            itemController.GetGold() >= GetGoldCrit() &&
            itemController.GetDiamond() >= GetDiamondCrit() &&
            itemController.GetDaShaphia() >= GetDaShaphiaCrit() &&
            itemController.GetDaRuby() >= GetDaRubyCrit() &&
            itemController.GetDaLucBao() >= GetDaLucBaoCrit())
        {
            itemController.MinusGold(GetGoldCrit());
            itemController.MinusDiamond(GetDiamondCrit());
            itemController.MinusDaLucBao(GetDaLucBaoCrit());
            itemController.MinusDaRuby(GetDaRubyCrit());
            itemController.MinusDaShaphia(GetDaShaphiaCrit());
            upFinish.SetActive(true);
            return true;
        }
        else upFail.SetActive(true); return false;
    }

    public bool CheckCritDMG()
    {
        if (GetLevelCritDMG() < _maxLevel &&
            itemController.GetGold() >= GetGoldCritDMG() &&
            itemController.GetDiamond() >= GetDiamondCritDMG() &&
            itemController.GetDaShaphia() >= GetDaShaphiaCritDMG() &&
            itemController.GetDaTiTan() >= GetDaTiTanCritDMG() &&
            itemController.GetDaLucBao() >= GetDaLucBaoCritDMG())
        {
            itemController.MinusGold(GetGoldCritDMG());
            itemController.MinusDiamond(GetDiamondCritDMG());
            itemController.MinusDaLucBao(GetDaLucBaoCritDMG());
            itemController.MinusDaShaphia(GetDaShaphiaCritDMG());
            itemController.MinusDaTiTan(GetDaTiTanCritDMG());
            upFinish.SetActive(true);
            return true;
        }
        else upFail.SetActive(true); return false;
    }
    public bool CheckStamina()
    {
        if (GetLevelStamina() < _maxLevel &&
            itemController.GetGold() >= GetGoldStamina() &&
            itemController.GetDiamond() >= GetDiamondStamina() &&
            itemController.GetDaShaphia() >= GetDaShaphiaSta() &&
            itemController.GetDaTiTan() >= GetDaTiTanSta() &&
            itemController.GetDaThachAnh() >= GetDaThachAnhSta())
        {
            itemController.MinusGold(GetGoldStamina());
            itemController.MinusDiamond(GetDiamondStamina());
            itemController.MinusDaTiTan(GetDaTiTanSta());
            itemController.MinusDaShaphia(GetDaShaphiaSta());
            itemController.MinusThachAnh(GetDaThachAnhSta());
            upFinish.SetActive(true);
            return true;
        }
        else upFail.SetActive(true); return false;
    }

}
