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
    [Header("Gold")]
    public int goldSkill1;
    public int goldSkill2;
    public int goldSkill3;
    public int goldSkill4;
    public int goldSkill5;
    public int goldSkill6;
    public int goldSkill7;
    public int goldSkill8;
    public int goldSkill9;
    public int goldSkill10;
    [Header("Diamond")]
    public int diamondSkill1;
    public int diamondSkill2;
    public int diamondSkill3;
    public int diamondSkill4;
    public int diamondSkill5;
    public int diamondSkill6;
    public int diamondSkill7;
    public int diamondSkill8;
    public int diamondSkill9;
    public int diamondSkill10;
    [Header("DaNguSac")]
    public int dangusacSkill1;
    public int dangusacSkill2;
    public int dangusacSkill3;
    public int dangusacSkill4;
    public int dangusacSkill5;
    public int dangusacSkill6;
    public int dangusacSkill7;
    public int dangusacSkill8;
    public int dangusacSkill9;
    public int dangusacSkill10;
    [Header("UPLevel")]
    public int goldUP;
    public int diamondUP;
    public int dangusacUP;
   

    public void SetSkillIndex(int index) { skillIndex = index; }
    //GetValue
    public int GetGoldSkill1() { return goldSkill1=skillController.GetLevelSkill1()* goldUP; }
    public int GetGoldSkill2() {  return goldSkill2 = skillController.GetLevelSkill2() * goldUP; }
    public int GetGoldSkill3() {  return goldSkill3 = skillController.GetLevelSkill3() * goldUP; }
    public int GetGoldSkill4() {  return goldSkill4 = skillController.GetLevelSkill4() * goldUP; }
    public int GetGoldSkill5() {  return goldSkill5 = skillController.GetLevelSkill5() * goldUP; }
    public int GetGoldSkill6() {  return goldSkill6 = skillController.GetLevelSkill6() * goldUP; }
    public int GetGoldSkill7() {  return goldSkill7 = skillController.GetLevelSkill7() * goldUP; }
    public int GetGoldSkill8() {  return goldSkill8 = skillController.GetLevelSkill8() * goldUP; }
    public int GetGoldSkill9() {  return goldSkill9 = skillController.GetLevelSkill9() * goldUP; }
    public int GetGoldSkill10() {  return goldSkill10 = skillController.GetLevelSkill10() * goldUP; }


    public int GetDiamondSkill1() { return diamondSkill1 = skillController.GetLevelSkill1() * diamondUP; }
    public int GetDiamondSkill2() {  return diamondSkill2 = skillController.GetLevelSkill2() * diamondUP; }
    public int GetDiamondSkill3() {  return diamondSkill3 = skillController.GetLevelSkill3() * diamondUP; }
    public int GetDiamondSkill4() { return diamondSkill4 = skillController.GetLevelSkill4() * diamondUP; }
    public int GetDiamondSkill5() {  return diamondSkill5 = skillController.GetLevelSkill5() * diamondUP; }
    public int GetDiamondSkill6() {  return diamondSkill6 = skillController.GetLevelSkill6() * diamondUP; }
    public int GetDiamondSkill7() {  return diamondSkill7 = skillController.GetLevelSkill7() * diamondUP; }
    public int GetDiamondSkill8() {  return diamondSkill8 = skillController.GetLevelSkill8() * diamondUP; }
    public int GetDiamondSkill9() {  return diamondSkill9 = skillController.GetLevelSkill9() * diamondUP; }
    public int GetDiamondSkill10() { return diamondSkill10 = skillController.GetLevelSkill10() * diamondUP; }


    public int GetDaNguSac1() { return dangusacSkill1 = skillController.GetLevelSkill1() * dangusacUP; }
    public int GetDaNguSac2() {  return dangusacSkill2 = skillController.GetLevelSkill2() * dangusacUP; }
    public int GetDaNguSac3() {  return dangusacSkill3 = skillController.GetLevelSkill3() * dangusacUP; }
    public int GetDaNguSac4() {  return dangusacSkill4 = skillController.GetLevelSkill4() * dangusacUP; }
    public int GetDaNguSac5() {  return dangusacSkill5 = skillController.GetLevelSkill5() * dangusacUP; }
    public int GetDaNguSac6() {  return dangusacSkill6 = skillController.GetLevelSkill6() * dangusacUP; }
    public int GetDaNguSac7() {  return dangusacSkill7 = skillController.GetLevelSkill7() * dangusacUP; }
    public int GetDaNguSac8() {  return dangusacSkill8 = skillController.GetLevelSkill8() * dangusacUP; }
    public int GetDaNguSac9() {  return dangusacSkill9 = skillController.GetLevelSkill9() * dangusacUP; }
    public int GetDaNguSac10() { return dangusacSkill10 = skillController.GetLevelSkill10() * dangusacUP; }
    //UP level

    private void Start()
    {
        
    }
    void Update()
    {
        ShowTimeCoolDown();
        ShowLevel();  
        ShowName();

    }



    public void ShowName()
    {
        textName[0].text = skillController.GetSkillName(0);
        textName[1].text = skillController.GetSkillName(1);
        textName[2].text = skillController.GetSkillName(2);
        textName[3].text = skillController.GetSkillName(3);
        textName[4].text = skillController.GetSkillName(4);
        textName[5].text = skillController.GetSkillName(5);
        textName[6].text = skillController.GetSkillName(6);
        textName[7].text = skillController.GetSkillName(7);
        textName[8].text = skillController.GetSkillName(8);
        textName[9].text = skillController.GetSkillName(9);
    }
    public void ShowLevel()
    {
        textLevel[0].text=skillController.GetLevelSkill1().ToString();
        textLevel[1].text = skillController.GetLevelSkill2().ToString();
        textLevel[2].text = skillController.GetLevelSkill3().ToString();
        textLevel[3].text = skillController.GetLevelSkill4().ToString();
        textLevel[4].text = skillController.GetLevelSkill5().ToString();
        textLevel[5].text = skillController.GetLevelSkill6().ToString();
        textLevel[6].text = skillController.GetLevelSkill7().ToString();
        textLevel[7].text = skillController.GetLevelSkill8().ToString();
        textLevel[8].text = skillController.GetLevelSkill9().ToString();
        textLevel[9].text = skillController.GetLevelSkill10().ToString();
    }
    public void ShowUpLevel()
    {
        switch (skillIndex)
        {
            case 0:
                textupLevel[0].text = "Bạn có muốn nâng cấp chiêu " + skillController.GetSkillName(0) + " không?";
                textupLevel[1].text = GetGoldSkill1().ToString();
                textupLevel[2].text=GetDiamondSkill1().ToString();
                textupLevel[3].text=GetDaNguSac1().ToString();
                break;
            case 1:
                textupLevel[0].text = "Bạn có muốn nâng cấp chiêu " + skillController.GetSkillName(1) + " không?";
                textupLevel[1].text = GetGoldSkill2().ToString();
                textupLevel[2].text = GetDiamondSkill2().ToString();
                textupLevel[3].text = GetDaNguSac2().ToString();
                break;
            case 2:
                textupLevel[0].text = "Bạn có muốn nâng cấp chiêu " + skillController.GetSkillName(2) + " không?";
                textupLevel[1].text = GetGoldSkill3().ToString();
                textupLevel[2].text = GetDiamondSkill3().ToString();
                textupLevel[3].text = GetDaNguSac3().ToString();
                break;
            case 3:
                textupLevel[0].text = "Bạn có muốn nâng cấp chiêu " + skillController.GetSkillName(3) + " không?";
                textupLevel[1].text = GetGoldSkill4().ToString();
                textupLevel[2].text = GetDiamondSkill4().ToString();
                textupLevel[3].text = GetDaNguSac4().ToString();
                break;
            case 4:
                textupLevel[0].text = "Bạn có muốn nâng cấp chiêu " + skillController.GetSkillName(4) + " không?";
                textupLevel[1].text = GetGoldSkill5().ToString();
                textupLevel[2].text = GetDiamondSkill5().ToString();
                textupLevel[3].text = GetDaNguSac5().ToString();
                break;
            case 5:
                textupLevel[0].text = "Bạn có muốn nâng cấp chiêu " + skillController.GetSkillName(5) + " không?";
                textupLevel[1].text = GetGoldSkill6().ToString();
                textupLevel[2].text = GetDiamondSkill6().ToString();
                textupLevel[3].text = GetDaNguSac6().ToString();
                break;
            case 6:
                textupLevel[0].text = "Bạn có muốn nâng cấp chiêu " + skillController.GetSkillName(6) + " không?";
                textupLevel[1].text = GetGoldSkill7().ToString();
                textupLevel[2].text = GetDiamondSkill7().ToString();
                textupLevel[3].text = GetDaNguSac7().ToString();
                break;
            case 7:
                textupLevel[0].text = "Bạn có muốn nâng cấp chiêu " + skillController.GetSkillName(7) + " không?";
                textupLevel[1].text = GetGoldSkill8().ToString();
                textupLevel[2].text = GetDiamondSkill8().ToString();
                textupLevel[3].text = GetDaNguSac8().ToString();
                break;
            case 8:
                textupLevel[0].text = "Bạn có muốn nâng cấp chiêu " + skillController.GetSkillName(8) + " không?";
                textupLevel[1].text = GetGoldSkill9().ToString();
                textupLevel[2].text = GetDiamondSkill9().ToString();
                textupLevel[3].text = GetDaNguSac9().ToString();
                break;
            case 9:
                textupLevel[0].text = "Bạn có muốn nâng cấp chiêu " + skillController.GetSkillName(9) + " không?";
                textupLevel[1].text = GetGoldSkill10().ToString();
                textupLevel[2].text = GetDiamondSkill10().ToString();
                textupLevel[3].text = GetDaNguSac10().ToString();
                break;
           
        }
        
    }

    public void PlusLevel()
    {
        switch (skillIndex)
        {
            case 0:
                if (CheckSkill1() == true)
                {
                    skillController.PlusLevel(skillIndex);
                   
                }
                break;
            case 1:
                if (CheckSkill2() == true)
                {
                    skillController.PlusLevel(skillIndex);
                }
                break;
            case 2:
                if (CheckSkill3() == true)
                {
                    skillController.PlusLevel(skillIndex);
                }
                break;
            case 3:
                if (CheckSkill4() == true)
                {
                    skillController.PlusLevel(skillIndex);
                }
                break;
            case 4:
                if (CheckSkill5() == true)
                {
                    skillController.PlusLevel(skillIndex);
                }
                break;
            case 5:
                if (CheckSkill6() == true)
                {
                    skillController.PlusLevel(skillIndex);
                }
                break;
            case 6:
                if (CheckSkill7() == true)
                {
                    skillController.PlusLevel(skillIndex);
                }
                break;
            case 7:
                if (CheckSkill8() == true)
                {
                    skillController.PlusLevel(skillIndex);
                }
                break;
            case 8:
                if (CheckSkill9() == true)
                {
                    skillController.PlusLevel(skillIndex);
                }
                break;
            case 9:
                if (CheckSkill10() == true)
                {
                    skillController.PlusLevel(skillIndex);
                }
                break;
        }
        
    }
    public void ShowTimeCoolDown()
    {
        textTime[0].text = skillController.GetTimeCoolDowLevel1().ToString();
        textTime[1].text = skillController.GetTimeCoolDowLevel2().ToString();
        textTime[2].text = skillController.GetTimeCoolDowLevel3().ToString();
        textTime[3].text = skillController.GetTimeCoolDowLevel4().ToString();
        textTime[4].text = skillController.GetTimeCoolDowLevel5().ToString();
        textTime[5].text = skillController.GetTimeCoolDowLevel6().ToString();
        textTime[6].text = skillController.GetTimeCoolDowLevel7().ToString();
        textTime[7].text = skillController.GetTimeCoolDowLevel8().ToString();
        textTime[8].text = skillController.GetTimeCoolDowLevel9().ToString();
        textTime[9].text = skillController.GetTimeCoolDowLevel10().ToString();
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


    public bool CheckSkill1()
    {
        if (itemController.GetGold() >= GetGoldSkill1() && itemController.GetDiamond() >= GetDiamondSkill1() && itemController.GetDaNguSac() >= GetDaNguSac1())
        {
            return true;
        }
        else upfail.SetActive(true); return false;
    }
    public bool CheckSkill2()
    {
        if (itemController.GetGold() >= GetGoldSkill2() && itemController.GetDiamond() >= GetDiamondSkill2() && itemController.GetDaNguSac() >= GetDaNguSac2())
        {
            return true;
        }
        else upfail.SetActive(true); return false;
    }
    public bool CheckSkill3()
    {
        if (itemController.GetGold() >= GetGoldSkill3() && itemController.GetDiamond() >= GetDiamondSkill3() && itemController.GetDaNguSac() >= GetDaNguSac3())
        {
            return true;
        }
        else upfail.SetActive(true); return false;
    }
    public bool CheckSkill4()
    {
        if (itemController.GetGold() >= GetGoldSkill4() && itemController.GetDiamond() >= GetDiamondSkill4() && itemController.GetDaNguSac() >= GetDaNguSac4())
        {
            return true;
        }
        else upfail.SetActive(true); return false;
    }
    public bool CheckSkill5()
    {
        if (itemController.GetGold() >= GetGoldSkill5() && itemController.GetDiamond() >= GetDiamondSkill5() && itemController.GetDaNguSac() >= GetDaNguSac5())
        {
            return true;
        }
        else upfail.SetActive(true); return false;
    }
    public bool CheckSkill6()
    {
        if (itemController.GetGold() >= GetGoldSkill6() && itemController.GetDiamond() >= GetDiamondSkill6() && itemController.GetDaNguSac() >= GetDaNguSac6())
        {
            return true;
        }
        else upfail.SetActive(true); return false;
    }
    public bool CheckSkill7()
    {
        if (itemController.GetGold() >= GetGoldSkill7() && itemController.GetDiamond() >= GetDiamondSkill7() && itemController.GetDaNguSac() >= GetDaNguSac7())
        {
            return true;
        }
        else upfail.SetActive(true); return false;
    }
    public bool CheckSkill8()
    {
        if (itemController.GetGold() >= GetGoldSkill8() && itemController.GetDiamond() >= GetDiamondSkill8() && itemController.GetDaNguSac() >= GetDaNguSac8())
        {
            return true;
        }
        else upfail.SetActive(true); return false;
    }
    public bool CheckSkill9()
    {
        if (itemController.GetGold() >= GetGoldSkill9() && itemController.GetDiamond() >= GetDiamondSkill9() && itemController.GetDaNguSac() >= GetDaNguSac9())
        {
            return true;
        }
        else upfail.SetActive(true); return false;
    }
    public bool CheckSkill10()
    {
        if (itemController.GetGold() >= GetGoldSkill10() && itemController.GetDiamond() >= GetDiamondSkill10() && itemController.GetDaNguSac() >= GetDaNguSac10())
        {
            return true;
        }
        else upfail.SetActive(true); return false;
    }
}
