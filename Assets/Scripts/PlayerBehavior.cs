using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerBehavior : MonoBehaviour
{
    public float MoveSpeed = 10f;
    public float RotateSpeed = 75f;
    private float _vInput;
    private float _hInput;
    // 1
    private Rigidbody _rb;
    // 2

    public float JumpVelocity = 5f;
    private bool _isJumping;

    public float DistanceToGround = 0.1f;
    // 2 
    public LayerMask GroundLayer;
    // 3
    private CapsuleCollider _col;

    public GameObject Bullet;
    public float BulletSpeed = 100f;

    private bool _isShooting;

    void Start()
    {
        // 3
        _rb = GetComponent<Rigidbody>();
        _col = GetComponent<CapsuleCollider>();
    }
    void Update()
    {

        _isJumping |= Input.GetKeyDown(KeyCode.Space);
        _vInput = Input.GetAxis("Vertical") * MoveSpeed;
        _hInput = Input.GetAxis("Horizontal") * RotateSpeed;
        _isShooting |= Input.GetMouseButtonDown(0);
        /*
        this.transform.Translate(Vector3.forward * _vInput * 
        Time.deltaTime);
        this.transform.Rotate(Vector3.up * _hInput * Time.deltaTime);
        */
    }

    // 1
    void FixedUpdate()
    {
        if (IsGrounded() && _isJumping)
        {
            
            _rb.AddForce(Vector3.up * JumpVelocity, ForceMode.Impulse);
        }
        
        _isJumping = false;

        if (_isShooting)
        {
            
            GameObject newBullet = Instantiate(Bullet,
                this.transform.position + new Vector3(1, 0, 0),
                   this.transform.rotation);
            
            Rigidbody BulletRB =
                 newBullet.GetComponent<Rigidbody>();

            
            BulletRB.velocity = this.transform.forward *
                                            BulletSpeed;
        }
        
        _isShooting = false;

        Vector3 rotation = Vector3.up * _hInput;
        
        Quaternion angleRot = Quaternion.Euler(rotation *
            Time.fixedDeltaTime);
        
        _rb.MovePosition(this.transform.position +
            this.transform.forward * _vInput * Time.fixedDeltaTime);
        
        _rb.MoveRotation(_rb.rotation * angleRot);
    }

    private bool IsGrounded()
    {
        // 7
        Vector3 capsuleBottom = new Vector3(_col.bounds.center.x,
             _col.bounds.min.y, _col.bounds.center.z);

        // 8
        bool grounded = Physics.CheckCapsule(_col.bounds.center,
            capsuleBottom, DistanceToGround, GroundLayer,
               QueryTriggerInteraction.Ignore);

        // 9
        return grounded;
    }

}
