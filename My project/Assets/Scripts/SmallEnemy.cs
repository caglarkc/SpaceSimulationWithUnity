using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SmallEnemy : EnemyBase
{
    void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Bullet")
        {
            TakeDamage(other.GetComponent<Bullet>().damageAmount);
            Destroy(other.gameObject);
        }
        
    }

    void Update()
    {

    }
}

