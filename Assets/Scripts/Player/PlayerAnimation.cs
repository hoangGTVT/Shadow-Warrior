using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator _animator;
    public SkillController skill;
    public PlayerLife playerLife;
    public PlayerSelect playerSelect;
    public GameObject player;
    public Collider2D[] colliders;
    public LayerMask layerMask;
    public int _skillID;
    public bool _isSkill;
    void Start()
    {
        _animator = GetComponent<Animator>();
        _isSkill = false;
       
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            SetStateSkill1();
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            FindEnemy();
            
        }
    }
    public void FindEnemy()
    {
        float distance1 = Mathf.Infinity;
        
          colliders = Physics2D.OverlapCircleAll(player.transform.position, 10,layerMask);
        foreach (Collider2D collider2 in colliders)
        {
            
            float distance3 = Vector2.Distance(collider2.transform.position, player.transform.position);
            if (distance1 > distance3)
            {
                distance1 = distance3;
                if (collider2.CompareTag("Enemy"))
                {
                    playerSelect.isBoss = false;
                    playerSelect.SetArrow(collider2.gameObject);
                   
                }
                else if (collider2.CompareTag("Boss"))
                {
                    playerSelect.isBoss = true;
                    playerSelect.SetBoss(collider2.gameObject);
                   
                }
            }
            
            
            
        }
    }
    public void SetStateSkill1() {_isSkill= !_isSkill; }
    public bool GetSkill() { return _isSkill; }
    public bool SetStateSkill(bool skill) { return _isSkill=skill; }
    public void SetAnimationState(string state)
    {
        
        _animator.Play(state);

    }

    public void SetAnimationState1(int state)
    {

        _animator.SetInteger("State", state);

    }

    public void AnimationSkill()
    {
        
        skill.CreateSkill(_skillID);
    }

    public void Skill1Attack()
    {
        playerSelect.PlayerCauseDamage((int)((playerLife.GetATKTotal()*(skill.GetLevelSkill(0)*10+100)))/100);
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(player.transform.position, 15);
    }
}
