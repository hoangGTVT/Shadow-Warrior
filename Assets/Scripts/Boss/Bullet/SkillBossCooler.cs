using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SkillBossCooler : MonoBehaviour
{
    public GameObject player;
    public GameObject cooler;
    public BossManager bossManager;
    public BossSkillCooler skillCooler;
    private Rigidbody2D rigidbody2d;
    public BossLife bossLife;
    public int isFly;
    void Start()
    {
        rigidbody2d=GetComponent<Rigidbody2D>();
        player = GameObject.Find("Player");
       
        if (cooler != null)
        {
            bossManager = cooler.GetComponent<BossManager>();
            skillCooler = cooler.GetComponentInChildren<BossSkillCooler>();
            bossLife=cooler.GetComponentInChildren<BossLife>();
        }
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
       
        
        if (player != null)
        {
            if (player.activeInHierarchy)
            {
                if (isFly == skillCooler.indexFly)
                {
                    Vector3 direction = (player.transform.position - transform.position).normalized;
                    rigidbody2d.velocity = direction * 15;
                }
                
                    
                
            }
            else
            {
                Destroy(gameObject);
                bossLife.kiBossCurrent = 0;
            }
        }
        
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player01"))
        {
            PlayerManager playerManager=player.GetComponent<PlayerManager>();
            PlayerLife playerLife=player.GetComponentInChildren<PlayerLife>();
            if (playerManager != null)
            {
                skillCooler.indexFly++;
                playerManager.PlayerTakeDamage((int)playerLife.GetHPTotal() / 10);
                Destroy(gameObject);
                if (isFly == 4)
                {
                    
                    bossLife.kiBossCurrent = 0;
                }

                if (skillCooler.indexFly > 4)
                {
                    skillCooler.indexFly = 0;
                }
                
            }
            



        }
    }
}
