using System.Collections;
using System.Collections.Generic;
using System.IO;
using Unity.VisualScripting;
using UnityEngine;

public class SaveAndLoadData : MonoBehaviour
{
    [Header("Script")]
    public PlayerLife playerLife;
    public PlayerManager playerManager;
    public ItemController itemController;
    public ClotherManager clotherManager;
    public ClothersController clothersController;
    public SkinManager skinManager;
    public MapController mapController;
    public PlayerSkinController playerSkinController;
    public DotPhaController dotPhaController;
    public SaoHoMenhController saoHoMenhController;
    public SkillController skillController;
    public BackPackManager backPackManager;
    public BackPack backPack;
    public PlayerAura playerAura;
    public MissionController missionController;
    public Mission mission;

    private void Awake()
    {
       
        LoadData();
    }
    private void Start()
    {

       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SaveData()
    {
        SaveDataSkin();
        SavePlayerLife();
        SaveDataBackPack();
        SaveDataSkill();
        SaveDataAura();
        SaveDataClother();
        SaveDataItem();
        SaveDataDotPha();
        SaveDataSaoHoMenh();
        SaveDataMap();
        SaveDataMission();
    }
    public void LoadData()
    {
        LoadPlayerLife();
        LoadDataSkin();
        LoadDataBackPack();
        LoadDataSkill();
        LoadDataAura();
        LoadDataClother();
        LoadDataItem();
        LoadDataDotPha();
        LoadDataSaoHoMenh() ;
        LoadDataMap();
        LoadDataMission();
        playerManager.SetData();
        playerManager.SetTotalData();
    }
    //Mission
    public void SaveDataMission()
    {
        PlayerPrefs.SetInt("MissionCurrent",missionController.missionCurrent);
        string json1 = JsonUtility.ToJson(mission);
        string filePath = Path.Combine(Application.persistentDataPath, "Mission.json");
        File.WriteAllText(filePath, json1);
    }
    public void LoadDataMission()
    {
        missionController.missionCurrent = PlayerPrefs.GetInt("MissionCurrent");

        string filePath = Path.Combine(Application.persistentDataPath, "Mission.json");
        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            JsonUtility.FromJsonOverwrite(json, mission);
        }
        
        
    }
    //skin
    
