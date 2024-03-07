using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneEnemy : MonoBehaviour
{
    public Rigidbody2D _rigidbody2D;
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        
        _rigidbody2D.AddForce(Vector2.up * 15, ForceMode2D.Impulse);

         
        _rigidbody2D.gravityScale = 5;
       
    }
    private void Update()
    {
        Destroy(gameObject, 1);
    }



}
