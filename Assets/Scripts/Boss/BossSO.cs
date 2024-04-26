using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Boss", menuName = "GameData/Enemy/NewBoss")]
public class BossSO : ScriptableObject
{

    public int _id;
    public string _name;
    public int _exp;
    public int _hp;
   
    public int _atk;
    public int _ki;
    public int _def;
    public int _timeskill;
    public int _timeAttack;

    public int GetId(){ return _id; }
    public string GetName() { return _name; }
    public int GetExp() { return _exp;}
    public int GetHp() { return _hp;}
   
    public int GetATK() { return _atk;}
    public int GetKi() { return _ki;}
    public int GetDef() { return _def;}
    public int GetTime() { return _timeskill; }
    public int GetTimeAttack() { return _timeAttack; }
    
}
