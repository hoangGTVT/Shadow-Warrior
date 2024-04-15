using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public GameObject player;
    public Rigidbody2D rb;
    public PlayerManager manager;
    public int atk;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.Find("Player");
    }

    public void SetATK(int index) { atk = index; }

    // Update is called once per frame
    void Update()
    {
        if (player != null) {
            if (player.activeInHierarchy)
            {
                Vector3 direction = (player.transform.position - transform.position).normalized;
                rb.velocity = direction * 8;
            }
            else
            {
                Destroy(gameObject);
            }
        }else Destroy(gameObject);
        
       

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player01")) { 
        
            manager=collision.GetComponent<PlayerManager>();
            manager.PlayerTakeDamage(atk);
            Destroy(gameObject);
        }
    }
}
