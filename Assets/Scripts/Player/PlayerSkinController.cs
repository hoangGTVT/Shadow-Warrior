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
    [SerializeField] private PlayerManager _playerManager;
    [Header("Thay đổi trang phục khi mặc trang bị")]
    [SerializeField] public ItemSO[] skinSO;
    public int skinIndex = 0;
    public int skinIndexLevel=0;
    public bool isSkin;
    private void Awake()
    {
        skinIndex = 0;
        skinIndexLevel=0;
        
    }
    private void OnValidate()
    {
        _playerHead = GetComponentInChildren<Head>();
        _playerBody = GetComponentInChildren<Body>();
        _playerLeg = GetComponentInChildren<Leg>();
        //_backPack = GetComponentInChildren<BackPack>();
        _playerAura = GetComponentInChildren<PlayerAura>();
        _playerMoment = GetComponent<PlayerMoment>();
       _playerManager=GetComponentInParent<PlayerManager>();
        
    }
    public int GetSkinIndex() { return skinIndex; }
    public int GetSkinIndexLevel() {  return skinIndexLevel; }
    public void SetSkinIndex(int index) { skinIndex = index; }
    public void SetSkinIndexLevel(int index) { skinIndexLevel = index;}
    public bool GetIsSkin() { return isSkin; }
    public void SetIsSkin(bool skin) { isSkin= skin; }
    


    public void SetSkin(int index)
    {
        SetSkinIndex(index);
        SetIsSkin(true);
        _playerManager.SetData();
        _playerManager.SetTotalData();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            SetSkin(50);
        }
        ChangeSkin();
        if (_playerAura.GetIsAura() == true)
        {
            TurnOnAura();
        }
        

        if (Input.GetKeyDown(KeyCode.G))
        {
            if (!(skinIndex < skinSO.Length-1)) skinIndex = 0;
            {
                skinIndex++;

                if (skinIndex >= 0 && skinIndex <= 10)
                {
                    skinIndexLevel=skinIndex;
                    _playerManager.SetData();
                    _playerManager.SetTotalData();
                }
                if (skinIndex > 10)
                {
                    isSkin = true;
                }
                else
                {
                    isSkin = false;
                }
                _playerManager.SetData();
                _playerManager.SetTotalData();
            }
            
            
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            if (!(skinIndex>0)) skinIndex = skinSO.Length;
            {
                skinIndex--;
                if (skinIndex >= 0 && skinIndex <= 10)
                {
                    skinIndexLevel = skinIndex;
                    _playerManager.SetData();
                    _playerManager.SetTotalData();
                }
                if (skinIndex > 10)
                {
                    isSkin = true;
                }
                else
                {
                    isSkin = false;
                }
                
                _playerManager.SetData();
                _playerManager.SetTotalData();
            }
            
        }
        
        
    }

    public void TurnOnAura()
    {
        if( _playerMoment.IsGrounded() && (InputManager.instance.SetHorizontal()==0)) 
        {

            _playerAura.TurnOnAura();

        }else {
            _playerAura.TurnOffAura1();
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
