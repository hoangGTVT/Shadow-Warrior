using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using TMPro;
using UnityEditor.Experimental.GraphView;
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
     

    [Header("Scripts")]
    public PlayerMoment playerMoment;
    public PlayerAnimation playerAnimation;
    public UIBar uibar;
    public PlayerManager playerManager;
    public PlayerLife playerLife;
    [Header("DataSkill")]
    public SkillSO[] skillsos;
    public string nameSkill;
    public string desSkill;
    public int CurrentDMG;
    public int percentGMG;
    public int kiSkill;
    public float timeSkill;
    //
    
    
    public int indexLevel;
    public int levelSkill1;
    public int levelSkill2;
    public int levelSkill3;
    public int levelSkill4;
    public int levelSkill5;
    public int levelSkill6;
    public int levelSkill7;
    public int levelSkill8;
    public int levelSkill9;
    public int levelSkill10;
    public const int levelmax = 7;
    //TimeCoolDow
    public float timecooldowSkill1;
    public float timecooldowSkill2;
    public float timecooldowSkill3;
    public float timecooldowSkill4;
    public float timecooldowSkill5;
    public float timecooldowSkill6;
    public float timecooldowSkill7;
    public float timecooldowSkill8;
    public float timecooldowSkill9;
    public float timecooldowSkill10;

    //GetValue
    
    //TimeCoolDow
    public float GetTimeCoolDowLevel1() { return (float)Math.Round(timecooldowSkill1, 1); }
    public float GetTimeCoolDowLevel2() { return (float)Math.Round(timecooldowSkill2, 1); }
    public float GetTimeCoolDowLevel3() { return (float)Math.Round(timecooldowSkill3, 1); }
    public float GetTimeCoolDowLevel4() { return (float)Math.Round(timecooldowSkill4, 1); }
    public float GetTimeCoolDowLevel5() { return (float)Math.Round(timecooldowSkill5, 1); }
    public float GetTimeCoolDowLevel6() { return (float)Math.Round(timecooldowSkill6, 1); }
    public float GetTimeCoolDowLevel7() { return (float)Math.Round(timecooldowSkill7, 1); }
    public float GetTimeCoolDowLevel8() { return (float)Math.Round(timecooldowSkill8, 1); }
    public float GetTimeCoolDowLevel9() { return (float)Math.Round(timecooldowSkill9, 1); }
    public float GetTimeCoolDowLevel10() { return (float)Math.Round(timecooldowSkill10, 1); }
    public void GetTimeCool(int index)
    {

        switch (index)
        {
            case 0: timeSkill = GetTimeCoolDowLevel1(); break;
            case 1: timeSkill = GetTimeCoolDowLevel2(); break;
            case 2: timeSkill = GetTimeCoolDowLevel3(); break;
            case 3: timeSkill = GetTimeCoolDowLevel4(); break;
            case 4: timeSkill = GetTimeCoolDowLevel5(); break;
            case 5: timeSkill = GetTimeCoolDowLevel6(); break;
            case 6: timeSkill = GetTimeCoolDowLevel7(); break;
            case 7: timeSkill = GetTimeCoolDowLevel8(); break;
            case 8: timeSkill = GetTimeCoolDowLevel9(); break;
            case 9: timeSkill = GetTimeCoolDowLevel10(); break;
        }

    }

    /*public void GetKISkill1(int index)
    {
        switch (index)
        {
            case 0: kiSkill = GetTimeCoolDowLevel1(); break;
            case 1: kiSkill = GetTimeCoolDowLevel2(); break;
            case 2: kiSkill = GetTimeCoolDowLevel3(); break;
            case 3: kiSkill = GetTimeCoolDowLevel4(); break;
            case 4: kiSkill = GetTimeCoolDowLevel5(); break;
            case 5: kiSkill = GetTimeCoolDowLevel6(); break;
            case 6: kiSkill = GetTimeCoolDowLevel7(); break;
            case 7: kiSkill = GetTimeCoolDowLevel8(); break;
            case 8: kiSkill = GetTimeCoolDowLevel9(); break;
            case 9: kiSkill = GetTimeCoolDowLevel10(); break;
        }
    }*/
    //level
    public int GetLevelSkill1() { return levelSkill1; }
    public int GetLevelSkill2() { return levelSkill2; }
    public int GetLevelSkill3() { return levelSkill3; }
    public int GetLevelSkill4() { return levelSkill4; }
    public int GetLevelSkill5() { return levelSkill5; }
    public int GetLevelSkill6() { return levelSkill6; }
    public int GetLevelSkill7() { return levelSkill7; }
    public int GetLevelSkill8() { return levelSkill8; }
    public int GetLevelSkill9() { return levelSkill9; }
    public int GetLevelSkill10() { return levelSkill10; }
    //skill
    public string GetSkillName(int index) { return  skillsos[index].GetName(); }
    public string GetSkillDes(int index) { return  skillsos[index].GetDescription(); }
    public int GetCurrentDMG(int index) { return  skillsos[index].GetCurrentDMG() + SetLevelSkill(index) * 10; }
    public int GetPercentDMG(int index) { return  skillsos[index].GetPercentDMG() + SetLevelSkill(index) * 2; ; }
    public int GetTimeSkill(int index) { return skillsos[index].GetTime(); }
    public int GetKISkill(int index) { return  skillsos[index].GetEnergy() + SetLevelSkill(index) * 10; }


    //SetValue
    //TimeCoolDown
    public void SetTimeCoolDown(int index)
    {
        switch (index)
        {
            case 0: timecooldowSkill1 = GetTimeSkill(index); break;
            case 1: timecooldowSkill2 = GetTimeSkill(index); break;
            case 2: timecooldowSkill3 = GetTimeSkill(index); break;
            case 3: timecooldowSkill4 = GetTimeSkill(index); break;
            case 4: timecooldowSkill5 = GetTimeSkill(index); break;
            case 5: timecooldowSkill6 = GetTimeSkill(index); break;
            case 6: timecooldowSkill7 = GetTimeSkill(index); break;
            case 7: timecooldowSkill8 = GetTimeSkill(index); break;
            case 8: timecooldowSkill9 = GetTimeSkill(index); break;
            case 9: timecooldowSkill10 = GetTimeSkill(index); break;
        }
    }
    //Level
    public int SetLevelSkill(int index)
    {

        switch (index)
        {
            case 0: indexLevel = GetLevelSkill1(); break;
            case 1: indexLevel = GetLevelSkill2(); break;
            case 2: indexLevel = GetLevelSkill3(); break;
            case 3: indexLevel = GetLevelSkill4(); break;
            case 4: indexLevel = GetLevelSkill5(); break;
            case 5: indexLevel = GetLevelSkill6(); break;
            case 6: indexLevel = GetLevelSkill7(); break;
            case 7: indexLevel = GetLevelSkill8(); break;
            case 8: indexLevel = GetLevelSkill9(); break;
            case 9: indexLevel = GetLevelSkill10(); break;
        }

        return indexLevel;
    }

    //PluslevelSkill
    public void PlusLevel(int index)
    {

        switch (index)
        {
            case 0:
                if (levelSkill1 < levelmax) { levelSkill1++; } else tb[1].SetActive(true);
                break;
            case 1:
                if (levelSkill2 < levelmax) { levelSkill2++; } else tb[1].SetActive(true);
                break;
            case 2:
                if (levelSkill3 < levelmax) { levelSkill3++; } else tb[1].SetActive(true);
                break;
            case 3:
                if (levelSkill4 < levelmax) { levelSkill4++; } else tb[1].SetActive(true);
                break;
            case 4:
                if (levelSkill5 < levelmax) { levelSkill5++; } else tb[1].SetActive(true);
                break;
            case 5:
                if (levelSkill6 < levelmax) { levelSkill6++; } else tb[1].SetActive(true);
                break;
            case 6:
                if (levelSkill7 < levelmax) { levelSkill7++; } else tb[1].SetActive(true);
                break;
            case 7:
                if (levelSkill8 < levelmax) { levelSkill8++; } else tb[1].SetActive(true);
                break;
            case 8:
                if (levelSkill9 < levelmax) { levelSkill9++; } else tb[1].SetActive(true);
                break;
            case 9:
                if (levelSkill10 < levelmax) { levelSkill10++; } else tb[1] .SetActive(true);
                break;

        }
    }


    void Start()
    {
        _skillIndex = 0;
        playerMoment = GetComponentInParent<PlayerMoment>();



    }

    // Update is called once per frame
    void Update()
    {
        CheckInPut();
        MinusTime();
        SetValue();
        
    }
   
    public void MinusTime()
    {
        if (timecooldowSkill1 > 0)
        {
            timecooldowSkill1 -= (3*Time.deltaTime);
        }
        if (timecooldowSkill2 > 0)
        {
            timecooldowSkill2 -= (2*Time.deltaTime);
        }
        if (timecooldowSkill3 > 0)
        {
            timecooldowSkill3 -= (2 * Time.deltaTime);
        }
        if (timecooldowSkill4 > 0)
        {
            timecooldowSkill4 -= (2 * Time.deltaTime);
        }
        if (timecooldowSkill5 > 0)
        {
            timecooldowSkill5 -= (2 * Time.deltaTime);
        }
        if (timecooldowSkill6 > 0)
        {
            timecooldowSkill6 -= (2 * Time.deltaTime);
        }
        if (timecooldowSkill7 > 0)
        {
            timecooldowSkill7 -= (2 * Time.deltaTime);
        }
        if (timecooldowSkill8 > 0)
        {
            timecooldowSkill8 -= (2 * Time.deltaTime);
        }
        if (timecooldowSkill9 > 0)
        {
            timecooldowSkill9 -= (2 * Time.deltaTime);
        }
        if (timecooldowSkill10 > 0)
        {
            timecooldowSkill10 -= (2 * Time.deltaTime);
        }
    }

    public void SetValue()
    {
        uibar.setValue(timecooldowSkill1, 0);
        uibar.setValue(timecooldowSkill2, 1);
        uibar.setValue(timecooldowSkill3, 2);
        uibar.setValue(timecooldowSkill4, 3);
        uibar.setValue(timecooldowSkill5, 4);
        uibar.setValue(timecooldowSkill6, 5);
        uibar.setValue(timecooldowSkill7, 6);
        uibar.setValue(timecooldowSkill8, 7);
        uibar.setValue(timecooldowSkill9, 8);
        uibar.setValue(timecooldowSkill10, 9);
    }

    public void CreateSkill(int skill)
    {
        SetTimeCoolDown(skill);
        GetTimeCool(skill);
        uibar.setMaxValue(timeSkill, skill);
        playerManager.minusKI(GetKISkill(skill));
        GameObject gameObject = Instantiate(_skill[skill], _skillPoint.position, Quaternion.identity);
        Rigidbody2D rigidbody = gameObject.GetComponent<Rigidbody2D>();
        Vector3 currentScale = gameObject.transform.localScale;
        playerAnimation.SetStateSkill(false);
        
        if (playerMoment._isRight == true)
        {
            rigidbody.velocity = transform.right * 25;

        }
        else
        {

            currentScale.x *= -1;
            gameObject.transform.localScale = currentScale;
            rigidbody.velocity = transform.right * -25;
        }
    }

    public void CheckInPut()
    {

        if (InputManager.instance.CheckInput() is int)
        {
            int index = (int)InputManager.instance.CheckInput();
            GetTimeCool(index);
           
            if (timeSkill <= 0 && (playerLife.GetKICurrent() >= GetKISkill(index)))
            {
                if (index > 1)
                {
                    playerAnimation.SetStateSkill(true);
                    playerAnimation.SetAnimationState("Skill");
                    playerAnimation._skillID = index;


                }
                else if (index == 1)
                {
                    SetTimeCoolDown(1);
                    GetTimeCool(1);
                    uibar.setMaxValue(timeSkill, 1);
                    playerManager.minusKI(GetKISkill(1));
                    Invoke("TurnOffSkill2", 5);
                    _skill[1].SetActive(true);
                }
            }
            else tb[1].SetActive(true); Invoke("TurnOnTB", 1f);



        }

        if (InputManager.instance.CheckInput() is string)
        {
            string index = (string)InputManager.instance.CheckInput();
            if (index == "J")
            {

                GetTimeCool(0);
               
                if (timeSkill <= 0 && playerLife.GetKICurrent() >= GetKISkill(0))
                {
                    SetTimeCoolDown(0);
                    GetTimeCool(0);
                    uibar.setMaxValue(timeSkill, 0);
                    playerAnimation.SetStateSkill(true);
                    playerManager.minusKI(GetKISkill(0));
                    playerAnimation.SetAnimationState("Attack");
                    playerAnimation.SetStateSkill(false);
                    
                }
                else
                {
                    tb[1].SetActive(true); Invoke("TurnOnTB", 1f);
                }

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
        GetKISkill(0);
        if (timeSkill <= 0 &&playerLife.GetKICurrent() >= GetKISkill(0))
        {
            playerAnimation.SetStateSkill(true);
            SetTimeCoolDown(0);
            GetTimeCool(0);
            uibar.setMaxValue(timeSkill, 0);
            playerAnimation.SetAnimationState("Attack");
            playerManager.minusKI(GetKISkill(0));
            playerAnimation.SetStateSkill(false);
        }
        else tb[1].SetActive(true); Invoke("TurnOnTB", 1f);

    }

    public void SetSkill(int index)
    {
        GetTimeCool(index);
        GetKISkill(index);
        if (timeSkill <= 0 && playerLife.GetKICurrent() >= GetKISkill(index))
        {
            if (index > 1)
            {
                playerAnimation.SetAnimationState("Skill");
                playerAnimation._skillID = index;
                playerAnimation.SetStateSkill(true);
            }
            else if (index == 1)
            {
                SetTimeCoolDown(1);
                GetTimeCool(1);
                uibar.setMaxValue(timeSkill, 1);
                playerManager.minusKI(GetKISkill(1));
                _skill[1].SetActive(true);
                Invoke("TurnOffSkill2", 5);
            }
        }
        else tb[1].SetActive(true); Invoke("TurnOnTB", 0.7f);


    }

    public void TurnOffSkill2()
    {
        _skill[1].SetActive(false);
    }

    public void TurnOnTB() {
        tb[1].SetActive(false);
    }


}
