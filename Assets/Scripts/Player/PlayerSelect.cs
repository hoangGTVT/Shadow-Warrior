using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerSelect : MonoBehaviour
{
    
    public DataEnemy dataEnemy;
    public DataEnemy dataEnemy1;
    public GameObject a;
    public GameObject b;
    public GameObject infoEnemy;
    public TextMeshProUGUI nameEnemy;
    public TextMeshProUGUI maxHP;
    public TextMeshProUGUI currentHP;
    public string nameEnemy1;
    public float time1;
    public int distancePlayer;

    public GameObject GetA()
    {
        return a;
    }
    public void SetArrow(GameObject gameObject1)
    {
        if (a == null)
        {
            a= gameObject1;
            dataEnemy= gameObject1.GetComponentInParent<DataEnemy>();
            dataEnemy.TurnOnArrow();
            nameEnemy1= a.name;
            infoEnemy.SetActive(true);
            Invoke("TurnOff", 5);
           
        }else if(a!=null)
        {
            dataEnemy.TurnOffArrow();
            a = null;
            dataEnemy = null;
            infoEnemy.SetActive(false);

        }
    }

    public void PlayerCauseDamage(int dame)
    {
        if (dataEnemy != null)
        {
            dataEnemy.EnemyTakeD(dame);
        }
    }

    private void Update()
    {
        if(a!= null)
        {
            if (!a.activeInHierarchy)
            {
                a = null; dataEnemy = null;
            }
        }
       
        if (dataEnemy != null)
        {
            distancePlayer=(int)Mathf.Abs(transform.position.x-a.transform.position.x);
        }
        
        ShowInfoEnemy();
        if (dataEnemy != null)
        {
            if (dataEnemy.GetHP() <= 0)
            {


                /*dataEnemy = null;*/ infoEnemy.SetActive(false);

            }
        }
        else return;
        
        
    }

    public void ShowInfoEnemy()
    {
        if (dataEnemy != null)
        {
            nameEnemy.text = dataEnemy  .enemySO.GetName();
            maxHP.text = "/" + dataEnemy.enemySO.GetHp().ToString("#,#");
            currentHP.text = dataEnemy.GetHP().ToString("#,#");
        }
    }

    public void TurnOff()
    { 
            infoEnemy.SetActive(false);

    }
}
