using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillBossBuu : MonoBehaviour
{
    public float timeFly = 2;
    public float t = 0;
    public float maxScale = 3;
    public Vector3 vector3fly = new Vector3(0,2,0);
    private Vector3 initialScale;
    private Rigidbody2D rigidbody2d;
    public GameObject player;
    public GameObject boss;
    public GameObject camera1;
    public BossManager bossManager;
    public BossLife bossLife;
    void Start()
    {
        player = GameObject.Find("Player");
       if(boss != null)
        {
            bossManager = boss.GetComponent<BossManager>();
            bossLife = boss.GetComponentInChildren<BossLife>();
        }
        camera1 = GameObject.Find("Main Camera");
        rigidbody2d = GetComponent<Rigidbody2D>();
        initialScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeFly > 0)
        {
           
            transform.Translate(vector3fly * Time.deltaTime*2);
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
        if(player != null && player.activeInHierarchy)
        {
            if (t >= maxScale - 1)
            {
                Vector3 direction = (player.transform.position - transform.position).normalized;
                rigidbody2d.velocity = direction * 15;
            }
        }
        else if (!player.activeInHierarchy)
        {
            Destroy(gameObject);
            bossLife.kiBossCurrent = 0;
        }
        


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player01"))
        {
           
            bossLife.kiBossCurrent = 0;
            
            bossManager.BlastActive();
            PlayerManager playerManager=player.GetComponent<PlayerManager>();
            PlayerLife playerLife = player.GetComponentInChildren <PlayerLife>();
            playerManager.PlayerTakeDamage((int)playerLife.GetHPTotal() / 2);
            Vector3 vector31 = new Vector3(2, 0, 0);
            camera1.transform.position = camera1.transform.position + vector31;
            Destroy(gameObject);
            
        }
    }
}
