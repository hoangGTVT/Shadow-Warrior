using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;

public class PlayerLife : MonoBehaviour
{
    [Header("Name")]
    public string _namePlayer;
    [Header("HPPlayer")]
    public int _hpLevel;
    public int _hpEquip;
    public int _hpSkin;
    public int _hpBackPack;
    public int _hpDP;
    public int _hpStart;
    public int _hpTotal;
    public int _hpCurrent;
    [Header("KIPlayer")]
    public int _kiLevel;
    public int _kiEquip;
    public int _kiSkin;
    public int _kiBackPack;
    public int _kiDP;
    public int _kiStart;
    public int _kiTotal;
    public int _kiCurrent;
    [Header("ATKPlayer")]
    public int _atkLevel;
    public int _atkEquip;
    public int _atkSkin;
    public int _atkBackPack;
    public int _atkDP;
    public int _atkStart;
    public int _atkTotal;
    [Header("DEFPlayer")]

    public int _defLevel;
    public int _defEquip;
    public int _defSkin;
    public int _defBackPack;
    public int _defDP;
    public int _defStart;
    public int _defTotal;
    [Header("CritPlayer")]
    public int _critLevel;
    public int _critEquip;
    public int _critSkin;
    public int _critBackPack;
    public int _critDP;
    public int _critStart;
    public int _critTotal;
    [Header("CritDMGPlayer")]
    public int _critDMGLevel;
    public int _critDMGEquip;
    public int _critDMGSkin;
    public int _critDMGBackPack;
    public int _critDMGDP;
    public int _critDMGStart;
    public int _critDMGTotal;
    [Header("StaminaPlayer")]
    public int _staLevel;
    public int _staEquip;
    public int _staSkin;
    public int _staBackPack;
    public int _staDP;
    public int _staStart;
    public int _staTotal;
    public int _staCurrent;
    [Header("LevelPlayer")]
    public int _level;
    public int _expCurrent;
    public int _expLevel;
    [Header("LevelPlayer")]
    public int _smPlayer;
   

    private const int _defMax = 7000;
    //Get Value
    //SM
    public int GetSM() { return _smPlayer = GetHPTotal() * 100 + GetKITotal() * 80 + GetATKTotal() * 150 + GetDEFTotal() * 200 + GetCritTotal() * 200 + GetCritDMGTotal() * 150 + GetStaminaTotal() * 100; }
    //Level
    public int GetLevel() { return _level; }
    public int GetExpCurrent() { return _expCurrent; }
    public int GetExpLevel() { return _expLevel; }
    //HP
    public int GetHpLevel() { return _hpLevel = GetLevel() * 100; }
    public int GetHpEquip() { return _hpEquip; }
    public int GetHpSkin() { return _hpSkin; }
    public int GetHPBackPack() { return _hpBackPack; }
    public int GetHPDp() { return _hpDP; }
    public int GetHPStar() { return _hpStart; }
    public int GetHPTotal() { return _hpTotal; }
    public int GetHPCurrent() { return _hpCurrent; }
    //KI
    public int GetKILevel() { return _kiLevel = GetLevel() * 100; }
    public int GetKIEquip() { return _kiEquip; }
    public int GetKiSkin() { return _kiSkin; }
    public int GetKiBackPack() { return _kiBackPack; }
    public int GetKIDp() { return _kiDP; }
    public int GetKIStar() { return _kiStart; }
    public int GetKITotal() { return _kiTotal; }
    public int GetKICurrent() { return _kiCurrent; }
    //ATK
    public int GetATKLevel() { return _atkLevel = GetLevel() * 10; }
    public int GetATKEquip() { return _atkEquip; }
    public int GetATKSkin() { return _atkSkin; }
    public int GetATKBackPack() { return _atkBackPack; }
    public int GetATKDp() { return _atkDP; }
    public int GetATKStar() { return _atkStart; }
    public int GetATKTotal() { return _atkTotal; }

    //Def
    public int GetDEFMax() { return _defMax; }
    public int GetDEFLevel() { return _defLevel = GetLevel() * 10; }
    public int GetDEFEquip() { return _defEquip; }
    public int GetDEFSkin() { return _defSkin; }
    public int GetDEFBackPack() { return _defBackPack; }
    public int GetDEFDp() { return _defDP; }
    public int GetDEFStar() { return _defStart; }
    public int GetDEFTotal() { return _defTotal; }


