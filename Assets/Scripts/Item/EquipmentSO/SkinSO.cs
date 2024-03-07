using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName ="New Skin",menuName = "GameData/Items/Equipment/Skin")]
public class SkinSO : EquipmentSO
{
    [Space]
    [Header("Head")]
    public Sprite[] _headIdle;
    public Sprite[] _headRun;


    [Header("Body")]
    public Sprite[] _bodyIdle;
    public Sprite[] _bodyRun;
    public Sprite[] _bodyAttack;
    public Sprite[] _bodySkill;
    public Sprite[] _bodyBlock;
    public Sprite[] _bodyFly;

    [Header("Leg")]
    public Sprite[] _legIdle;
    public Sprite[] _legRun;
    public Sprite[] _legAttack;
    public Sprite[] _legFly;
    public Sprite[] _legJump;

    [Header("BackPack")]
    public Sprite[] _backPack;

    public override void Update()
    {
        base.Update();
        this.equipmentType = EquipmentType.Skin;
        SetSpriteHeadIdle(_headIdle);
        SetSpriteHeadRun(_headRun);
        SetSpriteBodyIdle(_bodyIdle);
        SetSpriteBodyRun(_bodyRun);
        SetSpriteBodyAttack(_bodyAttack);
        SetSpriteBodySkill(_bodySkill);
        SetSpriteBodyBlockl(_bodyBlock);
        SetSpriteBodyFly(_bodyFly);
        SetSpriteLegIdle(_legIdle);
        SetSpriteLegRun(_legRun);
        SetSpriteLegAttack(_legAttack);
        SetSpriteLegFly(_legFly);
        SetSpriteLegJump(_legJump);

    }
}
