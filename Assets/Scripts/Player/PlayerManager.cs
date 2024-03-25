using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
   
    public ClothersController clothers;
    public PlayerLife playerLife;
    public BackPack backPack;
    [Header("Laymark")]
    public LayerMask item;
    public LayerMask boss;
    public LayerMask enemy;
    public LayerMask player;

    private void Awake()
    {
        IgnorePlayer();
    }
    private void OnValidate()
    {
        backPack=GetComponentInChildren<BackPack>();
        clothers=GetComponentInChildren<ClothersController>();
        playerLife=GetComponentInChildren<PlayerLife>();
    }
    void Start()
    {
        
    }

    
    void Update()
    {
        playerLife.SetLevel(1);
        playerLife.SetHPEquip(clothers.GetHP());
        playerLife.SetHPStar(50);
        playerLife.GetHpLevel();
        playerLife.SetHPTotal();
        playerLife.GetSM();
       
    }

    protected virtual void IgnorePlayer()
    {
        
        Physics2D.IgnoreLayerCollision(8, 11);
        Physics2D.IgnoreLayerCollision(8, 9);
        Physics2D.IgnoreLayerCollision(9, 9);
        Physics2D.IgnoreLayerCollision(8, 10);
        
        
    }
}
