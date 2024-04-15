using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using TMPro;

using UnityEngine;
using UnityEngine.UI;

public class SkillController : MonoBehaviour
{
    [Header("Skill")]
    public GameObject[] _skill;
    public int _skillIndex;
    public Transform _skillPoint;
    public bool _isRight = true;
    public GameObject[] tb;
    public bool isSkill2;

    [Header("Scripts")]
    public PlayerMoment playerMoment;
    public PlayerAnimation playerAnimation;
    public PlayerSelect playerSelect;
    public UIBar uibar;
    public PlayerManager playerManager;
    public PlayerLife playerLife;
    [Header("DataSkill")]
    public SkillSO[] skillsos;
    public float timeSkill;
    public int timeoffSkill2;
    //
    
    
   
    public int[] levelSkill;
    
    public const int levelmax = 7;
    //TimeCoolDow
    public float[] timecooldowSkill;
    

    //GetValue
    
    //TimeCoolDow
    public float GetTimeCoolDowLevel(int index) { return (float)Math.Round(timecooldowSkill[index], 1); }
    
    public void GetTimeCool(int index)
    {
        timeSkill = GetTimeCoolDowLevel(index);
    }

    
    //level
    public int GetLevelSkill(int index) { return levelSkill[index]; }
   
    //skill
    public string GetSkillName(int index) { return  skillsos[index].GetName(); }
    public string GetSkillDes(int index) { return  skillsos[index].GetDescription(); }
    public int GetCurrentDMG(int index) { return  skillsos[index].GetCurrentDMG() * GetLevelSkill(index) ; }
    public int GetPercentDMG(int index) { return  skillsos[index].GetPercentDMG() + GetLevelSkill(index) *2; ; }
    public float GetTimeSkill(int index) { 
        if (index > 0) {
            return skillsos[index].GetTime() - levelSkill[index];
        } else return skillsos[0].GetTime();
    }
    public int GetKISkill(int index) {
        if (index == 0)
        {
            return skillsos[index].GetEnergy();
        }else
        return  skillsos[index].GetEnergy() + GetLevelSkill(index) * 10;
    }


    //SetValue
    //TimeCoolDown
    public void SetTimeCoolDown(int index)
    {
        timecooldowSkill[index] = GetTimeSkill(index);
        
    }
    //Level
    

    //PluslevelSkill
    public void PlusLevel(int index)
    {
        if (levelSkill[index] < levelmax) { levelSkill[index]++; } else tb[2].SetActive(true);
        
    }


    void Start()
    {
        _skillIndex = 0;
        playerMoment = GetComponentInParent<PlayerMoment>();
        timeoffSkill2=GetLevelSkill(1)+5;
        isSkill2 = false;

    }

    // Update is called once per frame
    void Update()
    {
        timeoffSkill2 = GetLevelSkill(1)+5;
        CheckInPut();
        MinusTime();
        SetValue();
        
    }
   
    public void MinusTime()
    {
        for(int i = 0; i <= 5; i++)
        {
            if (timecooldowSkill[i] > 0)
            {
                timecooldowSkill[i] -= (5 * Time.deltaTime);
            }
        }
        
       
    }

    public void SetValue()
    {
        uibar.setValue(timecooldowSkill[0], 0);
        uibar.setValue(timecooldowSkill[1], 1);
        uibar.setValue(timecooldowSkill[2], 2);
        uibar.setValue(timecooldowSkill[3], 3);
        uibar.setValue(timecooldowSkill[4], 4);
        uibar.setValue(timecooldowSkill[5], 5);
        
    }

    public void CreateSkill(int skill)
    {
        SetTimeCoolDown(skill);
        GetTimeCool(skill);
        uibar.setMaxValue(timeSkill, skill);
        playerManager.MinusKI(GetKISkill(skill));
        GameObject gameObject11 = Instantiate(_skill[skill], _skillPoint.position, Quaternion.identity);
        Rigidbody2D rigidbody = gameObject11.GetComponent<Rigidbody2D>();
        Vector3 currentScale = gameObject11.transform.localScale;
        Destroy(gameObject11, 0.5f);
        playerAnimation.SetStateSkill(false);

        if (playerMoment._isRight == true)
        {
            rigidbody.velocity = transform.right * 15;

        }
        else
        {

            currentScale.x *= -1;
            gameObject11.transform.localScale = currentScale;
            rigidbody.velocity = transform.right * -15;
        }
    }

