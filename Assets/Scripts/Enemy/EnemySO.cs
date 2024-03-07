using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Enemy", menuName = "GameData/Enemy/NewEnemy")]

public class EnemySO : ScriptableObject
{
    public int _id;
    public string _name;
    public int _hp;
    public int _atk;

    public int GetId() { return _id; }
    public string GetName() { return _name; }
    public int GetHp() { return _hp;}
    public int GetAtk() { return _atk;}
}
