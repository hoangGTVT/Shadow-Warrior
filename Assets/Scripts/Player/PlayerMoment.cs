using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMoment : MonoBehaviour
{
    [Header("Moment")]
    public float _speedMoment = 5f;
    public float _jumpForce = 2f;
    public bool _isJump = false;
    public bool _isRight = true;
    [Header("Eff")]
    public GameObject _effFly;
    public GameObject _effRun;
    [SerializeField] private LayerMask[] _jumpableGround;
    float _moveHorizontal;
    float _moveVertical;
    private Rigidbody2D _rigidbody;
    private BoxCollider2D _boxCollider;
    private PlayerAnimation _playerAnimation;
    private SkillController _skillController;
    
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _boxCollider = GetComponent<BoxCollider2D>();
        _playerAnimation = GetComponentInChildren<PlayerAnimation>();
        _skillController = GetComponentInChildren<SkillController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
        
   
    }

    public bool GetIsRight()
    {
        return _isRight;

    }
    private void PlayerMove()
    {
         _moveHorizontal = InputManager.instance.SetHorizontal();
         _moveVertical = InputManager.instance.SetVertica();
        PlayerRotate();
        
        if (_moveHorizontal != 0)
        {
            if (_isJump == false && IsGrounded())
            {
                Move();
            }
            else 

            {
                _playerAnimation.SetAnimationState1(2);
                Vector3 _moment = new Vector3(_moveHorizontal, 0f, 0f) * _speedMoment * Time.deltaTime;

                transform.Translate(_moment);
            }
        }
        else { 
            _effRun.SetActive(false);
            _playerAnimation.SetAnimationState1(0);
        }

        

        if (_moveVertical > 0.3f)
        {
            Jump();
        }
        
        else if(_moveVertical<=0 && _moveHorizontal==0)
        {
            Invoke("SetGarvity", 0.1f);
            
        }

        if (_isJump = true && !IsGrounded2()&&(_moveHorizontal>0.5||_moveHorizontal<-0.5))
        {
            Fly();
        }
        


        if (IsGrounded2()) {
            _moveHorizontal = 0;
            _moveVertical = 0;
        }
    }

    private void SetGarvity()
    {
        if (_moveVertical <= 0 && _moveHorizontal == 0)
        {
            _rigidbody.gravityScale = 6;
            _effFly.SetActive(false);
        }
        else
        {
            return;
        }
           
    }
    void Jump()
    {
        _effFly.SetActive(false);
        Vector3 _moment = new Vector3(0f, _moveVertical, 0f) * _speedMoment*Time.deltaTime;
        _playerAnimation.SetAnimationState1(3);
        transform.Translate(_moment);
        _isJump = true;
        _rigidbody.gravityScale = 0;
        _effRun.SetActive(false);
    }

    private void Move()
    {
        _effFly.SetActive(false);
        Vector3 _moment = new Vector3(_moveHorizontal, 0f, 0f) * _speedMoment *Time.deltaTime ;
        _playerAnimation.SetAnimationState1(1);
        transform.Translate(_moment);
        _effRun.SetActive(true);

    }
    private void Fly()
    {
        Vector3 _moment = new Vector3(_moveHorizontal, 0f, 0f) * _speedMoment * Time.deltaTime;
        _playerAnimation.SetAnimationState1(2);
        transform.Translate(_moment);
        _effFly.SetActive(true);
    }

    public bool IsGrounded()
    {
        return Physics2D.BoxCast(_boxCollider.bounds.center, _boxCollider.bounds.size, 0f, Vector2.down, .1f, _jumpableGround[0]);
    }
    public bool IsGrounded2()
    {
        return Physics2D.BoxCast(_boxCollider.bounds.center, _boxCollider.bounds.size, 0f, Vector2.down, 2f, _jumpableGround[1]);
    }

    private void PlayerRotate()
    {
        if(_moveHorizontal<0&& _isRight==true)
        {
            _isRight = false;
            
            Vector3 currentScale = transform.localScale;
            currentScale.x *= -1;
            transform.localScale = currentScale;
            Vector3 currentTranform = transform.position;
            currentTranform.x -= 1;
            transform.position = currentTranform;
        }else if (_moveHorizontal > 0 && _isRight == false)
        {
            _isRight = true;
            
            Vector3 currentScale = transform.localScale;
            currentScale.x *= -1;
            transform.localScale = currentScale;
            Vector3 currentTranform = transform.position;
            currentTranform.x += 1;
            transform.position = currentTranform;
        }
    }
}
