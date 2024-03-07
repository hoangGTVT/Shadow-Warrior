using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Skill", menuName = "GameData/Skill")]
public class SkillSO : ScriptableObject
{
    public int _id;
    public string _name;

    public string _description;
    public int _currentDMG;
    public int _percentDME;
    public int _energy;
    public int _time;




}
