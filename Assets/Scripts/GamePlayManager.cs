using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class GamePlayManager : MonoBehaviour
{
    public GameObject textboxPlayerDeath;
    public GameObject player;
    public PlayerLife playerLife;
    public ItemController itemController;
    public MapController mapController;
    public GameObject textTb;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    public void Revival()
    {
        if (itemController.GetDiamond() >= 300)
        {
            itemController.MinusDiamond(300);
            player.SetActive(true);
            playerLife.SetHPCurrent(playerLife.GetHPTotal());
            playerLife.SetKICurrent(playerLife.GetKITotal());
            textboxPlayerDeath.SetActive(false);
        }
        else
        {
            return;
        }
        
    }

    public void GoHome()
    {
        mapController.SetMapGoHome();
        playerLife.SetHPCurrent(playerLife.GetHPTotal());
        playerLife.SetKICurrent(playerLife.GetKITotal());
    }
}


    