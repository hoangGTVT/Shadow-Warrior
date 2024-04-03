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
    public GameObject[] _textPopUp;
    public Transform pointPopUP;
    [Header("Laymark")]
    public LayerMask item;
    public LayerMask boss;
    public LayerMask enemy;
    public LayerMask player;

    private void Awake()
    {
        IgnorePlayer();
        SetData();
        SetTotalData();
        playerLife.SetHPCurrent();
        playerLife.SetKICurrent();

    }
    private void OnValidate()
    {
        backPack=GetComponentInChildren<BackPack>();
        clothers=GetComponentInChildren<ClothersController>();
        playerLife=GetComponentInChildren<PlayerLife>();
        skin=GetComponentInChildren<PlayerSkinController>();
        hoMenh=GetComponentInChildren<SaoHoMenhController>();
        dotPha=GetComponentInChildren<DotPhaController>();
    }
    public void SetTotalData()
    {
        playerLife.SetHPTotal();
       
        playerLife.SetKITotal();
        
        playerLife.SetATKTotal();
        playerLife.SetDEFTotal();
        playerLife.SetCritTotal();
        playerLife.SetCritDMGTotal();
        playerLife.SetStaTotal();
        playerLife.SetStaCurrent();
        playerLife.GetSM();
        /*UIBarPlayer.Instance.SetMaxHP(playerLife.GetHPTotal());

        UIBarPlayer.Instance.SetMaxKI(playerLife.GetKITotal());*/
    }
    public void SetData()
    {
        //HP
        playerLife.SetHPDP(dotPha.GetHpDotPha());
        playerLife.SetHPStar(hoMenh.GetHpSaoHoMenh());
        playerLife.SetHPSkin(skin.skinSO[skin.skinIndex].GetHP());
        playerLife.SetHPBaclPack(backPack.GetHP());
        playerLife.SetHPEquip(clothers.GetHPQuan());
        //KI
        playerLife.SetKIDP(dotPha.GetKiDotPha());
        playerLife.SetKIStar(hoMenh.GetKiSaoHoMenh());
        playerLife.SetKISkin(skin.skinSO[skin.skinIndex].GetKI());
        playerLife.SetKIBaclPack(backPack.GetKI());
        playerLife.SetKIEquip(clothers.GetKIGiay());
        //ATK\
        playerLife.SetATKDP(dotPha.GetAtkDotPha());
        playerLife.SetATKStar(hoMenh.GetAtkSaoHoMenh());
        playerLife.SetATKSkin(skin.skinSO[skin.skinIndex].GetATK());
        playerLife.SetATKBaclPack(backPack.GetATK());
        playerLife.SetATKEquip(clothers.GetATKGang());
        //DEF
        playerLife.SetDEFDP(dotPha.GetDefDotPha());
        playerLife.SetDEFStar(hoMenh.GetDefSaoHoMenh());
        playerLife.SetDEFSkin(skin.skinSO[skin.skinIndex].GetDef());
        playerLife.SetDEFBaclPack(backPack.GetDEF());
        playerLife.SetDEFEquip(clothers.GetDefAo());
        //Crit
        playerLife.SetCritDP(dotPha.GetCritDotPha());
        playerLife.SetCritStar(hoMenh.GetCritSaoHoMenh());
        playerLife.SetCritSkin(skin.skinSO[skin.skinIndex].GetCritRate());
        playerLife.SetCritBaclPack(backPack.GetCrit());
        playerLife.SetCritEquip(clothers.GetCritRada());
        //CritDMG
        playerLife.SetCritDMGDP(dotPha.GetCritDMGDotPha());
        playerLife.SetCritDMGStar(hoMenh.GetCritDMGSaoHoMenh());
        playerLife.SetCritDMGSkin(skin.skinSO[skin.skinIndex].GetCritDMG());
        playerLife.SetCritDMGBaclPack(backPack.GetCritDMG());
        playerLife.SetCritDMGEquip(clothers.GetCritDMGRada());
        //Stamina
        playerLife.SetStaDP(dotPha.GetStaminaDotPha());
        playerLife.SetStaStar(hoMenh.GetStaminaSaoHoMenh());
        playerLife.SetStaminaSkin(skin.skinSO[skin.skinIndex].GetStamina());
        playerLife.SetStaBackPack(backPack.GetSta());
        playerLife.SetStaEquip(clothers.GetStaminaRaDa());
    }



    void Update()
    {
        SetData();
        SetTotalData();
        if (Input.GetKeyDown(KeyCode.K))
        {
            PlayerTakeDamage(2000);
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            HealHP(200);
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
    }

    public void HealHP(int index)
    {
        playerLife.PlusHPCurrent(index);
        CreateTextPopUp(0, index, "+");

    }

    public void HealKi(int index)
    {
        playerLife.PlusKICurrent(index);
        CreateTextPopUp(1, index, "+");
    }
    public void minusKI(int index)
    {
        playerLife.MinusKICurrent(index);
        CreateTextPopUp(1, index, "-");
    }
    public void CreateTextPopUp(int index, int number, string t)
    {

        GameObject pos = Instantiate(_textPopUp[index], new Vector3(pointPopUP.transform.position.x,pointPopUP.transform.position.y, pointPopUP.transform.position.z), quaternion.identity);
        pos.GetComponentInChildren<TextMeshProUGUI>().text = t + number;
        Destroy(pos, 0.7f);
        
    }
    

    
}
