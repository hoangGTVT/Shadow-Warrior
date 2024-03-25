using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayManager : MonoBehaviour
{
    public SkillController skillController;
    void Start()
    {
        GameObject _player = GameObject.FindGameObjectWithTag("Player01");
    }

    // Update is called once per frame
    void Update()
    {
        GameObject _player = GameObject.FindGameObjectWithTag("Player01");
        skillController = _player.GetComponentInChildren<SkillController>();
    }


    public void Skill1()
    {
        skillController.Skill1();
    }

    public void Skill2()
    {
        skillController.SetSkill(1);
    }
    public void Skill3()
    {
        skillController.SetSkill(2);
    }
    public void Skill4()
    {
        skillController.SetSkill(3);
    }
    public void Skill5()
    {
        skillController.SetSkill(4);
    }
    public void Skill6()
    {
        skillController.SetSkill(5);
    }
    public void Skill7()
    {
        skillController.SetSkill(6);
    }
    public void Skill8()
    {
        skillController.SetSkill(7);
    }
    public void Skill9()
    {
        skillController.SetSkill(8);
    }
    public void Skill10()
    {
        skillController.SetSkill(9);
    }
}
