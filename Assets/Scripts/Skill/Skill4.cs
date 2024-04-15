using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill4 : SkillActivie
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
                enemyManager.KillEnemy();
                base.CreateImpack(collision.gameObject);
               
                Destroy(gameObject);
            }
        }
    }
}
