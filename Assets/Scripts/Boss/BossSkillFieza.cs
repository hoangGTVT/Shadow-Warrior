using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSkillFieza : BossSkill
{
    public GameObject pointSkillSpecial1;
    public GameObject bulletBossFieza;
    public GameObject boss;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void SkillSpecial()
    {
        GameObject bullet = Instantiate(bulletBossFieza, pointSkillSpecial1.transform.position, Quaternion.identity);
        SkillBossFieza skillBossFieza=bullet.GetComponent<SkillBossFieza>();
        skillBossFieza.boss = boss;
    }
}
