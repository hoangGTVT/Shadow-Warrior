using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSkillCooler : BossSkill
{
    public GameObject[] pointSkillSpecial1;
    public GameObject bulletBossCooler;
    public int indexFly;
    public GameObject boss;
    private void Awake()
    {
        indexFly = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public override void SkillSpecial()
    {
        for(int i=0;i<pointSkillSpecial1.Length;i++)
        {

            GameObject bullet = Instantiate(bulletBossCooler, pointSkillSpecial1[i].transform.position, Quaternion.identity);
            SkillBossCooler skillBossCooler =bullet.GetComponent<SkillBossCooler>();
            if (skillBossCooler != null)
            {
                skillBossCooler.cooler = boss;
            }
            
            skillBossCooler.isFly = i;
        }
        
    }
}
