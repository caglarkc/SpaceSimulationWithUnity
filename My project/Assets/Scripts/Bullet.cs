using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Bullet : MonoBehaviour {
    private float moveSpeed = 5f;
    private float lifeTime = 5f;
    public float damageAmount = 25f;

    void Start()
    {
        Destroy(this.gameObject, lifeTime);
    }
    void Update()
    {
        transform.Translate(0f, 0f, moveSpeed * Time.deltaTime);
    }
}