    //Crit
    public int GetCritLevel() { return _critLevel = GetLevel() * 1; }
    public int GetCritEquip() { return _critEquip; }
    public int GetCritSkin() { return _critSkin; }
    public int GetCritBackPack() { return _critBackPack; }
    public int GetCritDp() { return _critDP; }
    public int GetCritStar() { return _critStart; }
    public int GetCritTotal() { return _critTotal; }

    //CritDMG
    public int GetCritDMGLevel() { return _critDMGLevel = GetLevel() + 100; }
    public int GetCritDMGEquip() { return _critDMGEquip; }
    public int GetCritDMGSkin() { return _critDMGSkin; }
    public int GetCritDMGBackPack() { return _critDMGBackPack; }
    public int GetCritDMGDp() { return _critDMGDP; }
    public int GetCritDMGStar() { return _critDMGStart; }
    public int GetCritDMGTotal() { return _critDMGTotal; }

    //Stamina
    public int GetStaminaLevel() { return _staLevel = GetLevel() * 100; }
    public int GetStaminaEquip() { return _staEquip; }
    public int GetStaminaSkin() { return _staSkin; }
    public int GetStaminaBackPack() { return _staBackPack; }
    public int GetStaminaDp() { return _staDP; }
    public int GetStaminaStar() { return _staStart; }
    public int GetStaminaTotal() { return _staTotal; }
    public int GetStaminaCurrent() { return _staCurrent; }

    public string GetName() { return _namePlayer; }
    public void SetName(string names) { _namePlayer = names; }

    //Set value
    //Level
    public void SetLevel(int index) { _level = index; }
    public void SetEXPLevel() { _expLevel = GetLevel() * 100; }
    public void SetEXPCurrent(int index) { _hpCurrent = index; }
    public void PlusLevel()
    {
        if (GetExpCurrent() >= GetExpLevel())
        {
            _expCurrent = GetExpCurrent() - GetExpLevel();
            _level++;
            SetEXPLevel();
        }
    }
    public void PlusEXPCurrent(int index) { _expLevel = index; }


    //HP
    public void SetHPEquip(int index) { _hpEquip = index; }
    public void SetHPSkin(int index) { _hpSkin = index; }
    public void SetHPBaclPack(int index) { _hpBackPack = index; }
    public void SetHPDP(int index) { _hpDP = index; }
    public void SetHPStar(int index) { _hpStart = index; }
    public void SetHPTotal() { _hpTotal = (GetHpLevel() + GetHpEquip() + GetHPBackPack() + GetHPDp()); if (!((GetHPStar() > 0) || (GetHpSkin() > 0))) return; _hpTotal += (_hpTotal * (GetHPStar() + GetHpSkin()) / 100); }
    public void SetHPCurrent() { _hpCurrent = GetHPTotal(); }
    public void PlusHPCurrent(int index)
    {
        if (_hpCurrent < GetHPTotal())
        {
            _hpCurrent += index;
            if(_hpCurrent> GetHPTotal())
            {
                SetHPCurrent();
            }
        }
        else { return; }

    }
    public void MinusHPCurrent(int index) 
    { 
        if (_hpCurrent > 0)
        {
            _hpCurrent -= HPMinus(index);
            if (_hpCurrent <= 0) { _hpCurrent=0; }
           
        }
        
        

    }

    public int HPMinus(int index) { return (int)(index - (index * (float)(GetDEFTotal() * 100 / _defMax) / 100)); }

    //Ki
    public void SetKIEquip(int index) { _kiEquip = index; }
    public void SetKISkin(int index) { _kiSkin = index; }
    public void SetKIBaclPack(int index) { _kiBackPack = index; }
    public void SetKIDP(int index) { _kiDP = index; }
    public void SetKIStar(int index) { _kiStart = index; }
    public void SetKITotal() { _kiTotal = GetKILevel() + GetKIEquip() + GetKiBackPack() + GetKIDp(); if (!(GetKiSkin() > 0 || GetKIStar() > 0)) return; _kiTotal += (_kiTotal * (GetKIStar() + GetKiSkin()) / 100); }
    public void SetKICurrent() { _kiCurrent = GetKITotal(); }
    public void PlusKICurrent(int index)
    {
        if (_kiCurrent < GetHPTotal())
        {
            _kiCurrent += index;
            if (_kiCurrent > GetKITotal())
            {
                SetKICurrent();
            }
            
        }
        

    }
    public void MinusKICurrent(int index) 
    {
        if (_kiCurrent > 0)
        {
            _kiCurrent -= index;
            if ( _kiCurrent < 0)
            {
                _kiCurrent = 0;
            }
        }
        
        
    }

