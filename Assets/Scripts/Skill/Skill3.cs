using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill3 : SkillActivie
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
                enemyManager = collision.GetComponentInParent<EnemyManager>();
                enemyManager.EnemyTakeDame(atk);
                base.CreateImpack(collision.gameObject);

                Destroy(gameObject);
            }
        }
        if (collision.gameObject.CompareTag("Boss"))
        {
            string bossname=collision.gameObject.name;
            if (bossname == playerSelect.nameEnemy1)
            {
                bossManager = collision.GetComponent<BossManager>();
                bossManager.BossTakeDamge(atk);
                base.CreateImpack(collision.gameObject); Destroy(gameObject);
            }
        }
    }
}
