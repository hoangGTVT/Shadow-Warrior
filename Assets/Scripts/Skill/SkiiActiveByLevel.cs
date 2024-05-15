using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkiiActiveByLevel : MonoBehaviour
{
    public PlayerLife playerLife;
    public GameObject[] skill;
    public GameObject[] ButtonUplevelSkill;


    private void FixedUpdate()
    {
        ActiveSkill();
    }

    public void ActiveSkill()
    {
        if (playerLife.GetLevel() >= 3)
        {
            skill[0].SetActive(true);
            ButtonUplevelSkill[0].SetActive(true) ;
        }
        if (playerLife.GetLevel() >= 6)
        {
            skill[0].SetActive(true);
            skill[1].SetActive(true);
            ButtonUplevelSkill[0].SetActive(true);
            ButtonUplevelSkill[1].SetActive(true);
        }
        if (playerLife.GetLevel() >= 15)
        {
            skill[0].SetActive(true);
            skill[1].SetActive(true);
            skill[2].SetActive(true);
            ButtonUplevelSkill[0].SetActive(true);
            ButtonUplevelSkill[1].SetActive(true);
            ButtonUplevelSkill[2].SetActive(true);
        }
        if (playerLife.GetLevel() >= 24)
        {
            skill[0].SetActive(true);
            skill[1].SetActive(true);
            skill[2].SetActive(true);
            skill[3].SetActive(true);
            ButtonUplevelSkill[0].SetActive(true);
            ButtonUplevelSkill[1].SetActive(true);
            ButtonUplevelSkill[2].SetActive(true);
            ButtonUplevelSkill[3].SetActive(true);
           
        }
        if (playerLife.GetLevel() >= 35)
        {
            skill[0].SetActive(true);
            skill[1].SetActive(true);
            skill[2].SetActive(true);
            skill[3].SetActive(true);
            skill[4].SetActive(true);
            ButtonUplevelSkill[0].SetActive(true);
            ButtonUplevelSkill[1].SetActive(true);
            ButtonUplevelSkill[2].SetActive(true);
            ButtonUplevelSkill[3].SetActive(true);
            ButtonUplevelSkill[4].SetActive(true);

        }
    }
}
