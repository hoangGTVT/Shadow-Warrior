using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BossMoment : MonoBehaviour
{
    public GameObject player;
    public GameObject MainBoss;
    public BossAnimator animator;
    public Rigidbody2D rigidbody2D1;
    public bool _isRight;
    public int _move;
    public int distance;
    public int _speedMoment;
    [SerializeField] private LayerMask _jumpableGround;
    public BoxCollider2D _boxCollider;
    private void Awake()
    {
        _boxCollider = GetComponentInParent<BoxCollider2D>();
        rigidbody2D1 = GetComponentInParent<Rigidbody2D>();
        _move = 1;
        _speedMoment = 8;
        _isRight = true;
        FindPlayer();
        BossRorate();
    }
    void Start()
    {
        
        
    }
    private void OnEnable()
    {

        

    }

    // Update is called once per frame
    void Update()
    {
        
        BossRorate();
    }

    public void BossRorate()
    {
        distance = (int)(player.transform.position.x - transform.position.x);
        if (distance < 0 && _isRight == true)
        {
            Rotate();

        }
        else if (distance > 0 && _isRight == false)
        {
            Rotate();

        }
    }
    
    public void BossIdel()
    {
        animator.SetAnimationBoss("Idle");
    }
    public void BossMove()
    {
        animator.SetAnimationBoss("Run");
        Vector3 _moment = new Vector3(_move, 0f, 0f) * _speedMoment * Time.deltaTime;
        transform.Translate(_moment);
    }
    

    public void FindPlayer()
    {
        player = GameObject.Find("Player");
    }
    public void Rotate()
    {
        _isRight = !_isRight;
        _move *= -1;
        Vector3 currentScale = MainBoss.transform.localScale;
        currentScale.x *= -1;
        MainBoss.transform.localScale = currentScale;



    }
    public bool IsGrounded()
    {
        return Physics2D.BoxCast(_boxCollider.bounds.center, _boxCollider.bounds.size, 0f, Vector2.down, .3f, _jumpableGround);
    }
}
