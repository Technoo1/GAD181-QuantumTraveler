using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTakeDamage : MonoBehaviour
{
    public GameObject EnemyDeathAni;
    public AudioSource EnemyDeath;
     
    private void OnCollisionEnter(Collision collision)  //method of "using collision condition to check status"
    {
        if (collision.gameObject.tag == "PlayerBullet") //check with tag
        {
            EnemyDeath.Play();
            Instantiate(EnemyDeathAni, transform.position, Quaternion.identity);
            //Destroy(collision.gameObject);
            Destroy(this.gameObject); //destroy this gameobject itself
        }
    }
}
