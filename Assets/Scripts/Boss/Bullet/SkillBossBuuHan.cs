using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillBossBuuHan : MonoBehaviour
{
    public float timeFly = 2;
    public float t = 0;
    public float maxScale = 3;
    public Vector3 vector3fly = new Vector3(0, 2, 0);
    private Vector3 initialScale;
    private Rigidbody2D rigidbody2d;
    public GameObject player;
    public GameObject boss;
    public GameObject[] bossPrefab;
    public BossLife bossLife;
    public int indexBoss;
    public GameObject bossClone;
    public int numberClone;
    public int numberBossCreate;

    void Start()
    {
         bossClone = GameObject.Find("BossBuuHanPrefap");
        if (bossClone != null )
        {
            numberClone = bossClone.transform.childCount;
        }
        indexBoss = Random.Range(0, 3);
        player = GameObject.Find("Player");
        boss = GameObject.Find("BossBuuHan");
       if (boss != null)
        {
            bossLife = boss.GetComponentInChildren<BossLife>();
        }
        rigidbody2d = GetComponent<Rigidbody2D>();
        initialScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        Fly();
        CreateBoss();
        if (bossClone != null)
        {
            numberClone = bossClone.transform.childCount;
        }
    }
    public void CreateBoss()
    {
        if (player != null && player.activeInHierarchy)
        {
            if (t >= maxScale - 1)
            {
                if (numberClone < numberBossCreate)
                {
                    GameObject boss1 = Instantiate(bossPrefab[indexBoss], transform.position, Quaternion.identity);
                    BossManager bossManager1 = boss1.GetComponent<BossManager>();
                    bossManager1.isTakeDamage = true;
                    boss1.transform.parent = bossClone.transform;
                }
                else
                {
                    BossManager bossManager = boss.GetComponent<BossManager>();
                    BossLife bossLife = boss.GetComponentInChildren<BossLife>();
                    bossManager.BossHealHP(bossLife.GetHPBoss() / 2);

                }
                Destroy(gameObject);
                bossLife.kiBossCurrent = 0;
            }
           
            
        }
        else if(!player.activeInHierarchy)
        {
            Destroy(gameObject);
            bossLife.kiBossCurrent = 0;
        }
    }
    public void Fly()
    {
        if(timeFly > 0)
        {

            transform.Translate(vector3fly * Time.deltaTime * 2);
            timeFly -= Time.deltaTime;
        }
        else if (timeFly <= 0)
        {
            if (t < maxScale)
            {
                t += Time.deltaTime;
                transform.localScale = Vector3.Lerp(initialScale, Vector3.one * 3, t);
            }

        }
    }


}
