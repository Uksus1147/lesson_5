using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Player player;
    public Transform dulo;
    private void Awake()
    {
        player = GameObject.FindObjectOfType<Player>();
    }
    void Update()
    {
        Vector3 direction = player.transform.position - dulo.position;
        Vector3 forwardDirection = new Vector3(direction.x, 0, direction.z);
        dulo.rotation = Quaternion.LookRotation(forwardDirection);
    }
}
