using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public enum ItemType
{
    None, Consumable, Equipment
}

public class ItemSO : ScriptableObject
{
    public int _id;
    public new string name;
    public Sprite _icon;
    public ItemType _itemType;
    public float _hp;
    public float _enegy;
    public float _def;
    public float _critRate;
    public float _critDMG;
    public float _atk;
    public float _stamina;

    public float GetID() { return _id; }
    public string GetName { get { return name; } }
    public float GetHP() { return _hp; }
    public float Getenegy() { return _enegy; }
    public float GetDef() { return _def; }
    public float GetCritRate() { return _critRate; }
    public float GetCritDMG() { return _critDMG; }
    public float GetATK() { return _atk; }
    public float GetStamina() { return _stamina; }
    public void OnEnable()
    {
        this.Update();
    }

    public virtual void Update()
    {
        /*if (this._icon != null)
        {
            this._id = int.Parse(this._icon.name);
        }*/
    }
    //Head
    private Sprite[] _spriteHeadIdle;
    public Sprite[] GetSpriteHeadIdle
    {

        get {  return this._spriteHeadIdle; }
    }
    public void SetSpriteHeadIdle(Sprite[] sprite)
    {
        
        this._spriteHeadIdle = sprite;
    }

    private Sprite[] _spriteHeadRun;
    public Sprite[] GetSpriteHeadIRun
    {
        get { return this._spriteHeadRun; }
    }
    public void SetSpriteHeadRun(Sprite[] sprite)
    {
        this._spriteHeadRun = sprite;
    }
    //Body
    private Sprite[] _spriteBodyIdle;
    public Sprite[] GetSpriteBodyIdle
    {
        get { return this._spriteBodyIdle; }
    }
    public void SetSpriteBodyIdle(Sprite[] sprite)
    {
        this._spriteBodyIdle = sprite;
    }

    private Sprite[] _spriteBodyRun;
    public Sprite[] GetSpriteBodyRun
    {
        get { return this._spriteBodyRun; }
    }
    public void SetSpriteBodyRun(Sprite[] sprite)
    {
        this._spriteBodyRun = sprite;
    }

    private Sprite[] _spriteBodyAttack;   
    public Sprite[] GetSpriteBodyAttack
    {
        get { return this._spriteBodyAttack;}
    }
    public void SetSpriteBodyAttack(Sprite[] sprite)
    {
        this._spriteBodyAttack = sprite;
    }

    private Sprite[] _spriteBodySkill;
    public Sprite[] GetSpriteBodySkill
    {
        get { return this._spriteBodySkill; }
    }
    public void SetSpriteBodySkill(Sprite[] sprite)
    {
        this._spriteBodySkill = sprite;
    }

    private Sprite[] _spriteBodyBlockl;
    public Sprite[] GetSpriteBodyBlockl
    {
        get { return this._spriteBodyBlockl; }
    }
    public void SetSpriteBodyBlockl(Sprite[] sprite)
    {
        this._spriteBodyBlockl = sprite;
    }

    private Sprite[] _spriteBodyFly;
    public Sprite[] GetSpriteBodyFly
    {
        get { return this._spriteBodyFly; }
    }
    public void SetSpriteBodyFly(Sprite[] sprite)
    {
        this._spriteBodyFly = sprite;
    }

    //Leg
    private Sprite[] _spriteLegIdle;
    public Sprite[] GetSpriteLegIdle
    {
        get { return this._spriteLegIdle; }
    }
    public void SetSpriteLegIdle(Sprite[] sprite)
    {
        this._spriteLegIdle = sprite;
    }

    private Sprite[] _spriteLegRun;
    public Sprite[] GetSpriteLegRun
    {
        get { return this._spriteLegRun; }
    }
    public void SetSpriteLegRun(Sprite[] sprite)
    {
        this._spriteLegRun = sprite;
    }

    private Sprite[] _spriteLegAttack;
    public Sprite[] GetSpriteLegAttack
    {
        get { return this._spriteLegAttack; }
    }
    public void SetSpriteLegAttack(Sprite[] sprite)
    {
        this._spriteLegAttack = sprite;
    }


    private Sprite[] _spriteLegFly;
    public Sprite[] GetSpriteLegFly
    {
        get { return this._spriteLegFly; }
    }
    public void SetSpriteLegFly(Sprite[] sprite)
    {
        this._spriteLegFly = sprite;
    }

    private Sprite[] _spriteLegJump;
    public Sprite[] GetSpriteLegJump
    {
        get { return this._spriteLegJump; }
    }
    public void SetSpriteLegJump(Sprite[] sprite)
    {
        this._spriteLegJump = sprite;
    }









}


