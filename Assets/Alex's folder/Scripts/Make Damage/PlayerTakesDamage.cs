using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTakesDamage : MonoBehaviour
{
   public int hit;
   public int phasehit; 
   //public bool teleport;

   public void start()
   {
       hit = 0;
       //teleport = false;
   }

    public void OnCollisionEnter2D(Collision2D collision)  //method of "using collision condition to check status"
     {
        if (collision.gameObject.tag == "Enemy") //check with tag
        {
            hit = 1;
            phasehit = 1;
        }

        /*else if (collision.gameObject.tag == "Chip")
        {
            teleport = true;
            Destroy(collision.gameObject);

        }
        */
        
     }
}
