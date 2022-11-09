using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace S1
{
    public class DrMBulletFunction1 : MonoBehaviour
    {
    void Start()
    {
        Physics.IgnoreLayerCollision(6, 6);  //Ignore the collision that happened on layer 6 , use TAG-Layer on these bullet prefebs. 
    }

    private void OnCollisionEnter(Collision collision)  //method of "using collision condition to check status"
    {
        if (collision.gameObject.tag == "Enemy") //check with tag
        {
            Destroy(collision.gameObject);
            Destroy(gameObject); //destroy this gameobject itself
        }
        else
        {
            Destroy(gameObject);
        }

    }

    }
}