using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : KameScript
{
    public PlayerAnimation _playAnimation;
    public PlayerMoment _playerMoment;
    public PlayerAura _playerAura;
    public GameObject _efffly;
    public GameObject _effRun;
    [Header("Activity")]
    private bool _isJump;
    private bool _isFly;
    public float _moveHorizontal;
    public float _moveVertical;

    public bool IsJump() { return _isJump; }
    public bool IsFly() { return _isFly;}


    private void OnValidate()
    {
        this._playAnimation = GetComponentInChildren<PlayerAnimation>();
        this._playerMoment = GetComponent<PlayerMoment>();
        this._playerAura = GetComponentInChildren<PlayerAura>();
        LoadEff();
    }

    protected virtual void LoadEff() { 
        if (this._efffly != null)
        {
            _efffly = FindObject("Fly");

            _effRun = FindObject("Run");
        }
    }

    private void Update()
    {
        PlayerActive();
    }

    protected virtual void PlayerActive()
    {
       
        PlayerMoment();
        if (_playerMoment.GetIsRight() == true&& _moveHorizontal<0) { _playerMoment.PlayerRotate(1); } else 
        if(_playerMoment.GetIsRight()==false&& _moveHorizontal>0){ _playerMoment.PlayerRotate(-1);}
    }

    private void PlayerMoment()
    {
        _moveHorizontal = InputManager.instance.SetHorizontal();
        _moveVertical = InputManager.instance.SetVertica();
        if (_moveVertical == 0)
        {
            if (_playerMoment.IsGrounded())
            {
                _isFly = false;
                _isJump = false;
                if (!(_moveHorizontal == 0)) {
                    PlayerRun();
                }
                else
                {
                    PlayerIdle();
                }
            }
            else
            {  
                if (!(_moveHorizontal == 0)) {
                    PlayerFly();
                }
                else if (_moveVertical == 0) 
                {
                    PlayerFall();
                }
            }
        }
        if (_moveVertical > 0.3)
        {
            PlayerJump();
        }
    }
    protected virtual void PlayerRun()
    {
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
        _playerMoment.Fly(_moveHorizontal);
        _playAnimation.SetAnimationState1(2);
        _effRun.SetActive(false);
        _efffly.SetActive(true);
    }

    protected virtual void PlayerFall()
    {
        Invoke("PlayerSetGravity",0.1f);
        _efffly.SetActive(false);
        _playAnimation.SetAnimationState1(0);
    }
    protected virtual void PlayerJump()
    {
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


}
