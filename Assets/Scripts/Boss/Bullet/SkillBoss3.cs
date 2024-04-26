using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillBoss3 : MonoBehaviour
{
    public GameObject player;
    public int atk;
    public float timeattack;
    public Rigidbody2D rb;
    void Start()
    {
        player = GameObject.Find("Player");
        timeattack = 0;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
            if (player != null&& player.activeInHierarchy)
            {
                Vector3 direction = (player.transform.position - transform.position).normalized;
                rb.velocity = direction * 20;
            }
            else Destroy(gameObject);
            
        
       
    }

    public void SetATK(int atk)
    {
        this.atk = atk;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player01"))
        {
            if (collision.gameObject.activeInHierarchy)
            {
                PlayerManager playerManager=player.GetComponent<PlayerManager>();
                playerManager.PlayerTakeDamage(atk);
                GameObject boss = GameObject.Find("BossFieza");
                
                Destroy(gameObject,0.1f);
            }
            else
            {
                
                Destroy(gameObject,0.1f);
            }
        }
    }
}
