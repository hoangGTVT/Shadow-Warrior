using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Shop_ShowItem : MonoBehaviour
{
    [Header("Script")]
    public ItemManager itemManager;
    public BackPack backPack;
    [Header("Icon")]
    public Image[] iconItem;
    public Image[] iconbackpack;
    [Header("Name")]
    public TextMeshProUGUI[] nameItem;
    public TextMeshProUGUI[] namebackpack;
    [Header("Gold")]
    public TextMeshProUGUI[] goldItem;
    public TextMeshProUGUI[] goldbackPack;
    [Header("Diamond")]
    public TextMeshProUGUI[] diamondItem;
    public TextMeshProUGUI[] diamondBackPack;
    private void OnEnable()
    {
        ShowItem();
        ShowBackPack();
    }

    public void ShowItem()
    {
        int icon = 0;
        for(int i = 4; i <= 16; i++)
        {
            iconItem[icon].sprite = itemManager.itemConsumeSOs[i].GetSprite();
            nameItem[icon].text = itemManager.itemConsumeSOs[i].GetName();
            goldItem[icon].text = itemManager.itemConsumeSOs[i].GetPriceGold().ToString();
            diamondItem[icon].text = itemManager.itemConsumeSOs[i].GetPriceDiamond().ToString();
            icon++;

        }
    }

    public void ShowBackPack()
    {
        for(int i=0; i <= 8; i++)
        {
            iconbackpack[i].sprite = backPack.backPackSOs[i].GetSprite();
            namebackpack[i].text = backPack.backPackSOs[i].GetName();
            goldbackPack[i].text = backPack.backPackSOs[i].GetPriceGold().ToString() ;
            diamondBackPack[i].text = backPack.backPackSOs[i].GetPriceDiamond().ToString() ;
        }
    }
    void Update()
    {
        
    }
}
