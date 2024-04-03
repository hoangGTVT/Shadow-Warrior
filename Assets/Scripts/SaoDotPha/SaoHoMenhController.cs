using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class SaoHoMenhController : MonoBehaviour
{
    [Header("TextDotPha")]
    public TextMeshProUGUI[] text1;
    public Image[] spriteinfo;
    public Sprite[] da;
    [Header("TextInfo")]
    public TextMeshProUGUI[] text2;
    public Image spriteinfo2;
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
    private const int _maxLevel = 50;

    //GetValue
    public int GetLevelHP() { return _levelHP; }
    public int GetLevelKI() { return _levelKI; }
    public int GetLevelATK() { return _levelATK; }
    public int GetLevelDEF() { return _levelDEF; }
    public int GetLevelCrit() { return _levelCrit; }
    public int GetLevelCritDMG() { return _levelCritDMG; }
    public int GetLevelStamina() { return _levelStamina; }
    public int GetHpSaoHoMenh() { return _hpSaoHoMenh; }
    public int GetKiSaoHoMenh() { return _kiSaoHoMenh; }
    public int GetAtkSaoHoMenh() { return +_atkSaoHoMenh; }
    public int GetDefSaoHoMenh() { return _defSaoHoMenh; }
    public int GetCritSaoHoMenh() { return _critSaoHoMenh; }
    public int GetCritDMGSaoHoMenh() { return _critDMGSaoHoMenh; }
    public int GetStaminaSaoHoMenh() { return _staminaSaoHoMenha; }

    //HP
    public int GetDaRubyHP() { return _daRubyHP; }
    public int GetDaThachAnhHP() { return _daThachAnhHP; }
    public int GetDaTiTanHP() { return _daTitanHP; }
    //Ki
    public int GetDaRubyKI() { return _daRubyKI; }
    public int GetDaTiTanKI() { return _daTiTanKI; }
    public int GetDaShaphiaKI() { return _daShaphiaKI; }
    //ATK
    public int GetDaShaphiaATK() { return _daShaphiaATK; }
    public int GetDaThachAnhATK() { return _daThachAnhATK; }
    public int GetDaLucBaoATK() { return (_daLucBaoATK); }
    //Def
    public int GetDaRubyDEF() { return _daRubyDEF; }
    public int GetDaThachAnhDEF() { return _daThachAnhDEF; }
    public int GetDaLucBaoDEF() { return (_daLucBaoDef); }
    //Crit
    public int GetDaRubyCrit() { return _daRubyCrit; }
    public int GetDaShaphiaCrit() { return _daShaphiaCrit; }
    public int GetDaLucBaoCrit() { return (_daLucBaoCrit); }
    //CritDMG
    public int GetDaTiTanCritDMG() { return _daTitanCritDMG; }
    public int GetDaShaphiaCritDMG() { return _daShaphiaCritDMG; }
    public int GetDaLucBaoCritDMG() { return (_daLucBaoCritDMG); }
    //Stamina
    public int GetDaTiTanSta() { return _daTitanStamina; }
    public int GetDaShaphiaSta() { return _daShaphiaStamina; }
    public int GetDaThachAnhSta() { return _daThachAnhStamina; }

    public int GetGoldHP() { return _goldHP; }
    public int GetGoldKI() { return _goldKI; }
    public int GetGoldATK() { return _goldATK; }
    public int GetGoldDEF() { return _goldDEF; }
    public int GetGoldCrit() { return _goldCrit; }
    public int GetGoldCritDMG() { return _goldCritDMG; }
    public int GetGoldStamina() { return _goldStamina; }

    public int GetDiamondHP() { return _diamondHP; }
    public int GetDiamondKI() { return _diamondKI; }
    public int GetDiamondATK() { return _diamondATK; }
    public int GetDiamondDEF() { return _diamondDEF; }
    public int GetDiamondCrit() { return _diamondCrit; }
    public int GetDiamondCritDMG() { return _diamondCritDMG; }
    public int GetDiamondStamina() { return _diamondStamina; }

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
    public void PlusHP() { _hpSaoHoMenh += 2; }
    public void PlusKi() { _kiSaoHoMenh += 2; }
    public void PlusATK() { _atkSaoHoMenh += 2; }
    public void PlusDef() { _defSaoHoMenh += 2; }
    public void PlusCrit() { _critSaoHoMenh += 1; }
    public void PlusCritDMG() { _critDMGSaoHoMenh += 2; }
    public void PlusStamina() { _staminaSaoHoMenha += 2; }

    public void PlusGoldHP() { _goldHP += 5000; }
    public void PlusGoldKI() { _goldKI += 5000; }
    public void PlusGoldATK() { _goldATK += 5000; }
    public void PlusGoldDEF() { _goldDEF += 5000; }
    public void PlusGoldCrit() { _goldCrit += 5000; }
    public void PlusGoldCritDMG() { _goldCritDMG += 5000; }
    public void PlusGoldStamina() { _goldStamina += 5000; }

    public void PlusDiamondHP() { _diamondHP += 300; }
    public void PlusDiamondKI() { _diamondKI += 300; }
    public void PlusDiamondATK() { _diamondATK += 300; }
    public void PlusDiamondDEF() { _diamondDEF += 300; }
    public void PlusDiamondCrit() { _diamondCrit += 300; }
    public void PlusDiamondCritDMG() { _diamondCritDMG += 300; }
    public void PlusDiamondStamina() { _diamondStamina += 300; }
    public void SetIndex(int index) { indexSaoHoMenh = index; }

    //NguyenLieu
    //HP
    public void PlusDaRubyHP() { _daRubyHP += 25; }
    public void PlusDaThachAnhHP() { _daThachAnhHP+= 25; }
    public void PlusDaTiTanHP() { _daTitanHP += 25; }
    //KI
    public void PlusDaRubyKI() { _daRubyKI += 25; }
    public void PlusDaTiTanKI() { _daTiTanKI += 25; }
    public void PlusDaShaphiaKI() { _daShaphiaKI += 25; }
    //ATK
    public void PlusDaShaphiaATK() { _daShaphiaKI += 25; }
    public void PlusDaThachAnhATK() { _daThachAnhHP += 25; }
    public void PlusDaLucBaoATK() { _daLucBaoATK += 25; }
    //DEF
    public void PlusDaRubyDEF() { _daRubyDEF += 25; }
    public void PlusDaThachAnhDEF() { _daThachAnhDEF += 25; }
    public void PlusDaLucBaoDEF() { _daLucBaoDef += 25; }
    //Crit
    public void PlusDaRubyCrit() { _daRubyCrit += 25; }
    public void PlusDaShaphiaCrit() { _daShaphiaCrit += 25; }
    public void PlusDaLucBaoCrit() { _daLucBaoCrit += 25; }
    //CritDMG
    public void PlusDaTiTanCritDMG() { _daTitanCritDMG += 25; }
    public void PlusDaShaphiaCritDMG() { _daShaphiaCritDMG += 25; }
    public void PlusDaLucBaoCritDMG() { _daLucBaoCritDMG += 25; }
    //Stamina
    public void PlusDaTiTanSta() { _daTitanStamina += 25; }
    public void PlusDaShaphiaSta() { _daShaphiaStamina += 25; }
    public void PlusDaThachAnhSta() { _daThachAnhStamina += 25; }
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
                text2[2].text = "ATK + " + GetAtkSaoHoMenh() + "%";
                break;
            case 3:
                spriteinfo2.sprite = sprites[3];
                text2[0].text = "Cấp " + GetLevelDEF();
                text2[1].text = "Sao Hộ Mệnh " + GetName();
                text2[2].text = "DEF + " + GetDefSaoHoMenh() + "%";
                break;
            case 4:
                spriteinfo2.sprite = sprites[4];
                text2[0].text = "Cấp " + GetLevelCrit();
                text2[1].text = "Sao Hộ Mệnh " + GetName();
                text2[2].text = "Crit + " + GetCritSaoHoMenh() + "%";
                break;
            case 5:
                spriteinfo2.sprite = sprites[5];
                text2[0].text = "Cấp " + GetLevelCritDMG();
                text2[1].text = "Sao Hộ Mệnh " + GetName();
                text2[2].text = "CritDMG + " + GetCritDMGSaoHoMenh() + "%";
                break;
            case 6:
                spriteinfo2.sprite = sprites[6];
                text2[0].text = "Cấp " + GetLevelStamina();
                text2[1].text = "Sao Hộ Mệnh " + GetName();
                text2[2].text = "Stamina + " + GetStaminaSaoHoMenh()+"%";
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
                PlusLevelHP();
                PlusHP();
                PlusDaRubyHP();
                PlusDaTiTanHP();
                PlusDaThachAnhHP();
                PlusGoldHP();
                PlusDiamondHP();
                break;
            case 1:
                PlusLevelKI();
                PlusKi();
                PlusDaRubyKI();
                PlusDaTiTanKI();
                PlusDaShaphiaKI();
                PlusGoldKI();
                PlusDiamondKI();
                break;
            case 2:
                PlusLevelATK();
                PlusATK();
                PlusDaThachAnhATK();
                PlusDaShaphiaATK();
                PlusDaLucBaoATK();
                PlusGoldATK();
                PlusDiamondATK();
                break;
            case 3:
                PlusLevelDEF();
                PlusDef();
                PlusDaRubyDEF();
                PlusDaThachAnhDEF();
                PlusDaLucBaoDEF();
                PlusGoldDEF();
                PlusDiamondDEF();
                break;
            case 4:
                PlusLevelCrit();
                PlusCrit();
                PlusDaRubyCrit();
                PlusDaShaphiaCrit();
                PlusDaLucBaoCrit();
                PlusGoldCrit();
                PlusDiamondCrit();
                break;
            case 5:
                PlusLevelCritDMG();
                PlusCritDMG();
                PlusDaTiTanCritDMG();
                PlusDaShaphiaCritDMG();
                PlusDaLucBaoCritDMG();
                PlusGoldCritDMG();
                PlusDiamondCritDMG();
                break;
            case 6:
                PlusLevelStamina();
                PlusStamina();
                PlusDaTiTanSta();
                PlusDaThachAnhSta();
                PlusDaShaphiaSta();
                PlusGoldStamina();
                PlusDiamondStamina();
                break;
        }
    }


}
