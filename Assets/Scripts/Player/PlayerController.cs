using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : KameScript
{
    public PlayerAnimation _playAnimation;
    public PlayerMoment _playerMoment;
    public PlayerAura _playerAura;
    public PlayerManager _playerManager;
    public PlayerLife _playerLife;
    public GameObject _efffly;
    public GameObject _effRun;
    private PlayerMove1 _playerMove1;
    [Header("Activity")]
    private bool _isJump;
    private bool _isFly;
    public bool _isSkill;
    public float _moveHorizontal;
    public float _moveVertical;
    public float _timecoolDow;
    public float _timecoolDow2;
    public float inputVer;
    public float inputHori;
    public bool IsJump() { return _isJump; }
    public bool IsFly() { return _isFly; }
    public bool IsSkill() { return _isSkill; }

    private void OnEnable()
    {
        CallCoroutine();
    }


    private void Awake()
    {
        _playerMove1= new PlayerMove1();
        _playerMove1.Enable();
        _playerMove1.Land.Run.performed += ctx =>
        {
            inputHori=ctx.ReadValue<float>();
        };
        _playerMove1.Land.Jump.performed += ctx =>
        {
            inputVer=ctx.ReadValue<float>();
        };
    }
    private void Start()
    {
        this._playAnimation = GetComponentInChildren<PlayerAnimation>();
        this._playerMoment = GetComponent<PlayerMoment>();
        this._playerAura = GetComponentInChildren<PlayerAura>();
        this._playerManager = GetComponent<PlayerManager>();
        this._playerLife = GetComponentInChildren<PlayerLife>();
        CallCoroutine();
    }

    public void CallCoroutine()
    {
        StartCoroutine(CallMinusKI());
        StartCoroutine(CallPlusHP());
        StartCoroutine(CallPlusKI());
        StartCoroutine(CallMinusStamina());
    }
    private void Update()
    {
        PlayerActive();
       /* PlayerActive1();*/
        _timecoolDow  += Time.deltaTime;
        _timecoolDow2 += Time.deltaTime;
        
    }

    protected virtual void PlayerActive()
    {
        _isSkill = _playAnimation.GetSkill();
        PlayerMoment();
        if (_playerMoment.GetIsRight() == true && _moveHorizontal < 0) { _playerMoment.PlayerRotate(1); }
        else
        if (_playerMoment.GetIsRight() == false && _moveHorizontal > 0) { _playerMoment.PlayerRotate(-1); }
    }
    protected virtual void PlayerActive1()
    {
        _isSkill = _playAnimation.GetSkill();
        PlayerMoment1();
        if (_playerMoment.GetIsRight() == true && inputHori < 0) { _playerMoment.PlayerRotate(1); }
        else
        if (_playerMoment.GetIsRight() == false && inputHori > 0) { _playerMoment.PlayerRotate(-1); }
    }

    private void PlayerMoment()
    {
        _moveHorizontal = InputManager.instance.SetHorizontal();
        _moveVertical = InputManager.instance.SetVertica();
        if (_moveVertical == 0 && _isSkill == false)
        {
            if (_playerMoment.IsGrounded())
            {
                _isFly = false;
                _isJump = false;
                if (!(_moveHorizontal == 0))
                {
                    PlayerRun();
                }
                else
                {
                    PlayerIdle();
                }
            }
            else
            {
                if (!(_moveHorizontal == 0)  && _playerLife.GetKICurrent()>0)
                {
                    
                    PlayerFly();

                }
                else if (_moveVertical == 0  || _playerLife.GetKICurrent()<=0)
                {
                    
                    PlayerFall();
                }
            }
        }
        if (_moveVertical > 0.3  && _isSkill == false&& _playerLife.GetKICurrent() > 0)
        {
            PlayerJump();
        }
        if (_moveVertical < 0 )
        {
            PlayerFall();
        }
    }
    private void PlayerMoment1()
    {
        _moveHorizontal = InputManager.instance.SetHorizontal();
        _moveVertical = InputManager.instance.SetVertica();
        if (inputVer == 0 && _isSkill == false)
        {
            if (_playerMoment.IsGrounded())
            {
                _isFly = false;
                _isJump = false;
                if (!(inputHori == 0))
                {
                    PlayerRun();
                }
                else
                {
                    PlayerIdle();
                }
            }
            else
            {
                if (!(inputHori == 0) && _playerLife.GetKICurrent() > 0)
                {

                    PlayerFly();

                }
                else if (inputVer == 0 || _playerLife.GetKICurrent() <= 0)
                {

                    PlayerFall();
                }
            }
        }
        if (inputVer > 0.3 && _isSkill == false && _playerLife.GetKICurrent() > 0)
        {
            PlayerJump();
        }
        if (inputVer < 0)
        {
            PlayerFall();
        }
    }
    protected virtual void PlayerRun()
    {
        _playerMoment.Move(inputHori);
        _playerMoment.Move(_moveHorizontal);
        _playAnimation.SetAnimationState1(1);
        _efffly.SetActive(false);
        _effRun.SetActive(true);
    }
    protected virtual void PlayerIdle()
    {
        _effRun.SetActive(false);
        _playAnimation.SetAnimationState1(0);
    }
    protected virtual void PlayerFly()
    {
        _playerMoment.SetGarvity(0);
        _playerMoment.Fly(inputHori);
        _playerMoment.Fly(_moveHorizontal);
        _playAnimation.SetAnimationState1(2);

        _effRun.SetActive(false);
        _efffly.SetActive(true);
    }

    protected virtual void PlayerFall()
    {
        Invoke("PlayerSetGravity", 0.1f);
        _efffly.SetActive(false);
        _playAnimation.SetAnimationState1(0);
    }
    protected virtual void PlayerJump()
    {
        _playerMoment.Jump(inputVer);
        _playerMoment.Jump(_moveVertical);
        _efffly.SetActive(false);
        _playAnimation.SetAnimationState1(3);
        _effRun.SetActive(false);
        _isJump = true;
    }
    protected virtual void PlayerSetGravity()
    {
        _playerMoment.SetGarvity(5);
    }

    IEnumerator CallMinusKI()
    {
        while (true)
        {
            
            if (!_playerMoment.IsGrounded2()&& _timecoolDow2>=1f)
            {
                _playerManager.MinusKI(1);
                _timecoolDow2 = 0;
            }

            yield return new WaitForSeconds(.1f);

        }

    }
    IEnumerator CallMinusStamina()
    {
        while (true)
        {
            if (_timecoolDow >= 10f)
            {
                _playerManager.MinusStamina(2);
                _timecoolDow = 0;
            }
            yield return new WaitForSeconds(.1f);
        }

    }
    IEnumerator CallPlusKI()
    {
        while (true)
        {
            
            _playerManager.HealKi(_playerLife.GetKITotal() / 50);
            yield return new WaitForSeconds(15f);
        }
    }
    IEnumerator CallPlusHP()
    {
        while (true)
        {
            _playerManager.HealHP(_playerLife.GetHPTotal()/50);
            yield return new WaitForSeconds(10f);
        }
    }
}
