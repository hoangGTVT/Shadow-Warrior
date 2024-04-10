using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Shop_ShowClother : MonoBehaviour
{
    [Header("Scripts")]
    public ClothersController clothersController;
    [Header("Icon")]
    public Image[] iconAo;
    public Image[] iconQuan;
    public Image[] iconGang;
    public Image[] iconGiay;
    public Image[] iconRada;
    [Header("Name")]
    public TextMeshProUGUI[] nameAo;
    public TextMeshProUGUI[] nameQuan;
    public TextMeshProUGUI[] nameGang;
    public TextMeshProUGUI[] nameGiay;
    public TextMeshProUGUI[] nameRada;
    [Header("gold")]
    public TextMeshProUGUI[] goldAo;
    public TextMeshProUGUI[] goldQuan;
    public TextMeshProUGUI[] goldGang;
    public TextMeshProUGUI[] goldGiay;
    public TextMeshProUGUI[] goldRada;
    [Header("diamond")]
    public TextMeshProUGUI[] diamondAo;
    public TextMeshProUGUI[] diamondQuan;
    public TextMeshProUGUI[] diamondGang;
    public TextMeshProUGUI[] diamondGiay;
    public TextMeshProUGUI[] diamondRada;

    private void OnEnable()
    {
        ShowClother();
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowClother()
    {
        for(int i = 0; i <= 4; i++)
        {
            iconAo[i].sprite= clothersController.clothesSOs[i].GetSprite();
            iconQuan[i].sprite = clothersController.pan[i].GetSprite();
            iconGang[i].sprite = clothersController.gang[i].GetSprite();
            iconGiay[i].sprite = clothersController.giay[i].GetSprite();
            iconRada[i].sprite = clothersController.rada[i].GetSprite();

            nameAo[i].text = clothersController.clothesSOs[i].GetName();
            nameQuan[i].text = clothersController.pan[i].GetName();
            nameGang[i].text = clothersController.gang[i].GetName();
            nameGiay[i].text = clothersController.giay[i].GetName();
            nameRada[i].text = clothersController.rada[i].GetName();

            goldAo[i].text = clothersController.clothesSOs[i].GetPriceGold().ToString();
            goldGang[i].text = clothersController.gang[i].GetPriceGold().ToString();
            goldQuan[i].text = clothersController.pan[i].GetPriceGold().ToString();
            goldGiay[i].text = clothersController.giay[i].GetPriceGold().ToString();
            goldRada[i].text = clothersController.rada[i].GetPriceGold().ToString();

            diamondAo[i].text = clothersController.clothesSOs[i].GetPriceDiamond().ToString();
            diamondQuan[i].text = clothersController.pan[i].GetPriceDiamond().ToString();
            diamondGang[i].text = clothersController.gang[i].GetPriceDiamond().ToString();
            diamondGiay[i].text = clothersController.giay[i].GetPriceDiamond().ToString();
            diamondRada[i].text = clothersController.rada[i].GetPriceDiamond().ToString();
        }
    }


}
