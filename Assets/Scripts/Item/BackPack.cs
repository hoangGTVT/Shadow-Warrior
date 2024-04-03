using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackPack : MonoBehaviour
{
    public GameObject[] backpack;
    public BackPackSO[] backPackSOs;
    public int indexBackPack;

    private void Awake()
    {
        indexBackPack = 0;
    }
    public void SetIndexBP(int index) { indexBackPack = index; }
    public int GetIndexBP() {  return indexBackPack; }

    public int GetId() { return backPackSOs[indexBackPack].GetID(); }
    public Sprite GetSprite() { return backPackSOs[indexBackPack].GetSprite(); }
    public string GetName() { return backPackSOs[indexBackPack].GetName(); }
    public int GetHP() { return backPackSOs[indexBackPack].GetHP(); }  
    public int GetKI() { return backPackSOs[indexBackPack].GetKI(); }
    public int GetATK() { return backPackSOs[indexBackPack].GetATK(); } 
    public int GetDEF() { return backPackSOs[indexBackPack].GetDef(); }
    public int GetCrit() { return backPackSOs[indexBackPack].GetCritRate(); }
    public int GetCritDMG() { return backPackSOs[indexBackPack].GetCritDMG(); }
    public int GetSta() { return backPackSOs[indexBackPack].GetStamina(); }

    public void ChangeBackPack()
    {
        if (backpack != null)
        {
            PlayerCustomization(backpack, backPackSOs[indexBackPack].GetSpriteHeadIdle);
        }
    }
    private void PlayerCustomization(GameObject[] outfits, Sprite[] sprites)
    {

        if (outfits.Length > 0)
        {
            if (sprites != null && sprites.Length > 0)
            {
                for (int i = 0; i < outfits.Length; i++)
                {

                    outfits[i].GetComponent<SpriteRenderer>().sprite = sprites[i];
                }
            }

        }
    }

    private void Update()
    {
        ChangeBackPack();
        if (Input.GetKeyDown(KeyCode.U))
        {
            if (indexBackPack < backPackSOs.Length)
            {
                indexBackPack++;
            }
            else { indexBackPack=0; }
            

        }
    }
}
