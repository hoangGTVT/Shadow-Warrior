using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

[CreateAssetMenu(fileName = "New Enemy", menuName = "GameData/Enemy/NewEnemy")]

public class EnemySO : ScriptableObject
{
    public int _id;
    public string _name;
    public Sprite _sprite;
    public int _exp;
    public int _hp;
    public int _atk;
    public int _timeAttack;

    public int GetId() { return _id; }
    public string GetName() { return _name; }
    public Sprite GetSprite() { return _sprite; }   
    public int GetExp() { return _exp;}
    public int GetHp() { return _hp;}
    public int GetAtk() { return _atk;}
    public int GetTimeAttack() { return _timeAttack;}
}