    //ATK
    public void SetATKEquip(int index) { _atkEquip = index; }
    public void SetATKSkin(int index) { _atkSkin = index; }
    public void SetATKBaclPack(int index) { _atkBackPack = index; }
    public void SetATKDP(int index) { _atkDP = index; }
    public void SetATKStar(int index) { _atkStart = index; }
    public void SetATKTotal() { _atkTotal = GetATKLevel() + GetATKEquip() + GetATKBackPack() + GetATKDp(); if (!(GetATKSkin()>0|| (GetATKStar() > 0))) return; _atkTotal += (_atkTotal * (GetATKSkin()+ GetATKStar()) / 100); ; }

    //DEF
    public void SetDEFEquip(int index) { _defEquip = index; }
    public void SetDEFSkin(int index) { _defSkin = index; }
    public void SetDEFBaclPack(int index) { _defBackPack = index; }
    public void SetDEFDP(int index) { _defDP = index; }
    public void SetDEFStar(int index) { _defStart = index; }
    public void SetDEFTotal() { _defTotal = GetDEFLevel() + GetDEFEquip() + GetDEFBackPack() + GetDEFDp(); if (!(GetDEFSkin()>0|| (GetDEFStar() > 0))) return; _defTotal += (_defTotal * (GetDEFSkin()+ GetDEFStar()) / 100); ; }

    //Crit
    public void SetCritEquip(int index) { _critEquip = index; }
    public void SetCritSkin(int index) { _critSkin = index; }
    public void SetCritBaclPack(int index) { _critBackPack = index; }
    public void SetCritDP(int index) { _critDP = index; }
    public void SetCritStar(int index) { _critStart = index; }
    public void SetCritTotal() { _critTotal = GetCritLevel() + GetCritEquip() + GetCritBackPack() + GetCritDp() + GetCritStar()+GetCritSkin(); }
    //CritDMG
    public void SetCritDMGEquip(int index) { _critDMGEquip = index; }
    public void SetCritDMGSkin(int index) { _critDMGSkin = index; }
    public void SetCritDMGBaclPack(int index) { _critDMGBackPack = index; }
    public void SetCritDMGDP(int index) { _critDMGDP = index; }
    public void SetCritDMGStar(int index) { _critDMGStart = index; }
    public void SetCritDMGTotal() { _critDMGTotal = GetCritDMGLevel() + GetCritDMGEquip() + GetCritDMGBackPack() + GetCritDMGDp(); if (!((GetCritDMGSkin()>0|| GetCritDMGStar() > 0))) return; _critDMGTotal += (_critDMGTotal * (GetCritDMGSkin()+ GetCritDMGStar()) / 100); }
    //stamina
    public void SetStaEquip(int index) { _staEquip = index; }
    public void SetStaminaSkin(int index) { _staSkin = index; }
    public void SetStaBackPack(int index) { _staBackPack = index; }
    public void SetStaDP(int index) { _staDP = index; }
    public void SetStaStar(int index) { _staStart = index; }
    public void SetStaTotal() { _staTotal = GetStaminaLevel() + GetStaminaEquip() + GetStaminaBackPack() + GetStaminaDp(); if (!((GetStaminaSkin()>0|| GetStaminaStar() > 0))) return; _staTotal += (_staTotal * (GetStaminaSkin()+ GetStaminaStar()) / 100); }
    public void SetStaCurrent() { _staCurrent = GetKITotal(); }
    public void PlusStaCurrent(int index)
    {
        if (_staCurrent < GetHPTotal())
        {
            _staCurrent += index;
        }
        else { SetStaCurrent(); }

    }
    public void MinusStaCurrent(int index) 
    { 
        if (_staCurrent < 0)
        {
            _staCurrent -= index;
        }else { _staCurrent = 0; }
       
    }
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {

    }
}