using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "GameData/Items/Consume")]
public class ItemConsumeSO : ScriptableObject
{
    public new string name;
    public Sprite icon;
    public int id;
    public int priceGold;
    public int priceDiamond;

    public string GetName() { return name; }
    public int GetID() { return id; }
    public int GetPriceGold() {  return priceGold; }
    public int GetPriceDiamond() {  return priceDiamond; }
    public Sprite GetIcon() { return icon; }    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
