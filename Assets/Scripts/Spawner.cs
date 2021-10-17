using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject _bulletPrefab;
    private bool _isFire;
    public Transform _spawnBulletPoint;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            _isFire = true;
    }
    private void FixedUpdate()
    {
        if (_isFire)
        {
            _isFire = false;
            Fire();
        }
    }
    private void Fire()
    {
        Instantiate(_bulletPrefab, _spawnBulletPoint.position, Quaternion.identity);
    }
}
