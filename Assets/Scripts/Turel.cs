using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turel : MonoBehaviour
{
    public GameObject _bulletPrefab;
    public Transform _spawnBulletPoint;
    public Transform player;
    private float damage = 2f;
    private float damagespeed = 20f;

    private void Fire()
    {
        GameObject bulletObject = Instantiate(_bulletPrefab, _spawnBulletPoint.position, _spawnBulletPoint.rotation);
        Bullet bullet = bulletObject.transform.gameObject.GetComponent<Bullet>();
        bullet.Initialization(damage, 3f,player,damagespeed );
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Fire();
        }
    }
}
