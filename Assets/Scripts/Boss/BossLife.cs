using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossLife : MonoBehaviour
{
    [Header("Script")]
    public BossSO bossSO;
    public UIBoss iBoss;
    public BossManager bossManager;
    [Header("Data")]
    public string nameBoss;
    public int hpBoss;
    public int hpBossCurrent;
    public int kiBoss;
    public float kiBossCurrent;
    public int defBoss;
    public int defBossCurrent;
    public int atkBoss;
    public int atkBossCurrent;
    public int timeSkill;
    public int timeAttack;


    private void Awake()
    {

        iBoss.SetMaxHP(GetHPBoss());
        iBoss.SetMaxKI(GetKIBoss());
        GetHPBoss();
        GetKIBoss();
        GetatkBoss();
        GetdefBoss();
        GetNameBoss();
        GetTimeSkill();
        hpBossCurrent = hpBoss;
        defBossCurrent = defBoss;
        kiBossCurrent = 0;
        atkBossCurrent = atkBoss;
        iBoss.SetKI((int)GetkiBossCurrent());
       
    }
    private void OnEnable()
    {
        iBoss.SetMaxHP(GetHPBoss());
        iBoss.SetMaxKI(GetKIBoss());
        GetHPBoss();
        GetKIBoss();
        GetatkBoss();
        GetdefBoss();
        GetNameBoss();
        GetTimeSkill();
        hpBossCurrent = hpBoss;
        defBossCurrent = defBoss;
        kiBossCurrent = 0;
        atkBossCurrent = atkBoss;
        iBoss.SetKI((int)GetkiBossCurrent());
        hpBossCurrent =hpBoss;
    }
    private void Update()
    {
        if (kiBossCurrent < kiBoss&& bossManager.isTakeDamage==true)
        {
            PlusKiCurrent(5*Time.deltaTime);
        }
        iBoss.SetHp(GetHPBossCurrent());
        iBoss.SetKI((int)GetkiBossCurrent());
    }
   public void setUIHP()
    {
        iBoss.SetMaxHP(hpBoss);
        iBoss.SetHp(GetHPBossCurrent());
    }
    //Getvalue
    public string GetNameBoss() { return nameBoss= bossSO.GetName(); }
    public int GetHPBoss() { return hpBoss=bossSO.GetHp(); }
    public int GetKIBoss() {  return kiBoss=bossSO.GetKi(); }
    public int GetdefBoss() { return defBoss= bossSO.GetDef(); }
    public int GetatkBoss() { return atkBoss = bossSO.GetATK(); }
   public int GetTimeSkill() { return  timeSkill=bossSO.GetTime(); }
    public int GetHPBossCurrent() { return hpBossCurrent; }
    public float GetkiBossCurrent() { return kiBossCurrent; }
    public int GetdefBossCurrent() { return defBossCurrent; }
    public int GetatkBossCurrent() { return atkBossCurrent; }
    public int GetTimeAttack() { return timeAttack = bossSO.GetTimeAttack(); }
   
    //Setvalue
    public void PlusHpCurrent(int index) {
        if (hpBossCurrent < hpBoss)
        {
            hpBossCurrent += index;
            if (hpBossCurrent > hpBoss)
            {
                hpBossCurrent = hpBoss;
            }
        }
        else return;
       
    }
    public void MinusHpCurrent(int index) {
        if (hpBossCurrent > 0)
        {
            hpBossCurrent -= index;
            if (hpBossCurrent <= 0)
            {
                hpBossCurrent = 0;
            }
        }
       
    }
    public void PlusKiCurrent(float index)
    {
        if (kiBossCurrent < hpBoss)
        {
            kiBossCurrent += index;
            if (kiBossCurrent > kiBoss)
            {
                kiBossCurrent = kiBoss;
            }
        }
        else return;

    }
    
    

    public void PlusDefCurrent(int index)
    {
        defBossCurrent += index;

    }
    public void PlusAtkCurrent(int index)
    {
        atkBossCurrent += index;

    }
    

}
