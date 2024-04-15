using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [Header("Scripts")]
    private Animator animator;
    public EnemyManager enemyManager;
    public EnemySO enemySO;
    public GameObject player;
    public PlayerSelect playerSelect;
    public PlayerManager playerManager;
    public GameObject _movePointLeft;
    public GameObject _movePointRight;
    public int _speedMoment;
    public int _move;
    public bool _isRight;
    public float _timeAttack;
    public int distancePlayer;

    public GameObject bullet;
    public GameObject pointbullet;
    public GameObject enemy;
    
    void Start()
    {
        enemyManager=GetComponentInParent<EnemyManager>();
        animator = GetComponent<Animator>();
        _isRight = true;
        _move = 1;
        _timeAttack=enemySO.GetTimeAttack();
    }
    public void OnEnable()
    {
        FindPlayer();

    }
    private void OnDisable()
    {
        
        Invoke("CreateEnemy", 5);
    }
    public void CreateEnemy()
    {
        enemy.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        FindPlayer();
        EnemyActive();
        if (_timeAttack > 0) { _timeAttack-=Time.deltaTime; }
    }

    protected virtual void EnemyMove()
    {
        Vector3 _moment = new Vector3(_move, 0f, 0f) * _speedMoment * Time.deltaTime;
        transform.Translate(_moment);
    }


    public void EnemyActive()
    {
        if (player != null&&animator!=null)
        {
            int distance= Mathf.Abs( (int)(player.transform.position.x-transform.position.x));
            int distanceY = Mathf.Abs((int)(player.transform.position.y - transform.position.y));
            float distance1 = (player.transform.position.x - transform.position.x);
            if (distance > distancePlayer )
            {
                EnemyMove();

                CheckMovePoint();
            }
            else if(distance <= distancePlayer && distanceY<=distancePlayer&& player.activeSelf)
            {
                if (_timeAttack <= 0)
                {
                    //animator.SetTrigger("IsAttack");
                    animator.Play("Attack");

                }
                if (distance1 < 0 && _isRight == true)
                {
                    
                    Rotate();
 
                }
                else if (distance1 > 0 && _isRight == false) { 
                    Rotate(); 
                   
                }
            }


        }
    }
    public void FindPlayer()
    {
        if (player == null)
        {
            player = GameObject.Find("Player");
        }
        else return;
        
       
    }

    public void CheckMovePoint()
    {
        if (transform.position.x >= _movePointRight.transform.position.x || transform.position.x <= _movePointLeft.transform.position.x)
        {
            Rotate();

        }
    }
    public void Rotate()
    {
        _isRight = !_isRight;
        _move *= -1;
        Vector3 currentScale = transform.localScale;
        currentScale.x *= -1;
        transform.localScale = currentScale;
        


    }

   protected virtual void EnemyAttack()
    {
        _timeAttack = enemySO.GetTimeAttack();
        GameObject bullet1= Instantiate(bullet, pointbullet.transform.position, Quaternion.identity);
        Test test = bullet1.GetComponent<Test>();
        test.SetATK(enemySO.GetAtk());

    }
    protected virtual void SetState()
    {
        
        animator.Play("Idle");

    }

    public void SetIsHurt()
    {
        if (animator != null)
        {
            animator.SetTrigger("IsHurt");
        }
        else return;
       
    }
    private void OnMouseDown()
    {
        if(player != null)
        {
            playerSelect=player.GetComponent<PlayerSelect>();

            playerSelect.SetArrow(gameObject);
        }
    }

    public void PlusEXPPlayer()
    {
        if(player != null)
        {
            playerManager=player.GetComponent<PlayerManager>();
            playerManager.PlayerTakeEXP(enemySO.GetExp());
        }
    }
    public int GetHpCurrentEnemy()
    {
        return enemyManager.hp;
    }

}
