using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    [SerializeField] private AudioSource chipSound;
    public bool teleport;

     public void start()
   {
       
       teleport = false;
   }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Chip"))
        {
            chipSound.Play();
            teleport = true;
            Destroy(collision.gameObject);
        }
        
    }
}
