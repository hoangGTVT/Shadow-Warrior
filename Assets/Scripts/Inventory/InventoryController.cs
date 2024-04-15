using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using TMPro;
using UnityEngine;

public class InventoryController : MonoBehaviour
{
    [Header("Script")]
    public ItemController itemController;
    public ClotherManager clotherManager;
    public SkinManager skinManager;
    public BackPackManager backPackManager;
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
    [Header("BackPack")]
    public GameObject[] backPacks;
    public int[] backPackCount;
    public TextMeshProUGUI[] textBackPack;
    public TextMeshProUGUI gold;
    public TextMeshProUGUI diamond;
    [Header("Inventory")]
    public GameObject origonobject;
    public GameObject[] _cloneObject;
    public GameObject object2;

    private void OnEnable()
    {
        GetDataItem();
        GetDataClother();
        GetDataSkin();
        GetDataBackPack();
        
    }

    private void FixedUpdate()
    {
        GetDataBackPack();
            CheckBackPackOnenable();
        GetDataSkin();
        CheckSkinsOnEnable();
        CheckItemOnEnable();
        GetDataItem();
        CheckClothersOnEnable();
        GetDataClother();
        gold.text=itemController.GetGold().ToString("#,#");
        diamond.text = itemController.GetDiamond().ToString("#,#");
    }
    //BackPack
    public void GetDataBackPack()
    {
        for(int i = 0; i < 8; i++)
        {
            backPackCount[i] = backPackManager.GetBackPack(i);
        }
    }
    public void CheckBackPackOnenable()
    {
        for(int i = 0; i <= 8; i++)
        {
            textBackPack[i].text = backPackCount[i].ToString();
            if (backPackCount[i] <= 0)
            {
                backPacks[i].SetActive(false);
            }else backPacks[i].SetActive(true);
        }
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
            if (clotherCount[i] < 1)
            {
               
                clothers[i].SetActive(false);
            }
            else clothers[i].SetActive(true);
        }
    }

   /* public void CreateItem(GameObject gameObject, int number,GameObject target)
    {
        
        
        for(int i = 0; i < _cloneObject.Length; i++)
        {
            _cloneObject[i].SetActive(false);
            _cloneObject[i].transform.SetParent(object2.transform);
        }
        for (int i = 0; i < number-1; i++)
        {
            GameObject clone = Instantiate(gameObject, target.transform.position, Quaternion.identity);
            clone.transform.SetParent(origonobject.transform);
        }
        for (int i = 0; i < _cloneObject.Length- number; i++)
        {
            _cloneObject[i].transform.SetParent(origonobject.transform);
            _cloneObject[i].SetActive(true);
        }


    }*/
    public void GetDataClother()
    {
        clotherCount[0] = clotherManager.GetAo(0);
        clotherCount[1] = clotherManager.GetAo(1);
        clotherCount[2] = clotherManager.GetAo(2);
        clotherCount[3] = clotherManager.GetAo(3);
        clotherCount[4] = clotherManager.GetAo(4);
        clotherCount[5] = clotherManager.GetQuan(0);
        clotherCount[6] = clotherManager.GetQuan(1);
        clotherCount[7] = clotherManager.GetQuan(2);
        clotherCount[8] = clotherManager.GetQuan(3);
        clotherCount[9] = clotherManager.GetQuan(4);
        clotherCount[10] = clotherManager.GetGang(0);
        clotherCount[11] = clotherManager.GetGang(1);
        clotherCount[12] = clotherManager.GetGang(2);
        clotherCount[13] = clotherManager.GetGang(3);
        clotherCount[14] = clotherManager.GetGang(4);
        clotherCount[15] = clotherManager.GetGiay(0);
        clotherCount[16] = clotherManager.GetGiay(1);
        clotherCount[17] = clotherManager.GetGiay(2);
        clotherCount[18] = clotherManager.GetGiay(3);
        clotherCount[19] = clotherManager.GetGiay(4);
        clotherCount[20] = clotherManager.GetRada(0);
        clotherCount[21] = clotherManager.GetRada(1);
        clotherCount[22] = clotherManager.GetRada(2);
        clotherCount[23] = clotherManager.GetRada(3);
        clotherCount[24] = clotherManager.GetRada(4);
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
