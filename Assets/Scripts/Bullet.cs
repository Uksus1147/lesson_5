using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Bullet : MonoBehaviour
{
    private float _damage;
    private float _speed;
    private Transform _target;
    private Vector3 _targetPosition;
    private Rigidbody _rb;
    public void Initialization(float damage, float lifetime, Transform target, float speed)
    {
        _rb = GetComponent<Rigidbody>();
        _damage = damage;
        _speed = speed;
        _target = target;
        _targetPosition = _target.position;
        Destroy(this.gameObject, lifetime);
        _rb.AddForce(transform.forward * 200, ForceMode.Force);
    }
    public void FixedUpdate()
    {
        //transform.position = Vector3.MoveTowards(transform.position, _target.position, _speed * Time.fixedDeltaTime);

    }
}
