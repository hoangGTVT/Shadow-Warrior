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
    public int _percentDMG;
    public int _energy;
    public float _time;
    

    public string GetName() { return _name; }
    public string GetDescription() { return _description; }
    public int GetCurrentDMG() { return _currentDMG; }
    public int GetPercentDMG() { return _percentDMG;}
    public int GetEnergy() { return _energy;}
    public float GetTime() { return _time;}



}
