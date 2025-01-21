using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    public Rigidbody heroRigidBody;
    public GameObject bullet;
    public float accelerationRate = 500f;
    public float maxVelocity = 1500f;
    private float fireRate = 0f;
    private float defaultFireRate = 0.5f;

    void GetPlayerInput()
    {
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            if(heroRigidBody.linearVelocity.z <= maxVelocity)
            {
                heroRigidBody.AddForce(0f, 0f, accelerationRate * Time.deltaTime);
            }
        }
        if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            if(heroRigidBody.linearVelocity.z >= -maxVelocity)
            {
                heroRigidBody.AddForce(0f, 0f, -accelerationRate * Time.deltaTime);
            }
        }
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if(heroRigidBody.linearVelocity.x >= -maxVelocity)
            {
                heroRigidBody.AddForce(-accelerationRate * Time.deltaTime, 0f, 0f);
            }
        }
        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            if(heroRigidBody.linearVelocity.x <= maxVelocity)
            {
                heroRigidBody.AddForce(accelerationRate * Time.deltaTime, 0f, 0f);
            }
        }
        if(fireRate > 0f)
        {
            fireRate -= Time.deltaTime;
        }
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Mouse0) && fireRate <= 0f) 
        {
            FireBullet();
            fireRate = defaultFireRate;
        }
    }


    void FireBullet() 
    {
        Instantiate(bullet, transform.position, Quaternion.identity);
    }
    void Update() 
    {
        GetPlayerInput();


    }


}