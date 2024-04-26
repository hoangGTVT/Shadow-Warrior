using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossController : MonoBehaviour
{
    [Header("Script")]
    public BossLife bossLife;
    public BossManager bossManager;
    public BossMoment bossMoment;
    public BossAnimator bossAnimator;
    public GameObject player;
    public float distanceX;
    public float distanceY;
    public float timeAttack;
    public float timeSkill;
    public bool isSkill;
    public bool canSkill4;
    private void Awake()
    {
        canSkill4 = false;
        isSkill = false;
        timeAttack =bossLife.GetTimeAttack();
        timeSkill=bossLife.GetTimeSkill();
    }
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (bossManager.isTakeDamage == true)
        {
            timeAttack -= Time.deltaTime;
            timeSkill -= Time.deltaTime;
        }
        
        FindPlayer();
        CheckDistanceX();
        CheckDistanceY();
        BossActive();
    }
    public void FindPlayer()
    {
        player = GameObject.Find("Player");
    }
    public float CheckDistanceX()
    {
        if (player != null && player.activeInHierarchy)
        {
            return distanceX = Mathf.Abs((int)(player.transform.position.x - transform.position.x));
        }
        else return 0;
       
        
    }
    public float CheckDistanceY()
    {
        if (player != null && player.activeInHierarchy)
        {
            return distanceY = Mathf.Abs((int)(player.transform.position.y - transform.position.y));
        }else return 0;
            

    }
    public void BossActive()
    {
        if (player != null && player.activeInHierarchy && canSkill4==false)
        {
            if (bossManager.isTakeDamage == true)
            {
                if (bossLife.GetkiBossCurrent() >= bossLife.GetKIBoss())
                {
                    bossAnimator.SetAnimationBoss("Skill2");
                }
                else 
                {
                    if (timeSkill <= 0)
                    {
                       
                        bossAnimator.SetAnimationBoss("Skill");
                    }
                    else
                    {
                        if (distanceX > 1)
                        {
                            bossMoment.BossMove();
                        }
                        else
                        {
                            if (timeAttack <= 0 && distanceY < 3)
                            {
                                bossAnimator.SetAnimationBoss("Attack");

                            }
                            else { bossAnimator.SetAnimationBoss("Idle"); }

                        }
                    }
                }
            }
        }
           
        
        
            
            
        
    }
    
}

