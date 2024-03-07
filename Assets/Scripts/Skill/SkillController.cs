using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillController : MonoBehaviour
{
    [Header("Skill")]
    public GameObject[] _skill;
    public int _skillIndex;
    public Transform _skillPoint;
    public PlayerMoment playerMoment;
    public bool _isRight=true;
    public PlayerAnimation playerAnimation;
    void Start()
    {
        _skillIndex = 0;
        playerMoment=GetComponentInParent<PlayerMoment>();
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckInPut();
        if (Input.GetKeyDown(KeyCode.Y))
        {
            CreateSkill(2);
            
        }


    }

    public void CreateSkill(int skill)
    {

        
        GameObject gameObject = Instantiate(_skill[skill], _skillPoint.position, Quaternion.identity);
        Rigidbody2D rigidbody = gameObject.GetComponent<Rigidbody2D>();
        Vector3 currentScale = gameObject.transform.localScale;
        if (playerMoment._isRight == true)
        {
            rigidbody.velocity = transform.right * 25.0f;
        }
        else
        {
            
            currentScale.x *= -1;
            gameObject.transform.localScale = currentScale;
            rigidbody.velocity = transform.right * -25.0f;
        }
        
        
    }

    public void CheckInPut()
    {
        if (InputManager.instance.CheckInput() is int)
        {
            int index = (int)InputManager.instance.CheckInput();
            if (index > 1)
            {
                
                playerAnimation.SetAnimationState("Skill");
              playerAnimation._skillID = index;


            }
            else if (index == 1)
            {
                _skill[1].SetActive(true);
            }


        }

        if(InputManager.instance.CheckInput() is string)
        {
            string index=(string)InputManager.instance.CheckInput();
            if (index == "J")
            {
                playerAnimation.SetAnimationState("Attack");
            }
           
        }


    }

    public void SetSkillIndex(int index)
    {
        _skillIndex=index;
    }

    public void Skill1()
    {
        playerAnimation.SetAnimationState("Attack");
    }

    public void SetSkill(int index)
    {
        if (index > 1)
        {
            playerAnimation.SetAnimationState("Skill");
            playerAnimation._skillID = index;
        }else if (index == 1)
        {
            _skill[1].SetActive(true);
        }
       
    }
    

   
}
