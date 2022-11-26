using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace TG
{

public class EnemyBullet : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 20;
    public Rigidbody2D rb;
    public GameObject impactEffect;
    public Health lifePoints;


    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D (Collider2D hitInfo)
    {
        Player player = hitInfo.GetComponent<Player>();
        if (player != null)
        {
            lifePoints.TakeDamage(1);
           
        }

        Instantiate(impactEffect,transform.position, transform.rotation);

        Destroy(gameObject);
    }
        
    
  
    }
}
