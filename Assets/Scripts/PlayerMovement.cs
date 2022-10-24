using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   [SerializeField] private float speed; 
   private Rigidbody body; 

   private void Awake() 
   { 
       body = GetComponent<Rigidbody>(); 
   }

   private void Update()
   {
       body.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, body.velocity.y);

       if (Input.GetKey(KeyCode.Space))
       
       //"speed" means the jump velocity is the same as movement velocity. Can be adjusted by replacing with number. 
        // jump is more vertical when jumpspeed > movementspeed
       body.velocity = new Vector2(body.velocity.x, 15);
   }
}
