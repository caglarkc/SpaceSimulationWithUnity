using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyBase : MonoBehaviour
{
    private float health = 100f;
    
    public void TakeDamage(float damage)
    {
        health -= damage;
        if(health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(this.gameObject);
    }
}


