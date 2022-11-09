using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FT 
{
public class EnemyDamage : MonoBehaviour
{
    public int damage;
    public Health playerHealth;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            playerHealth.TakeDamage(1);
        }
    }
}

}
