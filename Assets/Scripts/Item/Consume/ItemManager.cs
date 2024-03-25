using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public PlayerLife playerLife;
    public ItemController controller;
    public ItemConsumeSO[] itemConsumeSOs;
    public GameObject[] texts;
    public int indexItem;
    public Vector3 vector3;
    public float checkRadius = 5f; 
   


    public void GetInfoItem(int index,string name,int pricegold, int pricediamond, Sprite sprite)
    {
        name = GetName(index);
        pricegold = GetPriceGold(index);
        pricediamond = GetPriceDiamond(index);
        sprite = GetSprite(index);
    }
    public string GetName(int index) { return itemConsumeSOs[index].GetName(); }
    public int GetPriceGold(int index) { return itemConsumeSOs[index].priceGold; }
    public int GetPriceDiamond(int index) { return itemConsumeSOs[index].priceDiamond; }
    public Sprite GetSprite(int index) { return itemConsumeSOs[index].icon; }
    public int GetID(int index) { return itemConsumeSOs[(int)index].id; }

    public int GetIndexItem() { return indexItem; }
    public void SetIndexItem(int index)
    {
        indexItem = index;
    }
    
    protected virtual void CreateTextPopUp(int index,Vector3 vector3, int number)
    {

        GameObject pos = Instantiate(texts[index], vector3, quaternion.identity);
        pos.GetComponentInChildren<TextMeshPro>().text = "+" + number;
        Destroy(pos,0.7f);
    }

    protected virtual void CheckPlayer()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, checkRadius);

        foreach (Collider2D collider in colliders)
        {
            // Kiểm tra tag của đối tượng
            if (collider.CompareTag("Player01"))
            {
                 vector3 = new Vector3(collider.transform.position.x,collider.transform.position.y,collider.transform.position.z);
                
                controller = collider.GetComponentInChildren<ItemController>();
                playerLife=collider.GetComponentInChildren<PlayerLife>();
                
                if (controller != null)
                {
                    PlusItem();

                }
            }
        }
    }

    protected virtual Vector3 GetPos() { return vector3; }
    protected virtual void PlusItem(){ }
    protected virtual void DestroyItem(float index) { Destroy(gameObject, index); }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
       
    }
}
