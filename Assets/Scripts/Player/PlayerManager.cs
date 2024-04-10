using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Mathematics;
using UnityEditor.Timeline.Actions;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
   
    public ClothersController clothers;
    public PlayerSkinController skin;
    public SaoHoMenhController hoMenh;
    public DotPhaController dotPha;
    public PlayerLife playerLife;
    public BackPack backPack;
    public PlayerAura playerAura;
    [Header("GameObject")]
    public GameObject[] _textPopUp;
    public Transform pointPopUP;
    public GameObject textBoxDeath;
    

    private void Awake()
    {
        IgnorePlayer();
        SetData();
        SetTotalData();
        playerLife.SetHPCurrent(playerLife.GetHPTotal());
        playerLife.SetKICurrent(playerLife.GetKITotal());
       
    }
    private void OnValidate()
    {
        backPack=GetComponentInChildren<BackPack>();
        clothers=GetComponentInChildren<ClothersController>();
        playerLife=GetComponentInChildren<PlayerLife>();
        skin=GetComponentInChildren<PlayerSkinController>();
        hoMenh=GetComponentInChildren<SaoHoMenhController>();
        dotPha=GetComponentInChildren<DotPhaController>();
        playerAura = GetComponentInChildren<PlayerAura>();
    }
    public void SetTotalData()
    {
        
        playerLife.SetHPTotal();
        playerLife.SetKITotal();
        if (playerLife.GetHPTotal() < playerLife.GetHPCurrent()) { playerLife.SetHPCurrent(playerLife.GetHPTotal()); }
        if (playerLife.GetKITotal() < playerLife.GetKICurrent()) { playerLife.SetKICurrent(playerLife.GetKITotal()); }
        playerLife.SetATKTotal();
        playerLife.SetDEFTotal();
        playerLife.SetCritTotal();
        playerLife.SetCritDMGTotal();
        playerLife.SetStaTotal();
        playerLife.SetStaCurrent();
        playerLife.GetSM();
        UIBarPlayer.Instance.SetMaxHP(playerLife.GetHPTotal());

        UIBarPlayer.Instance.SetMaxKI(playerLife.GetKITotal());
    }
    public void SetData()
    {
        //Skin
       
        
        if (skin.GetIsSkin() == true)
        {
            playerLife.SetHPSkin(skin.skinSO[skin.skinIndexLevel].GetHP() + skin.skinSO[skin.skinIndex].GetHP());
            playerLife.SetKISkin(skin.skinSO[skin.skinIndexLevel].GetKI()+ skin.skinSO[skin.skinIndex].GetKI());
            playerLife.SetATKSkin(skin.skinSO[skin.skinIndexLevel].GetATK() + skin.skinSO[skin.skinIndex].GetATK());
            playerLife.SetDEFSkin(skin.skinSO[skin.skinIndexLevel].GetDef() + skin.skinSO[skin.skinIndex].GetDef());
            playerLife.SetCritSkin(skin.skinSO[skin.skinIndexLevel].GetCritRate() + skin.skinSO[skin.skinIndex].GetCritRate());
            playerLife.SetCritDMGSkin(skin.skinSO[skin.skinIndexLevel].GetCritDMG() + skin.skinSO[skin.skinIndex].GetCritDMG());
            playerLife.SetStaminaSkin(skin.skinSO[skin.skinIndexLevel].GetStamina() + skin.skinSO[skin.skinIndex].GetStamina());
        }
        else { 
            playerLife.SetHPSkin(skin.skinSO[skin.skinIndexLevel].GetHP());
            playerLife.SetKISkin(skin.skinSO[skin.skinIndexLevel].GetKI());
            playerLife.SetATKSkin(skin.skinSO[skin.skinIndexLevel].GetATK());
            playerLife.SetDEFSkin(skin.skinSO[skin.skinIndexLevel].GetDef());
            playerLife.SetCritSkin(skin.skinSO[skin.skinIndexLevel].GetCritRate());
            playerLife.SetCritDMGSkin(skin.skinSO[skin.skinIndexLevel].GetCritDMG());
            playerLife.SetStaminaSkin(skin.skinSO[skin.skinIndexLevel].GetStamina());
        }
        //equip
        //Ao
        if (clothers.GetIsAo() == true)
        {
            playerLife.SetDEFEquip(clothers.GetDefAo());
        }else { playerLife.SetDEFEquip(0); }
        //Quan
        if (clothers.GetIsQuan() == true) { playerLife.SetHPEquip(clothers.GetHPQuan()); } else { playerLife.SetHPEquip(0); }
        //Gang
        if(clothers.GetIsGang() == true) { playerLife.SetATKEquip(clothers.GetATKGang()); } else { playerLife.SetATKEquip(0); }
        //Giay
        if(clothers.GetIsGiay()==true) { playerLife.SetKIEquip(clothers.GetKIGiay()); } else { playerLife.SetKIEquip(0); }
        //rada
        if(clothers.GetIsRaDa() == true)
        {
            playerLife.SetCritEquip(clothers.GetCritRada());
            playerLife.SetCritDMGEquip(clothers.GetCritDMGRada());
            playerLife.SetStaEquip(clothers.GetStaminaRaDa());
        }
        else
        {
            playerLife.SetCritEquip(0);
            playerLife.SetCritDMGEquip(0);
            playerLife.SetStaEquip(0);

        }
        //backpack
        if (backPack.GetIsBackPack() == true)
        {
            playerLife.SetHPBaclPack(backPack.GetHP());
            playerLife.SetKIBaclPack(backPack.GetKI());
            playerLife.SetATKBaclPack(backPack.GetATK());
            playerLife.SetDEFBaclPack(backPack.GetDEF());
            playerLife.SetCritBaclPack(backPack.GetCrit());
            playerLife.SetCritDMGBaclPack(backPack.GetCritDMG());
            playerLife.SetStaBackPack(backPack.GetSta());
        }
        else {
            playerLife.SetHPBaclPack(0);
            playerLife.SetKIBaclPack(0);
            playerLife.SetATKBaclPack(0);
            playerLife.SetDEFBaclPack(0);
            playerLife.SetCritBaclPack(0);
            playerLife.SetCritDMGBaclPack(0);
            playerLife.SetStaBackPack(0);
        }
        //DotPha

        playerLife.SetHPDP(dotPha.GetHpDotPha());
        playerLife.SetHPStar(hoMenh.GetHpSaoHoMenh());

        //KI
        playerLife.SetKIDP(dotPha.GetKiDotPha());
        playerLife.SetKIStar(hoMenh.GetKiSaoHoMenh());
       
        //ATK\
        playerLife.SetATKDP(dotPha.GetAtkDotPha());
        playerLife.SetATKStar(hoMenh.GetAtkSaoHoMenh());
        //DEF
        playerLife.SetDEFDP(dotPha.GetDefDotPha());
        playerLife.SetDEFStar(hoMenh.GetDefSaoHoMenh());
        //Crit
        playerLife.SetCritDP(dotPha.GetCritDotPha());
        playerLife.SetCritStar(hoMenh.GetCritSaoHoMenh());
        //CritDMG
        playerLife.SetCritDMGDP(dotPha.GetCritDMGDotPha());
        playerLife.SetCritDMGStar(hoMenh.GetCritDMGSaoHoMenh());
        //Stamina
        playerLife.SetStaDP(dotPha.GetStaminaDotPha());
        playerLife.SetStaStar(hoMenh.GetStaminaSaoHoMenh());
        //exp
        playerLife.SetEXPLevel();
    }



    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.K))
        {
            PlayerTakeDamage(20000);
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            HealHP(200);
            
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            PlayerDeath();

        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            PlayerTakeEXP(10000);

        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            clothers.SetIsAo(true);
            clothers.SetIsQuan(true);
            clothers.SetIsGang(true);
            clothers.SetIsGiay(true);
            clothers.SetIsRaDa(true);
            backPack.SetIsBackPack(true);
            SetData();
            SetTotalData();

        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            clothers.SetAo(1);
            clothers.SetGiay(2);
            clothers.SetGang(3);
            clothers.SetGiay(4);
            clothers.SetRada(3);
            backPack.SetBackPack(5);
            SetData();
            SetTotalData();

        }



    }

    protected virtual void IgnorePlayer()
    {
        
        Physics2D.IgnoreLayerCollision(8, 11);
        Physics2D.IgnoreLayerCollision(8, 9);
        Physics2D.IgnoreLayerCollision(9, 9);
        Physics2D.IgnoreLayerCollision(8, 10);
        
        
    }

    public void PlayerTakeDamage(int damage)
    {
        playerLife.MinusHPCurrent(damage);
        CreateTextPopUp(0, playerLife.HPMinus(damage),"-");
        if (playerLife.GetHPCurrent() <= 0)
        {
            PlayerDeath();
        }
    }

    public void PlayerTakeEXP(int exp)
    {
        if (playerLife.GetLevel() < 100)
        {
            playerLife.PlusEXPCurrent(exp);
            CreateTextPopUp(2, exp, "EXP + ");
            playerLife.PlusLevel();

            SetData();
            SetTotalData();
            long level = playerLife.GetLevel() / 10;
            switch (level)
            {
                case 0:
                    skin.SetSkinIndexLevel(0);
                    if (skin.GetIsSkin() == false) { skin.SetSkinIndex(0); }
                    
                    SetData();
                    SetTotalData();
                    break;
                case 1:
                    skin.SetSkinIndexLevel(1);
                    if (skin.GetIsSkin() == false) { skin.SetSkinIndex(1); }
                    SetData();
                    SetTotalData();
                    break;
                case 2:
                    skin.SetSkinIndexLevel(2);
                    if (skin.GetIsSkin() == false) { skin.SetSkinIndex(2); }
                    
                    SetData();
                    SetTotalData();
                    playerAura.SetIndexAura(0);
                    playerAura.SetIsAura(true);
                    break;
                case 3:
                    skin.SetSkinIndexLevel(3);
                    if (skin.GetIsSkin() == false) { skin.SetSkinIndex(3); }
                    SetData();
                    SetTotalData();
                    break;
                case 4:
                    skin.SetSkinIndexLevel(4);
                    if (skin.GetIsSkin() == false) { skin.SetSkinIndex(4); }
                    SetData();
                    SetTotalData();
                    playerAura.SetIndexAura(1);
                    playerAura.SetIsAura(true);
                    break;
                case 5:
                    skin.SetSkinIndexLevel(5);
                    if (skin.GetIsSkin() == false) { skin.SetSkinIndex(5); }
                    SetData();
                    SetTotalData();
                    break;
                case 6:
                    skin.SetSkinIndexLevel(6);
                    if (skin.GetIsSkin() == false) { skin.SetSkinIndex(6); }
                    SetData();
                    SetTotalData();
                    playerAura.SetIndexAura(2);
                    playerAura.SetIsAura(true);
                    break;
                case 7:
                    skin.SetSkinIndexLevel(7);
                    if (skin.GetIsSkin() == false) { skin.SetSkinIndex(7); }
                    SetData();
                    SetTotalData();
                    break;
                case 8:
                    skin.SetSkinIndexLevel(8);
                    if (skin.GetIsSkin() == false) { skin.SetSkinIndex(8); }
                    SetData();
                    SetTotalData();
                    playerAura.SetIndexAura(3);
                    playerAura.SetIsAura(true);
                    break;
                case 9:
                    skin.SetSkinIndexLevel(9);
                    if (skin.GetIsSkin() == false) { skin.SetSkinIndex(9); }
                    SetData();
                    SetTotalData();
                    break;
                case 10:
                    skin.SetSkinIndexLevel(10);
                    if (skin.GetIsSkin() == false) { skin.SetSkinIndex(10); }
                    SetData();
                    SetTotalData();
                    playerAura.SetIndexAura(4);
                    playerAura.SetIsAura(true);
                    break;


            }
        }
       
    }
    public void HealStamina(long index)
    {
        if (playerLife.GetStaminaCurrent() < playerLife.GetStaminaTotal())
        {
            playerLife.PlusStaCurrent(index);
            CreateTextPopUp(2, index, "+");
        }
        else return;
    }
    public void HealHP(long index)
    {
        if (playerLife.GetHPCurrent() < playerLife.GetHPTotal())
        {
            playerLife.PlusHPCurrent(index);
            CreateTextPopUp(0, index, "+");
        }
        else return;

    }

    public void HealKi(long index)
    {
        if (playerLife.GetKICurrent() < playerLife.GetKITotal())
        {
            playerLife.PlusKICurrent(index);
            CreateTextPopUp(1, index, "+");

        }
        else return;
        
    }
    public void MinusKI(long index)
    {
        playerLife.MinusKICurrent(index);
       
    }

    public void MinusStamina(long index)
    {
        playerLife.MinusStaCurrent(index);
    }
    public void CreateTextPopUp(int index, long number, string t)
    {

        GameObject pos = Instantiate(_textPopUp[index], new Vector3(pointPopUP.transform.position.x,pointPopUP.transform.position.y, pointPopUP.transform.position.z), quaternion.identity);
        pos.GetComponentInChildren<TextMeshProUGUI>().text = t + number;
        Destroy(pos, 0.7f);
        
    }

    public void PlayerDeath()
    {
        textBoxDeath.SetActive(true);
        gameObject.SetActive(false);
    }
    

    
}
