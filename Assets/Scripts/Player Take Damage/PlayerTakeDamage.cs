using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace TG
{
public class PlayerTakeDamage : MonoBehaviour
{
   public int hitCheck;
   //public bool teleport;
   public AudioSource hit;

   public void start()
   {
       hitCheck = 0;
       //teleport = false;
   }

    public void OnCollisionEnter2D(Collision2D collision)  //method of "using collision condition to check status"
     {
        if (collision.gameObject.tag == "Enemy") //check with tag
        {
            hitCheck = 1;
           hit.Play();
           
        }

        /*else if (collision.gameObject.tag == "QPiece")
        {
            teleport = true;
            Destroy(collision.gameObject);

        }
        */
     }
}

}