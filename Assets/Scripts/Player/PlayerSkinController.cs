using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSkinController : KameScript
{
    [SerializeField] private Head _playerHead;
    [SerializeField] private Body _playerBody;
    [SerializeField] private Leg _playerLeg;
    [SerializeField] private BackPack _backPack;
    [SerializeField] private PlayerAura _playerAura;
    [SerializeField] private PlayerMoment _playerMoment;
    [Header("Thay đổi trang phục khi mặc trang bị")]
    [SerializeField] ItemSO[] skinSO;
    public int skinIndex = 0;
    [Header("Thay đổi Vật phẩm đeo lưng")]
    [SerializeField] ItemSO[] backPack;
    public int backPackIndex = 0;
    private void Awake()
    {
        skinIndex = 0;
        backPackIndex = 0;
    }
    private void OnValidate()
    {
        _playerHead = GetComponentInChildren<Head>();
        _playerBody = GetComponentInChildren<Body>();
        _playerLeg = GetComponentInChildren<Leg>();
        //_backPack = GetComponentInChildren<BackPack>();
        _playerAura = GetComponentInChildren<PlayerAura>();
        _playerMoment = GetComponent<PlayerMoment>();
        LoadSkinSO();
        LoadBackPackSO();
    }
    
    protected virtual void LoadSkinSO()
    {
       if (skinSO != null)
        {
            GameObject gameObject = GameObject.Find("GameData");
            if (gameObject != null)
            {
                
                GameData gamedata= gameObject.GetComponent<GameData>();
                int len;
                if (gamedata != null)
                {
                    len = gamedata._skinSO.Length;
                    skinSO = new ItemSO[len];

                }
                for(int i = 0; i < gamedata._skinSO.Length; i++)
                {
                    skinSO[i]= gamedata._skinSO[i];
                }
            }
        }
    }

    protected virtual void LoadBackPackSO()
    {
        if (skinSO != null)
        {
            GameObject gameObject = GameObject.Find("GameData");
            if (gameObject != null)
            {

                GameData gamedata = gameObject.GetComponent<GameData>();
                int len;
                if (gamedata != null)
                {
                    len = gamedata._backPackSO.Length;
                    backPack = new ItemSO[len];

                }
                for (int i = 0; i < gamedata._backPackSO.Length; i++)
                {
                    backPack[i] = gamedata._backPackSO[i]; 
                }
            }
        }
    }
    void Update()
    {
        ChangeSkin();
        ChangeBackPack();
        TurnOnAura();
        if (Input.GetKeyDown(KeyCode.G))
        {
            if (!(skinIndex < skinSO.Length-1)) skinIndex = 0;
            {
                skinIndex++;
            }
            
            
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            if (!(skinIndex>0)) skinIndex = skinSO.Length - 1;
            {
                skinIndex--;
            }
            
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            backPackIndex++;

        }
        
    }

    public void TurnOnAura()
    {
        if( _playerMoment.IsGrounded() && (InputManager.instance.SetHorizontal()==0)) 
        {
           
            _playerAura.SetAura();

        }else {
            _playerAura.TurnOffAura1();
        }
  
    }
    public void ChangeBackPack()
    {
        if (backPack != null)
        {
            PlayerCustomization(_backPack.backpack, backPack[backPackIndex].GetSpriteHeadIdle);
        }
    }
    public void ChangeSkin()
    {
        if (skinSO != null)
        {

            PlayerCustomization(_playerHead._headIdle, skinSO[skinIndex].GetSpriteHeadIdle);
            PlayerCustomization(_playerHead._headRun, skinSO[skinIndex].GetSpriteHeadIRun);
            PlayerCustomization(_playerBody._bodyIdle, skinSO[skinIndex].GetSpriteBodyIdle);
            PlayerCustomization(_playerBody._bodyRun, skinSO[skinIndex].GetSpriteBodyRun);
            PlayerCustomization(_playerBody._bodyAttack, skinSO[skinIndex].GetSpriteBodyAttack);
            PlayerCustomization(_playerBody._bodySkill, skinSO[skinIndex].GetSpriteBodySkill);
            PlayerCustomization(_playerBody._bodyBlock, skinSO[skinIndex].GetSpriteBodyBlockl);
            PlayerCustomization(_playerBody._bodyFly, skinSO[skinIndex].GetSpriteBodyFly);
            PlayerCustomization(_playerLeg._legIdle, skinSO[skinIndex].GetSpriteLegIdle);
            PlayerCustomization(_playerLeg._legRun, skinSO[skinIndex].GetSpriteLegRun);
            PlayerCustomization(_playerLeg._legAttack, skinSO[skinIndex].GetSpriteLegAttack);
            PlayerCustomization(_playerLeg._legJump, skinSO[skinIndex].GetSpriteLegJump);
            PlayerCustomization(_playerLeg._legFly, skinSO[skinIndex].GetSpriteLegFly);

        }
    }

    private void PlayerCustomization(GameObject[] outfits, Sprite[] sprites)
    {
       
        if (outfits.Length > 0)
        {
            if (sprites != null && sprites.Length > 0)
            {
                for (int i = 0; i < outfits.Length; i++)
                {
                    
                    outfits[i].GetComponent<SpriteRenderer>().sprite = sprites[i];
                }
            }

        }
    }
}
