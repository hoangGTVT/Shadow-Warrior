using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.Progress;

public class EnemyManager : MonoBehaviour
{
    public UIBarEnemy barEnemy;
    public EnemySO enemySO;
    
    public EnemyController enemyController;
    public int hp;
    public int hpMax;
    public int timeMinus;
    [Header("Text")]
    public GameObject textpopup;
    public GameObject textPoint;
    [Header("Item")]
    public GameObject item;
    public GameObject clother;
    public GameObject[] pointItem;
    private void OnEnable()
    {

        enemyController = GetComponentInChildren<EnemyController>();
        barEnemy.SetMaxHealth(enemySO.GetHp());
        hp=enemySO.GetHp();
        hpMax = enemySO.GetHp();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hp <= 0)
        {
            enemyController.PlusEXPPlayer();
            EnemyDeath();
        }
        if (Input.GetKeyDown(KeyCode.F)){

            MinusHP5S();
        }
        barEnemy.SetHealth(hp);
        
    }

    public void KillEnemy() { 
        if (hp < (hpMax / 10))
        {
            EnemyDeath();
            
        }
            
    }

    public void MinusHP5S()
    {
        timeMinus = 5;
        StartCoroutine(MinusHP());
    }

    public IEnumerator MinusHP()
    {
        while (timeMinus>0)
        {
            hp -= hpMax / 20;
            CreateTextPopUp( hpMax / 20);
            timeMinus--;
            yield return new WaitForSeconds(1f);
        }
        
    }

    public void EnemyTakeDame(int damege)
    {
        enemyController.SetIsHurt();
        hp -= damege;
        CreateTextPopUp(damege);
        
    }

    public void EnemyDeath()
    {
        gameObject.SetActive(false);
        Instantiate(item, pointItem[0].transform.position, Quaternion.identity);
        Instantiate(clother, pointItem[1].transform.position, Quaternion.identity);
    }

    public void CreateTextPopUp(int number)
    {

        GameObject pos = Instantiate(textpopup, textPoint.transform.position, Quaternion.identity);
        pos.GetComponentInChildren<TextMeshProUGUI>().text = "- "+ number;
        Destroy(pos, 0.7f);

    }
    
}
