using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace TG
{

public class Obstacle : MonoBehaviour
{
    public int health = 100;

    public GameObject deathEffect;
    public AudioSource EnemyExplosion;

    public void TakeDamage (int damage)
    {
        health -= damage;

        if (health <=0)
        {
            Die();
        }

    }
    

    void Die()
    {
        EnemyExplosion.Play();
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(this.gameObject);
        
        

    }


    void OnTriggerEnter2D(Collider2D collision) 
    {
        if(collision.tag == "Border")
        {
            Destroy(this.gameObject);
        }
    }    
    
}

}


