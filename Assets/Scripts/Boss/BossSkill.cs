using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSkill : MonoBehaviour
{
    [Header("Script")]
    public BossLife bossLife;
    public BossManager bossManager;
    public BossController bossController;
    public GameObject bulletpointskill1;
    public GameObject bulletPrefabskill1;
    


    // Update is called once per frame
    void Update()
    {
        
    }
    public void Attack()
    {
        bossManager.PlayerCauseDame();
    }

    public void SetTimeAttack()
    {
        bossController.timeAttack = bossLife.timeAttack-0.5f;
    }
    public void SetTimeSkill()
    {
        bossController.timeSkill = bossLife.timeSkill;
    }
    public void SetKiSkillSpecial()
    {
        bossLife.kiBossCurrent = 0;
    }
   
    public virtual void SkillSpecial()
    {
        


    }
    public virtual void Skill4()
    {



    }
    public void Skill1()
    {
        GameObject bullet = Instantiate(bulletPrefabskill1, bulletpointskill1.transform.position, Quaternion.identity);
        SkillBoss3 skillBoss3 = bullet.GetComponent<SkillBoss3>();
        AudioManager.instance.Play("Skill3");
        skillBoss3.SetATK(bossLife.GetatkBossCurrent()*3);


    }
}
