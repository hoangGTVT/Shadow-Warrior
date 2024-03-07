using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Boss", menuName = "GameData/Enemy/NewBoss")]
public class BossSO : ScriptableObject
{

    public int _id;
    public string _name;
    public int _hp;
    public int _energy;
    public int _atk;

    public int GetId(){ return _id; }
    public string GetName() { return _name; }
    public int GetHp() { return _hp;}
    public int GetEnergy() { return _energy;}
    public int GetATK() { return _atk;}
    
}
