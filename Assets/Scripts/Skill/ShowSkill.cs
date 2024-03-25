using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowSkill : MonoBehaviour
{
    public SkillController skillController;
    public int skillId;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Skill(int index)
    {
        switch (index)
        {
            case 0:
                skillController.Skill1();
                break;
            case 1:
                skillController.SetSkill(1); 
            break;
            case 2:
                skillController.SetSkill(2);
                break;
            case 3:
                skillController.SetSkill(3);
                break;
            case 4:
                skillController.SetSkill(4);
                break;
            case 5:
                skillController.SetSkill(5);
                break;
            case 6:
                skillController.SetSkill(6);
                break;
            case 7:
                skillController.SetSkill(7);
                break;
            case 8:
                skillController.SetSkill(8);
                break;
            case 9:
                skillController.SetSkill(9);
                break;
        }
    }
}
