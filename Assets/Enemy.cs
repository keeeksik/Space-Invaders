using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;
    public float speed;

    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }


    public void TakeDamage(int damage)
    {
        health -= damage;
    }

}
