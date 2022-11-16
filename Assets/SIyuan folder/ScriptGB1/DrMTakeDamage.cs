using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace S1
{

public class DrMTakeDamage : MonoBehaviour
{
   public int hit;
   public bool teleport;

   public void start()
   {
       hit = 0;
       teleport = false;
   }

    public void OnCollisionEnter(Collision collision)  //method of "using collision condition to check status"
     {
        if (collision.gameObject.tag == "EnemyBullet") //check with tag
        {
            hit = 1;
        }          

        else if (collision.gameObject.tag == "QPiece")
        {
            teleport = true;
            Destroy(collision.gameObject);

        }
     }
     
     
}

}
