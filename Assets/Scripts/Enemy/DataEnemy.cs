using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataEnemy : MonoBehaviour
{
    public EnemySO enemySO;
    public BossSO bossSO;
    public bool isBoss;
    public EnemyManager enemyManager;
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
        if (isBoss==true) { return bossSO.GetName(); }
        else { return enemySO.GetName(); }
    }

    public int GetMaxHP()
    {
        if (isBoss == true) { return bossSO.GetHp(); }
        else { return enemySO.GetHp(); }
    }
    public int GetHP()
    {
        if (isBoss == true) { return bossManager.hp; }
        else { return enemyManager.hp; }
    }
    public void TurnOnArrow()
    {
        arrow.SetActive(true);
    }
    public void TurnOffArrow()
    {
        arrow.SetActive(false);
    }
}
