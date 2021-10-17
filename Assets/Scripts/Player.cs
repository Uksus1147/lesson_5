using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector3 _direct;      
    public float speed = 2;
    public float JumpForce = 2;
    public float Rotatespeed = 100f;
   //[SerializeField] private Transform _eye;
   // private LayerMask _eyeMask;


    //private GameObject _bulletPrefab;
    //public Transform _spawnBulletPoint;
    //private float damage = 2f; 
    public void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }



    private void Awake()
    {
        _direct = Vector3.zero;
    }
    private void Update()
    {
        _direct.x = Input.GetAxis("Horizontal");
        _direct.z = Input.GetAxis("Vertical");
        if (Input.GetButtonDown("Jump"))
            GetComponent<Rigidbody>().AddForce(Vector3.up * JumpForce, ForceMode.Impulse);

    }
    private void FixedUpdate()
    {
        Move();
        //Fire();

        transform.Rotate(0, Input.GetAxis("Mouse X") * Rotatespeed * Time.fixedDeltaTime, 0);
        //при добавлении цикла while у меня перестовал работать Unity

    }
    private void Move()
    {
        Vector3 direction = _direct * speed * Time.fixedDeltaTime;
        transform.Translate(direction);
    }
    //private void Show()
    //{
    //    if (Physics.Raycast(_eye.position, _eye.forward, out RaycastHit hit, 20f, _eyeMask))
     //   {
     //
      //  }
    }
    //private void Fire()
   // {
    //    GameObject bulletObject = Instantiate(_bulletPrefab, _spawnBulletPoint.position, _spawnBulletPoint.rotation);
   //     Bullet bullet = bulletObject.transform.gameObject.GetComponent<Bullet>();
    //    bullet.Initialization(damage, 3f, null);  
    //}