    public void SaveDataSkin()
    {
        PlayerPrefs.SetInt("SkinIndex", playerSkinController.GetSkinIndex());
        PlayerPrefs.SetInt("SkinIndexLevel", playerSkinController.GetSkinIndexLevel());
        if (playerSkinController.isSkin == true)
        {
            PlayerPrefs.SetInt("IsSkin", 1);
        }
        else
        {
            PlayerPrefs.SetInt("IsSkin", 0);
        }
       
        string json1 = JsonUtility.ToJson(skinManager);
        string filePath = Path.Combine(Application.persistentDataPath, "SkinManager.json");
        File.WriteAllText(filePath, json1);
    }
    public void LoadDataSkin()
    {

        playerSkinController.SetSkinIndex(PlayerPrefs.GetInt("SkinIndex"));
        playerSkinController.SetSkinIndexLevel(PlayerPrefs.GetInt("SkinIndexLevel"));
        if (PlayerPrefs.GetInt("IsSkin") == 1)
        {
            playerSkinController.SetIsSkin(true);
        }
        else
        {
            playerSkinController.SetIsSkin(false);
        }
        string filePath = Path.Combine(Application.persistentDataPath, "SkinManager.json");
        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            JsonUtility.FromJsonOverwrite(json, skinManager);
        }
        


    }
    //life
    public void SavePlayerLife()
    {
        string json = JsonUtility.ToJson(playerLife);
        string filePath = Path.Combine(Application.persistentDataPath, "PlayerLife.json");
        File.WriteAllText(filePath, json);
        
    }

    public void LoadPlayerLife()
    {
        string filePath = Path.Combine(Application.persistentDataPath, "PlayerLife.json");
       
        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            JsonUtility.FromJsonOverwrite(json, playerLife);
        }
           
        
    }
    //backPack
    public void SaveDataBackPack()
    {
        PlayerPrefs.SetInt("IndexBackPack", backPack.indexBackPack);
        if (backPack.isBackPack == true)
        {
            PlayerPrefs.SetInt("IsBackPack", 1);
        }
        else
        {
            PlayerPrefs.SetInt("IsBackPack", 0);
        }
        string json = JsonUtility.ToJson(backPackManager);
        string filePath = Path.Combine(Application.persistentDataPath, "BackPackManager.json");
        File.WriteAllText(filePath, json);

    }
    public void LoadDataBackPack()
    {
        backPack.indexBackPack = PlayerPrefs.GetInt("IndexBackPack");
        if (PlayerPrefs.GetInt("IsBackPack") == 1)
        {
            backPack.isBackPack = true;
        }
        else
        {
            backPack.isBackPack = false;
        }
        string filePath = Path.Combine(Application.persistentDataPath, "BackPackManager.json");

        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            JsonUtility.FromJsonOverwrite(json, backPackManager);
        }
    }
    //Skill
    public void SaveDataSkill()
    {
        PlayerPrefs.SetInt("LevelSkill1", skillController.levelSkill[0]);
        PlayerPrefs.SetInt("LevelSkill2", skillController.levelSkill[1]);
        PlayerPrefs.SetInt("LevelSkill3", skillController.levelSkill[2]);
        PlayerPrefs.SetInt("LevelSkill4", skillController.levelSkill[3]);
        PlayerPrefs.SetInt("LevelSkill5", skillController.levelSkill[4]);
        PlayerPrefs.SetInt("LevelSkill6", skillController.levelSkill[5]);
        
    }
    public void LoadDataSkill()
    {
        if (PlayerPrefs.GetInt("LevelSkill1") < 1)
        {
            skillController.levelSkill[0] = 1;
        }
        else
        {
            skillController.levelSkill[0] = PlayerPrefs.GetInt("LevelSkill1");
        }


        if (PlayerPrefs.GetInt("LevelSkill2") < 1)
        {
            skillController.levelSkill[1] = 1;
        }
        else
        {
            skillController.levelSkill[1] = PlayerPrefs.GetInt("LevelSkill2");
        }


        if (PlayerPrefs.GetInt("LevelSkill3") < 1)
        {
            skillController.levelSkill[2] = 1;
        }
        else
        {
            skillController.levelSkill[2] = PlayerPrefs.GetInt("LevelSkill3");
        }


        if (PlayerPrefs.GetInt("LevelSkill4") < 1)
        {
            skillController.levelSkill[3] = 1;
        }
        else
        {
            skillController.levelSkill[3] = PlayerPrefs.GetInt("LevelSkill4");
        }


        if (PlayerPrefs.GetInt("LevelSkill5") < 1)
        {
            skillController.levelSkill[4] = 1;
        }
        else
        {
            skillController.levelSkill[4] = PlayerPrefs.GetInt("LevelSkill5");
        }

        if (PlayerPrefs.GetInt("LevelSkill6") < 1)
        {
            skillController.levelSkill[5] = 1;
        }
        else
        {
            skillController.levelSkill[5] = PlayerPrefs.GetInt("LevelSkill6");
        }

    }
    //aura
    public void SaveDataAura()
    {
        PlayerPrefs.SetInt("IndexAura", playerAura._auraIndex);
        PlayerPrefs.SetInt("PreAura", playerAura._preIndex);
        if (playerAura.isAura == true)
        {
            PlayerPrefs.SetInt("IsAura", 1);
        }
        else
        {
            PlayerPrefs.SetInt("IsAura", 0);
        }
    }
    public void LoadDataAura()
    {
        playerAura._auraIndex = PlayerPrefs.GetInt("IndexAura");
        playerAura._preIndex = PlayerPrefs.GetInt("PreAura");
        if (PlayerPrefs.GetInt("IsAura") == 1)
        {
            playerAura.isAura = true;
        }
        else
        {
            playerAura.isAura = false;
        }
    }
    //clother
    public void SaveDataClother()
    {
        string json = JsonUtility.ToJson(clotherManager);
        string filePath = Path.Combine(Application.persistentDataPath, "ClotherManager.json");
        File.WriteAllText(filePath, json);
        PlayerPrefs.SetInt("IndexAo", clothersController.indexClothers);
        PlayerPrefs.SetInt("IndexQuan", clothersController.indexquan);
        PlayerPrefs.SetInt("IndexGang", clothersController.indexgang);
        PlayerPrefs.SetInt("IndexGiay", clothersController.indexgiay);
        PlayerPrefs.SetInt("IndexRada", clothersController.indexrada);
        
        if (clothersController.isAo == true)
        {
            PlayerPrefs.SetInt("IsAo", 1);
        }
        else
        {
            PlayerPrefs.SetInt("IsAo", 0);
        }
        if (clothersController.isQuan== true)
        {
            PlayerPrefs.SetInt("IsQuan", 1);
        }
        else
        {
            PlayerPrefs.SetInt("IsQuan", 0);
        }
        if (clothersController.isGang == true)
        {
            PlayerPrefs.SetInt("IsGang", 1);
        }
        else
        {
            PlayerPrefs.SetInt("IsGang", 0);
        }
        if (clothersController.isGiay == true)
        {
            PlayerPrefs.SetInt("IsGiay", 1);
        }
        else
        {
            PlayerPrefs.SetInt("IsGiay", 0);
        }
        if (clothersController.isRaDa == true)
        {
            PlayerPrefs.SetInt("IsRada", 1);
        }
        else
        {
            PlayerPrefs.SetInt("IsRada", 0);
        }
    }
    public void LoadDataClother()
    {
        string filePath = Path.Combine(Application.persistentDataPath, "ClotherManager.json");

        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            JsonUtility.FromJsonOverwrite(json, clotherManager);
        }
        clothersController.indexClothers = PlayerPrefs.GetInt("IndexAo");
        clothersController.indexquan = PlayerPrefs.GetInt("IndexQuan");
        clothersController.indexgang = PlayerPrefs.GetInt("IndexGang");
        clothersController.indexgiay = PlayerPrefs.GetInt("IndexGiay");
        clothersController.indexrada = PlayerPrefs.GetInt("IndexRada");
        if (PlayerPrefs.GetInt("IsRada") == 1)
        {
            clothersController.isRaDa = true;
        }
        else
        {
            clothersController.isRaDa=false;
        }

        if (PlayerPrefs.GetInt("IsAo") == 1)
        {
            clothersController.isAo = true;
        }
        else
        {
            clothersController.isAo = false;
        }
        if (PlayerPrefs.GetInt("IsQuan") == 1)
        {
            clothersController.isQuan = true;
        }
        else
        {
            clothersController.isQuan = false;
        }
        if (PlayerPrefs.GetInt("IsGang") == 1)
        {
            clothersController.isGang = true;
        }
        else
        {
            clothersController.isGang = false;
        }
        if (PlayerPrefs.GetInt("IsGiay") == 1)
        {
            clothersController.isGiay = true;
        }
        else
        {
            clothersController.isGiay = false;
        }
    }
    //Item
    public void SaveDataItem()
    {
        string json = JsonUtility.ToJson(itemController);
        string filePath = Path.Combine(Application.persistentDataPath, "Itemcontroller.json");
        File.WriteAllText(filePath, json);
    }
    public void LoadDataItem()
    {
        string filePath = Path.Combine(Application.persistentDataPath, "Itemcontroller.json");

        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            JsonUtility.FromJsonOverwrite(json, itemController);
        }
    }
    //dotpha
    public void SaveDataDotPha()
    {
        PlayerPrefs.SetInt("LevelHP1",dotPhaController.GetLevelHP());
        PlayerPrefs.SetInt("LevelKI1", dotPhaController.GetLevelKI());
        PlayerPrefs.SetInt("LevelATK1", dotPhaController.GetLevelATK());
        PlayerPrefs.SetInt("LevelDEF1", dotPhaController.GetLevelDEF());
        PlayerPrefs.SetInt("LevelCrit1", dotPhaController.GetLevelCrit());
        PlayerPrefs.SetInt("LevelCritDMG1", dotPhaController.GetLevelCritDMG());
        PlayerPrefs.SetInt("LevelStamina1", dotPhaController.GetLevelStamina());

    }
    public void LoadDataDotPha()
    {
        dotPhaController._levelHP = PlayerPrefs.GetInt("LevelHP1");
        dotPhaController._levelKI = PlayerPrefs.GetInt("LevelKI1");
        dotPhaController._levelATK = PlayerPrefs.GetInt("LevelATK1");
        dotPhaController._levelDEF= PlayerPrefs.GetInt("LevelDEF1");
        dotPhaController._levelCrit = PlayerPrefs.GetInt("LevelCrit1");
        dotPhaController._levelCritDMG = PlayerPrefs.GetInt("LevelCritDMG1");
        dotPhaController._levelStamina = PlayerPrefs.GetInt("LevelStamina1");

    }
    //saohomenh
    public void SaveDataSaoHoMenh()
    {
        PlayerPrefs.SetInt("LevelHP", saoHoMenhController.GetLevelHP());
        PlayerPrefs.SetInt("LevelKI", saoHoMenhController.GetLevelKI());
        PlayerPrefs.SetInt("LevelATK", saoHoMenhController.GetLevelATK());
        PlayerPrefs.SetInt("LevelDEF", saoHoMenhController.GetLevelDEF());
        PlayerPrefs.SetInt("LevelCrit", saoHoMenhController.GetLevelCrit());
        PlayerPrefs.SetInt("LevelCritDMG", saoHoMenhController.GetLevelCritDMG());
        PlayerPrefs.SetInt("LevelStamina", saoHoMenhController.GetLevelStamina());

    }
    public void LoadDataSaoHoMenh()
    {
        saoHoMenhController._levelHP = PlayerPrefs.GetInt("LevelHP");
        saoHoMenhController._levelKI = PlayerPrefs.GetInt("LevelKI");
        saoHoMenhController._levelATK = PlayerPrefs.GetInt("LevelATK");
        saoHoMenhController._levelDEF = PlayerPrefs.GetInt("LevelDEF");
        saoHoMenhController._levelCrit = PlayerPrefs.GetInt("LevelCrit");
        saoHoMenhController._levelCritDMG = PlayerPrefs.GetInt("LevelCritDMG");
        saoHoMenhController._levelStamina = PlayerPrefs.GetInt("LevelStamina");

    }
    //map
    public void SaveDataMap()
    {
        PlayerPrefs.SetInt("IndexMap", mapController._mapIndex);
        PlayerPrefs.SetInt("IndexMap2", mapController._mapIndex2);
        PlayerPrefs.SetFloat("Positix", mapController.positionPlayer.x);
        PlayerPrefs.SetFloat("Positiy", mapController.positionPlayer.y);

    }
    public void LoadDataMap()
    {
        mapController._mapIndex = PlayerPrefs.GetInt("IndexMap");
        mapController._mapIndex2 = PlayerPrefs.GetInt("IndexMap2");
        mapController.positionPlayer = new Vector2(PlayerPrefs.GetFloat("Positix"), PlayerPrefs.GetFloat("Positiy"));

    }

    private void OnApplicationQuit()
    {
        SaveData();
        return;
    }

}
