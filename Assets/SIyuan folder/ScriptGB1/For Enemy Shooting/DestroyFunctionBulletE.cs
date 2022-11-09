using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace S1
{
    public class DestroyFunctionBulletE : MonoBehaviour
    {
        private void OnCollisionEnter(Collision collision)  //method of "using collision condition to check status"
        {
            if (collision.gameObject.tag == "DrM") //check with tag
            {
                Destroy(collision.gameObject);
                Destroy(gameObject); //destroy this gameobject itself
            }
            else
            {
                Destroy(gameObject); //destroy this gameobject itself
            }
        }

    }
}