using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Shop_ShowSkin : MonoBehaviour
{
    [Header("scripts")]
    public PlayerSkinController skinController;
    [Header("Icon")]
    public Image[] icon;
    [Header("Text")]
    public TextMeshProUGUI[] nameSkin;
    public TextMeshProUGUI[] goldskin;
    public TextMeshProUGUI[] diamondSkin;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnEnable()
    {
        Showinfoskin();
    }
    public void Showinfoskin()
    {
        int hk = 0;
        for(int i = 11; i <= 51; i++)
        {
            icon[hk].sprite = skinController.skinSO[i].GetSprite();
            nameSkin[hk].text = skinController.skinSO[i].GetName();
            goldskin[hk].text = skinController.skinSO[i].GetPriceGold().ToString("#,#");
            diamondSkin[hk].text = skinController.skinSO[i].GetPriceDiamond().ToString("#,#");
            hk++;
           
        }

        
    }
}
