using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrMBulletFunction1 : MonoBehaviour
{
    void Start()
    {
       // Physics.IgnoreCollision(GetComponent<Collider>(), GetComponent<Collider>(gameObject.tag == "EnemyBullet"));  Ask Matt for help!
    }

    private void OnCollisionEnter(Collision collision)  //method of "using collision condition to check status"
    {
        if (collision.gameObject.tag == "Enemy") //check with tag
        {
            Destroy(collision.gameObject);
            Destroy(gameObject); //destroy this gameobject itself
        }
       
    }

}
