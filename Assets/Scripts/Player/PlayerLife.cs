using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using System.Numerics;

public class PlayerLife : MonoBehaviour
{
    [Header("Name")]
    public string _namePlayer;
    [Header("HPPlayer")]
    public long _hpLevel;
    public long _hpEquip;
    public long _hpSkin;
    public long _hpBackPack;
    public long _hpDP;
    public long _hpStart;
    public long _hpTotal;
    public long _hpCurrent;
    [Header("KIPlayer")]
    public long _kiLevel;
    public long _kiEquip;
    public long _kiSkin;
    public long _kiBackPack;
    public long _kiDP;
    public long _kiStart;
    public long _kiTotal;
    public long _kiCurrent;
    [Header("ATKPlayer")]
    public long _atkLevel;
    public long _atkEquip;
    public long _atkSkin;
    public long _atkBackPack;
    public long _atkDP;
    public long _atkStart;
    public long _atkTotal;
    [Header("DEFPlayer")]

    public long _defLevel;
    public long _defEquip;
    public long _defSkin;
    public long _defBackPack;
    public long _defDP;
    public long _defStart;
    public long _defTotal;
    [Header("CritPlayer")]
    
    public long _critEquip;
    public long _critSkin;
    public long _critBackPack;
    public long _critDP;
    public long _critStart;
    public long _critTotal;
    [Header("CritDMGPlayer")]
    
    public long _critDMGEquip;
    public long _critDMGSkin;
    public long _critDMGBackPack;
    public long _critDMGDP;
    public long _critDMGStart;
    public long _critDMGTotal;
    [Header("StaminaPlayer")]
    public long _staLevel;
    public long _staEquip;
    public long _staSkin;
    public long _staBackPack;
    public long _staDP;
    public long _staStart;
    public long _staTotal;
    public long _staCurrent;
    [Header("LevelPlayer")]
    public long _level;
    public long _expCurrent;
    public long _expLevel;
    [Header("LevelPlayer")]
    public long  _smPlayer;

    private const long _defMax = 7000;
    //Get Value
    //SM
    public long GetSM() { return _smPlayer = GetHPTotal() * 100*GetLevel() + GetKITotal() * GetLevel()*100 + GetATKTotal() * 300 * GetLevel() + GetDEFTotal() * 100*GetLevel() + GetCritTotal() * 10000*GetLevel() + GetCritDMGTotal() * 1000*GetLevel() + GetStaminaTotal() * 1000; }
    //Level
    public long GetLevel() { return _level; }
    public long GetExpCurrent() { return _expCurrent; }
    public long GetExpLevel() { return _expLevel; }
    //HP
    public long GetHpLevel() { return _hpLevel = GetLevel() * 200; }
    public long GetHpEquip() { return _hpEquip; }
    public long GetHpSkin() { return _hpSkin; }
    public long GetHPBackPack() { return _hpBackPack; }
    public long GetHPDp() { return _hpDP; }
    public long GetHPStar() { return _hpStart; }
    public long GetHPTotal() { return _hpTotal; }
    public long GetHPCurrent() { return _hpCurrent; }
    //KI
    public long GetKILevel() { return _kiLevel = GetLevel() * 200; }
    public long GetKIEquip() { return _kiEquip; }
    public long GetKiSkin() { return _kiSkin; }
    public long GetKiBackPack() { return _kiBackPack; }
    public long GetKIDp() { return _kiDP; }
    public long GetKIStar() { return _kiStart; }
    public long GetKITotal() { return _kiTotal; }
    public long GetKICurrent() { return _kiCurrent; }
    //ATK
    public long GetATKLevel() { return _atkLevel = GetLevel() * 20; }
    public long GetATKEquip() { return _atkEquip; }
    public long GetATKSkin() { return _atkSkin; }
    public long GetATKBackPack() { return _atkBackPack; }
    public long GetATKDp() { return _atkDP; }
    public long GetATKStar() { return _atkStart; }
    public long GetATKTotal() { return _atkTotal; }

