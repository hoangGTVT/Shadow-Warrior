using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataEnemy : MonoBehaviour
{
    [Header("Enemy")]
    public EnemySO enemySO;
    public EnemyManager enemyManager;
    [Header("Boss")]
    public BossManager bossManager;
    public GameObject arrow;
    void Start()
    {
        
    }
    private void OnEnable()
    {
        arrow.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnemyTakeD(int dame)
    {
        enemyManager.EnemyTakeDame(dame);
    }

    public string Getname()
    {
        
         return enemySO.GetName();
    }

    public int GetMaxHP()
    {
       
         return enemyManager.GetMaxHealth(); 
    }
    public int GetHP()
    {
       
         return enemyManager.hp; 
    }
    public void TurnOnArrow()
    {
        arrow.SetActive(true);
    }
    public void TurnOffArrow()
    {
        arrow.SetActive(false);
    }
    //bosss
    public string GetNameBoss() { return bossManager.GetName(); }
    public int GetMaxHPBoss() { return bossManager.GetHPBoss(); }
    public int GetHPBossCurrent() { return bossManager.GetHPBossCurrent(); }
    public void BossTakeDamege(int dame)
    {
        bossManager.BossTakeDamge(dame);
    }
}
