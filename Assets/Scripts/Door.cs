using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Transform door;
    public bool feOpen;
    private Transform _player;
    public float Rotatespeed = 100f;
    void FixedUpdate()
    {
        if (_player != null)
        {
           //Vector3 direction = (Vector3.back - door.position;
            //Vector3 forwardDirection = new Vector3(direction.x, 0, direction.z);
            Vector3 stepDirection = Vector3.RotateTowards(door.forward, Vector3.back, Rotatespeed * Time.fixedDeltaTime, 0.0f);
            door.rotation = Quaternion.LookRotation(stepDirection);
        }
        else
        {
            Vector3 stepDirection = Vector3.RotateTowards(door.forward, Vector3.forward, Rotatespeed * Time.fixedDeltaTime, 0.0f);
            door.rotation = Quaternion.LookRotation(stepDirection);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (other.GetComponent<KeyControl>().KeyHas == true)
            {
                _player = other.transform;
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _player = null;
        }
    }
}
