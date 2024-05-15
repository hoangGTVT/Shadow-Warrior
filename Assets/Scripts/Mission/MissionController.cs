using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MissionController : MonoBehaviour
{
    [Header("Script")]
    public GameObject[] missionss;
    public Mission mission;
    public PlayerLife playerLife;
    public DotPhaController dotPhaController;
    public SaoHoMenhController saoMenhController;
    public ItemController itemController;
    public SkinManager skinManager;
    public ClotherManager clotherManager;
    public BackPackManager backPackManager;
    public int missionCurrent;
    [Header("TextMission")]
    //nv1
    public TextMeshProUGUI numberMocNhan;
    //nv2
    public TextMeshProUGUI levelnv3;
    //3
    public TextMeshProUGUI numberBulon;
    public TextMeshProUGUI numberUkulele;
    public TextMeshProUGUI numberQuyMap;
    public TextMeshProUGUI sm;
    //nv9
    public TextMeshProUGUI numberKhiDotDotTruong;
    public TextMeshProUGUI numberKhiDotLongVang;
    public TextMeshProUGUI numberKhiDotLongDo;
    //nv10
    public TextMeshProUGUI numberCTZabon;
   
    //nv12
    public TextMeshProUGUI numBerBoss1;
    //nv13
    public TextMeshProUGUI numBerBoss2;
    //nv14
    public TextMeshProUGUI numBerBoss3;
    //nv15
    public TextMeshProUGUI numBerBoss4;
    void Start()
    {
        missionss[missionCurrent].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        ShowInfoNV();
    }
    //nv1
    public void CheckNv1()
    {
        if(Mission.instance.numberMocNhan>=10)
        {
            itemController.PlusGold(10000);
            itemController.PlusDiamond(500);
            FinishMission();
            Mission.instance.indexMission++;
        }
    }
    public void CheckNv2()
    {
        if (Mission.instance.numberBulon >= 15 && Mission.instance.numberUkulele >= 15 && Mission.instance.numberQuyMap >= 15)
        {
            itemController.PlusGold(20000);
            itemController.PlusDiamond(2000);
            FinishMission();
            Mission.instance.indexMission++;
        }
    }
    public void CheckNv3()
    {
        if (playerLife.GetLevel() >= 10)
        {
            itemController.PlusGold(20000);
            itemController.PlusDiamond(1000);
            backPackManager.PlusBackPack(7);
            FinishMission();
            Mission.instance.indexMission++;
        }
    }
    public void CheckNv4()
    {
        if (Mission.instance.numberBoss1 >= 1)
        {
            itemController.PlusGold(50000);
            itemController.PlusDiamond(5000);
            skinManager.PlusSkin(17);
            FinishMission();
            Mission.instance.indexMission++;
        }
    }
    public void CheckNv5()
    {

        if (playerLife.GetSM() >= 2500000)
        {
            itemController.PlusBuaCam(50);
            itemController.PlusBuaDo(50);
            itemController.PlusBuaTim(50);
            itemController.PlusBuaVang(50);
            itemController.PlusBuaXam(50);
            itemController.PlusBuaXanhDuong(50);
            itemController.PlusBuaXanhLa(50);

            FinishMission();
            Mission.instance.indexMission++;
        }
    }
    public void CheckNv6()
    {
        if (Mission.instance.numberBoss2 >= 2)
        {
            itemController.PlusGold(60000);
            itemController.PlusDiamond(5000);
            skinManager.PlusSkin(30);
            FinishMission();
            Mission.instance.indexMission++;
        }
    }
    public void CheckNv7()
    {
        if (Mission.instance.numberCaiTrangZabon >= 1)
        {
            itemController.PlusGold(30000);
            itemController.PlusDiamond(1000);
            itemController.PlusDaNguSac(20);
            FinishMission();
            Mission.instance.indexMission++;
        }
    }
    public void CheckNv8()
    {
        if (Mission.instance.numberBoss3 >= 3)
        {
            itemController.PlusGold(100000);
            itemController.PlusDiamond(10000);
            FinishMission();
            Mission.instance.indexMission++;
        }
    }
   
    public void CheckNv9()
    {
        if(Mission.instance.numberKhiDotDotTruong>=25&&
            Mission.instance.numberKhiDotLongDo>=25&&
            Mission.instance.numberKhiDotLongVang>=25
            
            )
        {
            itemController.PlusDaLucBao(60);
            itemController.PlusDaRuby(60);
            itemController.PlusDaShaphia(60);
            itemController.PlusDaThachAnh(60);
            itemController.PlusDaTiTan(60);
            FinishMission();
            Mission.instance.indexMission++;
        }
    }

    public void CheckNv10()
    {
        if (Mission.instance.numberBoss4 >= 10)
        {
            itemController.PlusGold(1);
            itemController.PlusDiamond(1);
            FinishMission();
            Mission.instance.indexMission++;
        }
    }

    public void FinishMission()
    {
        missionss[missionCurrent].SetActive(false);
        missionCurrent++;
        missionss[missionCurrent].SetActive(true);
    }

    public void ShowInfoNV()
    {
        numberMocNhan.text=Mission.instance.numberMocNhan.ToString();
        levelnv3.text = playerLife.GetLevel().ToString();
        numberBulon.text=Mission.instance.numberBulon.ToString();
        numberUkulele.text = Mission.instance.numberUkulele.ToString();
        numberQuyMap.text=Mission.instance.numberQuyMap.ToString();
        sm.text=Mission.instance.smPlayer.ToString("#,#");
        numBerBoss1.text=Mission.instance.numberBoss1.ToString();
        numBerBoss2.text = Mission.instance.numberBoss2.ToString();
        numBerBoss3.text = Mission.instance.numberBoss3.ToString();
        numBerBoss4.text = Mission.instance.numberBoss4.ToString();
        numberKhiDotDotTruong.text = Mission.instance.numberKhiDotDotTruong.ToString();
        numberKhiDotLongDo.text = Mission.instance.numberKhiDotLongDo.ToString();
        numberKhiDotLongVang.text=Mission.instance.numberKhiDotLongVang.ToString();

    }
}
