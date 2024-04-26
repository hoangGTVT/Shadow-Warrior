using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAnimator : MonoBehaviour
{
    public Animator animator;

    private void OnEnable()
    {
       
        animator.StopPlayback();
    }
    void Start()
    {
       
        
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            SetAnimationBoss("Skill2");
        }
    }
    public void SetAnimationBoss(string str)
    {
        animator.Play(str);
    }
    
    

}