    //Def
    public long GetDEFMax() { return _defMax; }
    public long GetDEFLevel() { return _defLevel = GetLevel() * 5; }
    public long GetDEFEquip() { return _defEquip; }
    public long GetDEFSkin() { return _defSkin; }
    public long GetDEFBackPack() { return _defBackPack; }
    public long GetDEFDp() { return _defDP; }
    public long GetDEFStar() { return _defStart; }
    public long GetDEFTotal() { return _defTotal; }


    //Crit
    
    public long GetCritEquip() { return _critEquip; }
    public long GetCritSkin() { return _critSkin; }
    public long GetCritBackPack() { return _critBackPack; }
    public long GetCritDp() { return _critDP; }
    public long GetCritStar() { return _critStart; }
    public long GetCritTotal() { return _critTotal; }

    //CritDMG
    
    public long GetCritDMGEquip() { return _critDMGEquip; }
    public long GetCritDMGSkin() { return _critDMGSkin; }
    public long GetCritDMGBackPack() { return _critDMGBackPack; }
    public long GetCritDMGDp() { return _critDMGDP; }
    public long GetCritDMGStar() { return _critDMGStart; }
    public long GetCritDMGTotal() { return _critDMGTotal; }

    //Stamina
    public long GetStaminaLevel() { return _staLevel = GetLevel() * 50; }
    public long GetStaminaEquip() { return _staEquip; }
    public long GetStaminaSkin() { return _staSkin; }
    public long GetStaminaBackPack() { return _staBackPack; }
    public long GetStaminaDp() { return _staDP; }
    public long GetStaminaStar() { return _staStart; }
    public long GetStaminaTotal() { return _staTotal; }
    public long GetStaminaCurrent() { return _staCurrent; }

    public string GetName() { return _namePlayer; }
    public void SetName(string names) { _namePlayer = names; }

    //Set value
    //Level
    public void SetLevel(long index) { _level = index; }
    public void SetEXPLevel() { _expLevel = GetLevel() * 100; }
    public void SetEXPCurrent(long index) { _hpCurrent = index; }
    public void PlusLevel()
    {
            while (GetExpCurrent() >= GetExpLevel())
            {
                _expCurrent = GetExpCurrent() - GetExpLevel();
                _level++;
                SetEXPLevel();
            }
        
    }
    public void PlusEXPCurrent(long index) { _expCurrent += index; }


    //HP
    public void SetHPEquip(long index) { _hpEquip = index; }
    public void SetHPSkin(long index) { _hpSkin = index; }
    public void SetHPBaclPack(long index) { _hpBackPack = index; }
    public void SetHPDP(long index) { _hpDP = index; }
    public void SetHPStar(long index) { _hpStart = index; }
    public void SetHPTotal() { _hpTotal = (GetHpLevel() + GetHpEquip() + GetHPBackPack() + GetHPDp()); if (!((GetHPStar() > 0) || (GetHpSkin() > 0))) return; _hpTotal += (_hpTotal * (GetHPStar() + GetHpSkin()) / 100); }
    public void SetHPCurrent(long index) { _hpCurrent = index; }
    public void PlusHPCurrent(long index)
    {
        if (_hpCurrent < GetHPTotal())
        {
            _hpCurrent += index;
            if(_hpCurrent> GetHPTotal())
            {
                SetHPCurrent(GetHPTotal());
            }
        }
        else { return; }

    }
    public void MinusHPCurrent(long index) 
    { 
        if (_hpCurrent > 0)
        {
            _hpCurrent -= HPMinus(index);
            if (_hpCurrent <= 0) { _hpCurrent=0; }
           
        }
        
        

    }

    public long HPMinus(long index) { return (long)(index - (index * (float)(GetDEFTotal() * 100 / _defMax) / 100)); }