    public void CheckInPut()
    {

        if (InputManager.instance.CheckInput() is int)
        {
            int index = (int)InputManager.instance.CheckInput();
            GetTimeCool(index);
            if(playerSelect.a != null)
            {
                if (playerLife.GetKICurrent() >= GetKISkill(index) && playerLife.GetStaminaCurrent() > 0)
                {
                    if (timeSkill <= 0)
                    {
                        if (index > 1 && playerSelect.distancePlayer <= 5)
                        {
                            playerManager.MinusStamina(playerLife.GetStaminaTotal() / 50);
                            playerAnimation.SetStateSkill(true);
                            playerAnimation.SetAnimationState("Skill");
                            playerAnimation._skillID = index;


                        }
                        else if (index == 1)
                        {
                            playerManager.MinusStamina(playerLife.GetStaminaTotal() / 50);
                            SetTimeCoolDown(1);
                            GetTimeCool(1);
                            uibar.setMaxValue(timeSkill, 1);
                            playerManager.MinusKI(GetKISkill(1));
                            Invoke("TurnOffSkill2", timeoffSkill2);
                            isSkill2 = true;
                            _skill[1].SetActive(true);
                        }
                    }
                    else TurnOnTB(0);
                }

                else TurnOnTB(1);
            }else TurnOnTB(3);
            



        }

        if (InputManager.instance.CheckInput() is string)
        {
            string index = (string)InputManager.instance.CheckInput();
            if (index == "J")
            {

                GetTimeCool(0);
                if (playerSelect.a != null && playerSelect.distancePlayer <= 2)
                {
                    if (playerLife.GetKICurrent() >= GetKISkill(0) && playerLife.GetStaminaCurrent() > 0 )
                    {
                        if (timeSkill <= 0)
                        {
                            playerManager.MinusStamina(playerLife.GetStaminaTotal() / 50);
                            SetTimeCoolDown(0);
                            GetTimeCool(0);
                            uibar.setMaxValue(timeSkill, 0);
                            playerAnimation.SetStateSkill(true);
                            playerManager.MinusKI(GetKISkill(0));
                            playerAnimation.SetAnimationState("Attack");
                            playerAnimation.SetStateSkill(false);

                        }
                        else return;
                    }
                    else TurnOnTB(1);
                }
                else TurnOnTB(3);
                

            }

        }


    }

    public void SetSkillIndex(int index)
    {
        _skillIndex = index;
    }

    public void Skill1()
    {
        GetTimeCool(0);
        if (playerSelect.a != null && playerSelect.distancePlayer <= 2)
        {
            if (playerLife.GetKICurrent() >= GetKISkill(0) && playerLife.GetStaminaCurrent() > 0)
            {
                if (timeSkill <= 0)
                {
                    playerManager.MinusStamina(playerLife.GetStaminaTotal() / 50);
                    playerAnimation.SetStateSkill(true);
                    SetTimeCoolDown(0);
                    GetTimeCool(0);
                    uibar.setMaxValue(timeSkill, 0);
                    playerAnimation.SetAnimationState("Attack");
                    playerManager.MinusKI(GetKISkill(0));
                    playerAnimation.SetStateSkill(false);
                }
                else return;
            }
            else TurnOnTB(1);
        }
        else TurnOnTB(3);

    }

    public void SetSkill(int index)
    {
        GetTimeCool(index);
        if(playerSelect.a != null ) {
            if (playerLife.GetKICurrent() >= GetKISkill(index) && playerLife.GetStaminaCurrent() > 0)
            {
                if (timeSkill <= 0)
                {
                    if (index > 1 && playerSelect.distancePlayer <= 5)
                    {
                        playerManager.MinusStamina(playerLife.GetStaminaTotal() / 50);
                        playerAnimation.SetAnimationState("Skill");
                        playerAnimation._skillID = index;
                        playerAnimation.SetStateSkill(true);
                    }
                    else if (index == 1)
                    {
                        playerManager.MinusStamina(playerLife.GetStaminaTotal() / 50);
                        SetTimeCoolDown(1);
                        GetTimeCool(1);
                        uibar.setMaxValue(timeSkill, 1);
                        playerManager.MinusKI(GetKISkill(1));
                        _skill[1].SetActive(true);
                        isSkill2=true;
                        Invoke("TurnOffSkill2",timeoffSkill2);
                    }
                }
                else TurnOnTB(0);
            }

            else TurnOnTB(1);
        }
        else TurnOnTB(3);



    }

    public void TurnOffSkill2()
    {
        _skill[1].SetActive(false);
        isSkill2 = false;
    }

    public void TurnOnTB(int index) {
        GameObject tt = Instantiate(tb[index], transform.position, Quaternion.identity);
        Destroy(tt,0.7f);
    }


}
