
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;


public class EnemyManager : MonoBehaviour
{
    public UIBarEnemy barEnemy;
    public EnemySO enemySO;
    
    public EnemyController enemyController;
    public int hp;
    public int hpMax;
    public int timeMinus;
    public int atk;
    public int transformRate;
    public bool istransform;
    public GameObject aura;
    [Header("Text")]
    public GameObject[] textpopup;
    public GameObject textPoint;
    [Header("Item")]
    public GameObject goldItem;
    public GameObject diamonItem;
    public GameObject[] item;
    public GameObject[] skinitem;
    public GameObject[] clotherItem;
    public GameObject[] pointItem;
    [Header("item drop rate")]
    public bool canDropSkin;
    public bool candropClother;
    public int goldDropRate;
    public int diamondDropRate;
    public int itemDropRate;
    public int skinDropRate;
    public int clotherDropRate;
    public int maxItem;
    public int maxSkin;
    public int maxClother;
    [Header("Random")]
    public int skin;
    public int clother;
    public int gold;
    public int diamond;
    public int item1;
    public int indexItem;
    public int indexSkin;
    public int indexclother;
    private void OnEnable()
    {
        int tf= Random.Range(1, 101);
        if (tf <= transformRate)
        {
            hp = enemySO.GetHp()*5;
            hpMax = enemySO.GetHp()*5;
            barEnemy.SetMaxHealth(hp);
            atk=enemySO.GetAtk()*5;
            istransform = true;

        }
        else
        {
            hp = enemySO.GetHp();
            hpMax = enemySO.GetHp();
            barEnemy.SetMaxHealth(hp);
            atk = enemySO.GetAtk();
            istransform = false;
        }
        skin = Random.Range(1, 101);
        clother = Random.Range(1, 101);
        gold = Random.Range(1, 101);
         diamond= Random.Range(1, 101);
         item1= Random.Range(1, 101);
        indexItem= Random.Range(0,maxItem);
        indexSkin= Random.Range(0,maxSkin);
        indexclother= Random.Range(0, maxClother);
        enemyController = GetComponentInChildren<EnemyController>();
        
    }

    
    void Start()
    {
       
    }
    private void OnDisable()
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
        
        barEnemy.SetHealth(hp);
        if (istransform == true)
        {
            aura.SetActive(true);
        }else aura.SetActive(false);
    }

    public int GetAtkEnemy() { return atk; }
    public int GetMaxHealth() { return hpMax; }

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
            if (enemyController.GetIsCrit() == true)
            {
                hp -= ((hpMax / 20) * (100 + enemyController.GetCritDMGPlayerToEnemy())) / 100;
                CreateTextPopUp1(((hpMax / 20) * (100 + enemyController.GetCritDMGPlayerToEnemy())) / 100);
                timeMinus--;
            }
            else
            {
                hp -= hpMax / 20; 
                CreateTextPopUp(hpMax/20);
                timeMinus--;
            }
                
            yield return new WaitForSeconds(1f);
        }
        
    }

    public void EnemyTakeDame(int damege)
    {
        if (enemyController.GetIsCrit() == true)
        {
            enemyController.SetIsHurt();
            hp -= (damege*(100+enemyController.GetCritDMGPlayerToEnemy()))/100;
            CreateTextPopUp1((damege * (100 + enemyController.GetCritDMGPlayerToEnemy())) / 100);
            enemyController.canAttack = true;
        }
        else
        {
            enemyController.SetIsHurt();
            hp -= damege;
            CreateTextPopUp(damege);
            enemyController.canAttack = true;
        }
        
        
    }

    public void EnemyDeath()
    {
        gameObject.SetActive(false);
        CreateItem();
    }

    public void CreateItem()
    {
        if (gold <= goldDropRate)
        {
            Instantiate(goldItem, pointItem[0].transform.position, Quaternion.identity);
        }
        if (diamond <= diamondDropRate)
        {
            Instantiate(diamonItem, pointItem[1].transform.position, Quaternion.identity);
        }
        if (item1 <= itemDropRate)
        {
            Instantiate(item[indexItem], pointItem[2].transform.position, Quaternion.identity);
        }

        if(skin<=skinDropRate&& canDropSkin == true)
        {
            Instantiate(skinitem[indexSkin], pointItem[3].transform.position,Quaternion.identity);
        }

        if(clother<=clotherDropRate&& candropClother == true)
        {
            Instantiate(clotherItem[indexclother], pointItem[4].transform.position,Quaternion.identity) ;
        }
    }

    public void CreateTextPopUp(int number)
    {

        GameObject pos = Instantiate(textpopup[0], textPoint.transform.position, Quaternion.identity);
        pos.GetComponentInChildren<TextMeshProUGUI>().text = "- "+ number;
        Destroy(pos, 0.7f);

    }
    public void CreateTextPopUp1(int number)
    {

        GameObject pos = Instantiate(textpopup[1], textPoint.transform.position, Quaternion.identity);
        pos.GetComponentInChildren<TextMeshProUGUI>().text = "Chí Mạng " + "- " + number;
        Destroy(pos, 0.7f);

    }

}