    //Ki
    public void SetKIEquip(long index) { _kiEquip = index; }
    public void SetKISkin(long index) { _kiSkin = index; }
    public void SetKIBaclPack(long index) { _kiBackPack = index; }
    public void SetKIDP(long index) { _kiDP = index; }
    public void SetKIStar(long index) { _kiStart = index; }
    public void SetKITotal() { _kiTotal = GetKILevel() + GetKIEquip() + GetKiBackPack() + GetKIDp(); if (!(GetKiSkin() > 0 || GetKIStar() > 0)) return; _kiTotal += (_kiTotal * (GetKIStar() + GetKiSkin()) / 100); }
    public void SetKICurrent(long index) { _kiCurrent = index; }
    public void PlusKICurrent(long index)
    {
        if (_kiCurrent < GetKITotal())
        {
            _kiCurrent += index;
            if (_kiCurrent > GetKITotal())
            {
                SetKICurrent(GetKITotal());
            }
            
        }
        

    }
    public void MinusKICurrent(long index) 
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
    public void SetATKEquip(long index) { _atkEquip = index; }
    public void SetATKSkin(long index) { _atkSkin = index; }
    public void SetATKBaclPack(long index) { _atkBackPack = index; }
    public void SetATKDP(long index) { _atkDP = index; }
    public void SetATKStar(long index) { _atkStart = index; }
    public void SetATKTotal() { _atkTotal = GetATKLevel() + GetATKEquip() + GetATKBackPack() + GetATKDp(); if (!(GetATKSkin()>0|| (GetATKStar() > 0))) return; _atkTotal += (_atkTotal * (GetATKSkin()+ GetATKStar()) / 100); ; }

    //DEF
    public void SetDEFEquip(long index) { _defEquip = index; }
    public void SetDEFSkin(long index) { _defSkin = index; }
    public void SetDEFBaclPack(long index) { _defBackPack = index; }
    public void SetDEFDP(long index) { _defDP = index; }
    public void SetDEFStar(long index) { _defStart = index; }
    public void SetDEFTotal() { _defTotal = GetDEFLevel() + GetDEFEquip() + GetDEFBackPack() + GetDEFDp(); if (!(GetDEFSkin()>0|| (GetDEFStar() > 0))) return; _defTotal += (_defTotal * (GetDEFSkin()+ GetDEFStar()) / 100); ; }

    //Crit
    public void SetCritEquip(long index) { _critEquip = index; }
    public void SetCritSkin(long index) { _critSkin = index; }
    public void SetCritBaclPack(long index) { _critBackPack = index; }
    public void SetCritDP(long index) { _critDP = index; }
    public void SetCritStar(long index) { _critStart = index; }
    public void SetCritTotal() { _critTotal =   GetCritEquip() + GetCritBackPack() + GetCritDp() + GetCritStar()+GetCritSkin(); }
    //CritDMG
    public void SetCritDMGEquip(long index) { _critDMGEquip = index; }
    public void SetCritDMGSkin(long index) { _critDMGSkin = index; }
    public void SetCritDMGBaclPack(long index) { _critDMGBackPack = index; }
    public void SetCritDMGDP(long index) { _critDMGDP = index; }
    public void SetCritDMGStar(long index) { _critDMGStart = index; }
    public void SetCritDMGTotal() { _critDMGTotal =  GetCritDMGEquip() + GetCritDMGBackPack() + GetCritDMGDp()+ GetCritDMGSkin()+ GetCritDMGStar();  }
    //stamina
    public void SetStaEquip(long index) { _staEquip = index; }
    public void SetStaminaSkin(long index) { _staSkin = index; }
    public void SetStaBackPack(long index) { _staBackPack = index; }
    public void SetStaDP(long index) { _staDP = index; }
    public void SetStaStar(long index) { _staStart = index; }
    public void SetStaTotal() { _staTotal = GetStaminaLevel() + GetStaminaEquip() + GetStaminaBackPack() + GetStaminaDp(); if (!((GetStaminaSkin()>0|| GetStaminaStar() > 0))) return; _staTotal += (_staTotal * (GetStaminaSkin()+ GetStaminaStar()) / 100); }
    public void SetStaCurrent() { _staCurrent = GetStaminaTotal(); }
    
    public void PlusStaCurrent(long index)
    {
        if (_staCurrent < GetStaminaTotal())
        {
            _staCurrent += index;
            if (_staCurrent > GetKITotal())
            {
                SetStaCurrent();
            }

        }


    }
    public void MinusStaCurrent(long index) 
    { 
        if (_staCurrent > 0)
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
