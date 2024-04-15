using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SkillManager : MonoBehaviour
{
    public SkillController skillController;
    public ItemController itemController;
    
    public GameObject upfail;
    public int skillId;
    public int skillIndex;
    [Header("Text")]
    public TextMeshProUGUI[] textTime;
    public TextMeshProUGUI[] textupLevel;
    public TextMeshProUGUI[] textLevel;
    public TextMeshProUGUI[] textName;
    public TextMeshProUGUI[] textDescription;
    [Header("Gold")]
    public int[] goldSkill;
    
    [Header("Diamond")]
    public int[] diamondSkill;
    
    [Header("DaNguSac")]
    public int[] dangusacSkill;
    
    [Header("UPLevel")]
    public int goldUP;
    public int diamondUP;
    public int dangusacUP;
   

    public void SetSkillIndex(int index) { skillIndex = index; }
    //GetValue
    public int GetGoldSkill(int index) { return goldSkill[index] =skillController.GetLevelSkill(index)* goldUP; }
   


    public int GetDiamondSkill(int index) { return diamondSkill[index] = skillController.GetLevelSkill(index) * diamondUP; }
   


    public int GetDaNguSac(int index) { return dangusacSkill[index] = skillController.GetLevelSkill(index) * dangusacUP; }
    
    //UP level

    private void Start()
    {
        ShowName();
    }
    void Update()
    {
        ShowTimeCoolDown();
        ShowLevel();  
        

    }


    public void ShowInfoSkill()
    {
        textDescription[0].text=skillController.GetSkillName(skillIndex);
        textDescription[1].text = "Cấp "+ skillController.GetLevelSkill(skillIndex).ToString();
        textDescription[2].text= "Ki tiêu hao: "+ skillController.GetKISkill(skillIndex).ToString();
        textDescription[3].text= "Thời gian hồi chiêu: "+ skillController.GetTimeSkill(skillIndex).ToString();
        textDescription[4].text=skillController.GetSkillDes(skillIndex).ToString();
    }
    public void ShowName()
    {
        for (int i = 0; i <= 5; i++)
        {
            textName[i].text = skillController.GetSkillName(i);
        }

    }
    public void ShowLevel()
    {
        for(int i = 0; i <= 5; i++)
        {
            textLevel[i].text = skillController.GetLevelSkill(i).ToString();
        }
        
        
    }
    public void ShowUpLevel()
    {
        textupLevel[0].text = "Bạn có muốn nâng cấp chiêu " + skillController.GetSkillName(skillIndex) + " không?";
        textupLevel[1].text = GetGoldSkill(skillIndex).ToString();
        textupLevel[2].text = GetDiamondSkill(skillIndex).ToString();
        textupLevel[3].text = GetDaNguSac(skillIndex).ToString();
        
        
    }

    public void PlusLevel()
    {
        if (CheckSkill(skillIndex) == true)
        {
            itemController.MinusGold(GetGoldSkill(skillIndex));
            itemController.MinusDiamond(GetDiamondSkill(skillIndex));
            itemController.MinusDaNguSac(GetDaNguSac(skillIndex));
            skillController.PlusLevel(skillIndex);

        }
       
        
    }
    public void ShowTimeCoolDown()
    {
        for(int i = 0; i <= 5; i++)
        {
            textTime[i].text = skillController.GetTimeCoolDowLevel(i).ToString();
        }
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


    public bool CheckSkill(int index)
    {
        if (itemController.GetGold() >= GetGoldSkill(index) && itemController.GetDiamond() >= GetDiamondSkill(index) && itemController.GetDaNguSac() >= GetDaNguSac(index))
        {
            return true;
        }
        else upfail.SetActive(true); return false;
    }
    
}
