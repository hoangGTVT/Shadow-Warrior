using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSkillBuuHan : BossSkill
{
    public GameObject pointSkillSpecial1;
    public GameObject bulletBossBuuHan;
    public int numberHeal;
    public Transform bossClone;
    private void Awake()
    {
        numberHeal = 0;
    }
    private void OnEnable()
    {
        numberHeal = 0;
    }
    void Start()
    {

    }
    private void OnDisable()
    {
        foreach (Transform child in bossClone)
        {
            
            Destroy(child.gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (bossLife.GetHPBossCurrent() <=bossLife.GetHPBoss() / 2&& numberHeal<2)
        {
            bossManager.BossHealHP(bossLife.GetHPBoss() / 2);
            numberHeal++;
        }
        
    }

    public override void SkillSpecial()
    {
        GameObject bullet = Instantiate(bulletBossBuuHan, pointSkillSpecial1.transform.position, Quaternion.identity);
    }
}
