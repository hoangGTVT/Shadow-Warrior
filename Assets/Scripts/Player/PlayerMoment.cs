using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMoment : KameScript
{
    [Header("Moment")]
    public float _speedMoment = 5f;
    public float _speedFly = 8f;
    public float _jumpForce = 2f;
    public bool _isJump = false;
    public bool _isRight = true;
    [Header("Eff")]
   
    [SerializeField] private LayerMask[] _jumpableGround;
    float _moveHorizontal;
    float _moveVertical;
    private Rigidbody2D _rigidbody;
    private BoxCollider2D _boxCollider;
    

    void Start()
    {

    }

    private void OnValidate()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _boxCollider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    public bool GetIsRight()
    {
        return _isRight;

    }

    public void SetGarvity(int index)
    {
 
            _rigidbody.gravityScale = index;
     
    }
    public void Jump(float _move)
    { 
        Vector3 _moment = new Vector3(0f, _move, 0f) * _speedMoment*Time.deltaTime;
        transform.Translate(_moment);
        _isJump = true;
        _rigidbody.gravityScale = 0;
        
    }

 
    public void Move(float _move)
    {
        Vector3 _moment = new Vector3(_move, 0f, 0f) * _speedMoment *Time.deltaTime ;
        transform.Translate(_moment);
        

    }
    public void Fly(float _move)
    {
        Vector3 _moment = new Vector3(_move, 0f, 0f) * _speedFly * Time.deltaTime;
        
        transform.Translate(_moment);
        
        _rigidbody.gravityScale = 0;
        
    }

    public bool IsGrounded()
    {
        return Physics2D.BoxCast(_boxCollider.bounds.center, _boxCollider.bounds.size, 0f, Vector2.down, .3f, _jumpableGround[0]);
    }
    public bool IsGrounded2()
    {
        return Physics2D.BoxCast(_boxCollider.bounds.center, _boxCollider.bounds.size, 0f, Vector2.down, .1f, _jumpableGround[1]);
    }

    
    public void PlayerRotate(int index)
    {

            _isRight = !_isRight;
            
            Vector3 currentScale = transform.localScale;
            currentScale.x *= -1;
            transform.localScale = currentScale;
            Vector3 currentTranform = transform.position;
            currentTranform.x -= index;
            transform.position = currentTranform;
        
    }
}
