using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EquipmentType
{
    Skin,PUE
}

public class EquipmentSO : ItemSO
{
    public EquipmentType equipmentType;

    public override void Update()
    {
        
        base.Update();
        this._itemType = ItemType.Equipment;
    }
        
}
