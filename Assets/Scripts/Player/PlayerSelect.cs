using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerSelect : MonoBehaviour
{
    
    public DataEnemy dataEnemy;
    public DataEnemy dataEnemy1;
    public GameObject a;
    public GameObject b;
    [Header("Boss")]
    public bool isBoss;
    public GameObject infoEnemy;
    public TextMeshProUGUI nameEnemy;
    public TextMeshProUGUI maxHP;
    public TextMeshProUGUI currentHP;
    public string nameEnemy1;
    public float time1;
    public int distancePlayer;
    public int distancePlayerY;
    public GameObject impact;

    public GameObject GetA()
    {
        return a;
    }
    public int GetPositionx()
    {
        return (int)(a.transform.position.x);
    }
    public void SetBoss(GameObject gameObject)
    {
        a= gameObject;
        dataEnemy = gameObject.GetComponent<DataEnemy>();
        nameEnemy1 = a.name;
        dataEnemy.TurnOnArrow();
        infoEnemy.SetActive(true);
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
        if (dataEnemy != null )
        {
            if (isBoss == false)
            {
                dataEnemy.EnemyTakeD(dame);
                GameObject imp = Instantiate(impact, a.transform.position, Quaternion.identity);
                Destroy(imp, 0.2f);
            }
            else
            {
                dataEnemy.BossTakeDamege(dame);
                GameObject imp = Instantiate(impact, a.transform.position, Quaternion.identity);
                Destroy(imp, 0.2f);

            }
           
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
            distancePlayerY= (int)Mathf.Abs(transform.position.y - a.transform.position.y);
        }
        
        ShowInfoEnemy();
        if (dataEnemy != null&& isBoss==false)
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
        if (dataEnemy != null&& isBoss==false)
        {
            nameEnemy.text = dataEnemy  .enemySO.GetName();
            maxHP.text = "/" + dataEnemy.GetMaxHP().ToString("#,#");
            currentHP.text = dataEnemy.GetHP().ToString("#,#");
        }
        else if(dataEnemy !=null && isBoss==true)
        {
            nameEnemy.text = dataEnemy.GetNameBoss();
            maxHP.text = "/" + dataEnemy.GetMaxHPBoss().ToString("#,#");
            currentHP.text = dataEnemy.GetHPBossCurrent().ToString("#,#");
        }
    }

    public void TurnOff()
    { 
            infoEnemy.SetActive(false);

    }

    
}
