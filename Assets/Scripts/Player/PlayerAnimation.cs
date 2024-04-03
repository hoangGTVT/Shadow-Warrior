using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator _animator;
    public SkillController skill;
    public int _skillID;
    public bool _isSkill;
    void Start()
    {
        _animator = GetComponent<Animator>();
        _isSkill = false;
       
    }
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

}
