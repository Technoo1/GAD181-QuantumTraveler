using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed; 
    private Rigidbody body; 
    private Animator anim; 

    private void Awake() 
    { 
        body = GetComponent<Rigidbody>(); 
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(horizontalInput * speed, body.velocity.y);

        /*flip character when moving left and right 
        if (horizontalInput > 0.01f)
            transform.localScale = Vector2.one; 
        else if (horizontalInput < 0.01f) 
            transform.localScale = new Vector2(-1, 1);
            */
        
        if (Input.GetKey(KeyCode.Space))
        Jump();

        //set animator parameters
        anim.SetBool("Walk", horizontalInput != 0);
    }

     //"speed" means the jump velocity is the same as movement velocity. Can be adjusted by replacing with number. 
        // jump is more vertical when jumpspeed > movementspeed
        
    private void Jump()
    {
    body.velocity = new Vector2(body.velocity.x, 15);
    }

}
