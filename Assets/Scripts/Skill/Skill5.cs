using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill5 : SkillActivie
{
    private void Start()
    {
        base.FindPlayer();
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            string enemyname = collision.gameObject.name;
            if (enemyname == playerSelect.nameEnemy1)
            {
                Skill5Active();
                

                Destroy(gameObject,0.2f);
            }
        }
        if (collision.gameObject.CompareTag("Boss"))
        {
            string bossname = collision.gameObject.name;
            if (bossname == playerSelect.nameEnemy1)
            {
                Skill5Active2();


                Destroy(gameObject, 0.2f);
            }
        }
    }
    public void Skill5Active2()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, 5);



        // Lặp qua mỗi Collider 2D tìm được
        foreach (Collider2D collider in colliders)
        {

            BossManager bossManager = collider.GetComponent<BossManager>();
            if (bossManager != null)
            {
                base.CreateImpack(collider.gameObject);
                bossManager.BossTakeDamge(atk);

            }
        }
    }
    public void Skill5Active()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, 5);

        

        // Lặp qua mỗi Collider 2D tìm được
        foreach (Collider2D collider in colliders)
        {
            
            EnemyManager enemyManager= collider.GetComponentInParent<EnemyManager>();
            if (enemyManager != null)
            {
                base.CreateImpack(collider.gameObject);
                enemyManager.EnemyTakeDame(atk);
                
            }
        }
    }
}
