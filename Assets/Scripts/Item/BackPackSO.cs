using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Skin", menuName = "GameData/Items/Equipment/BackPack")]

public class BackPackSO : EquipmentSO
{
    [Space]
    [Header("Head")]
    public Sprite[] _backPack;



    
    public override void Update()
    {
        base.Update();
        this.equipmentType = EquipmentType.Skin;
        SetSpriteHeadIdle(_backPack);
        

    }
}
