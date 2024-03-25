using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Clothes", menuName = "GameData/Items/Equipment/Clothes")]
public class ClothesSO : EquipmentSO
{
    
    void Start()
    {
        
    }

    // Update is called once per frame
    public override void Update()
    {
        base.Update();
        this.equipmentType = EquipmentType.Clother;
    }
}
