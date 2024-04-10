using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InventoryController : MonoBehaviour
{
    [Header("Script")]
    public ItemController itemController;
    public ClotherManager clotherManager;
    public SkinManager skinManager;
    [Header("Item")]
    public GameObject[] item;
    public int[] itemCount;
    public TextMeshProUGUI[] textItemCout;
    [Header("Clother")]
    public GameObject[] clothers;
    public int[] clotherCount;
    public TextMeshProUGUI[] textClother;
    [Header("Skin")]
    public GameObject[] skins;
    public int[] skincount;
    public TextMeshProUGUI[] textSkin;

    public TextMeshProUGUI gold;
    public TextMeshProUGUI diamond;
    

    private void OnEnable()
    {
        GetDataItem();
        GetDataClother();
        GetDataSkin();

    }

    private void FixedUpdate()
    {
        GetDataSkin();
        CheckSkinsOnEnable();
        CheckItemOnEnable();
        GetDataItem();
        CheckClothersOnEnable();
        GetDataClother();
        gold.text=itemController.GetGold().ToString("#,#");
        diamond.text = itemController.GetDiamond().ToString("#,#");
    }
    //Skin
    public void GetDataSkin()
    {
        for(int i = 0; i <= 40; i++)
        {
            skincount[i] = skinManager.GetSkin(i);
        }
    }

    public void CheckSkinsOnEnable()
    {
        for(int i = 0; i <= 40; i++)
        {
            textSkin[i].text = skincount[i].ToString();
            if (skincount[i] <= 0)
            {
                skins[i].SetActive(false);
            }else skins[i].SetActive(true);
        }
    }
    //clother
    public void CheckClothersOnEnable()
    {
        for (int i = 0; i <= 24; i++)
        {
            textClother[i].text = clotherCount[i].ToString();
            if (clotherCount[i] <= 0)
            {
                clothers[i].SetActive(false);
            }
            else clothers[i].SetActive(true);
        }
    }
    public void GetDataClother()
    {
        clotherCount[0] = clotherManager.GetAo1();
        clotherCount[1] = clotherManager.GetAo2();
        clotherCount[2] = clotherManager.GetAo3();
        clotherCount[3] = clotherManager.GetAo4();
        clotherCount[4] = clotherManager.GetAo5();
        clotherCount[5] = clotherManager.GetQuan1();
        clotherCount[6] = clotherManager.GetQuan2();
        clotherCount[7] = clotherManager.GetQuan3();
        clotherCount[8] = clotherManager.GetQuan4();
        clotherCount[9] = clotherManager.GetQuan5();
        clotherCount[10] = clotherManager.GetGang1();
        clotherCount[11] = clotherManager.GetGang2();
        clotherCount[12] = clotherManager.GetGang3();
        clotherCount[13] = clotherManager.GetGang4();
        clotherCount[14] = clotherManager.GetGang5();
        clotherCount[15] = clotherManager.GetGiay1();
        clotherCount[16] = clotherManager.GetGiay2();
        clotherCount[17] = clotherManager.GetGiay3();
        clotherCount[18] = clotherManager.GetGiay4();
        clotherCount[19] = clotherManager.GetGiay5();
        clotherCount[20] = clotherManager.GetRada1();
        clotherCount[21] = clotherManager.GetRada2();
        clotherCount[22] = clotherManager.GetRada3();
        clotherCount[23] = clotherManager.GetRada4();
        clotherCount[24] = clotherManager.GetRada5();
    }

    //Item
    public void GetDataItem()
    {
        itemCount[0] = itemController.GetBuaCam();
        itemCount[1] = itemController.GetBuaDo();
        itemCount[2] = itemController.GetBuaVang();
        itemCount[3] = itemController.GetBuaTim();
        itemCount[4] = itemController.GetBuaXanhDuong();
        itemCount[5] = itemController.GetBuaxanhla();
        itemCount[6] = itemController.GetBuaXam();
        itemCount[7] = itemController.GetDaRuby();
        itemCount[8] = itemController.GetDaTiTan();
        itemCount[9] = itemController.GetDaThachAnh();
        itemCount[10] = itemController.GetDaShaphia();
        itemCount[11] = itemController.GetDaLucBao();
        itemCount[12] = itemController.GetDaNguSac();
    }
    
    public void CheckItemOnEnable()
    {
        for (int i = 0; i <= 12; i++)
        {
            textItemCout[i].text= itemCount[i].ToString();
            if (itemCount[i] <= 0)
            {
                item[i].SetActive(false);
            }
            else item[i].SetActive(true);
        }
    }
}
