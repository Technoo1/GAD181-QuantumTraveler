using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   [SerializeField] private float speed1; 
   [SerializeField] private float speed2; 
   private Rigidbody body; 

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        body.velocity = new Vector3(horizontalInput * speed, body.velocity.y, body.velocity.z);

   private void Update()
   {
       body.velocity = new Vector2(Input.GetAxis("Horizontal") * speed1, body.velocity.y);

        //set animator parameters
        anim.SetBool("walk", horizontalInput != 0); 
    }

    private void Jump()
    {
        //"speed" means the jump velocity is the same as movement velocity. Can be adjusted by replacing with number. 
        // jump is more vertical when jumpspeed > movementspeed
       body.velocity = new Vector2(body.velocity.x, 15);
   }

    /*public float DrSpeed = 3.0f;
    public Rigidbody DrM;
    public float jumpForce = 6.0f;
    public bool isGrounded;
    void Start()
    {
        DrSpeed = 3.0f;
    }
    private void OnCollisionStay()
    {
        isGrounded = true;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * Time.deltaTime * DrSpeed);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * Time.deltaTime * DrSpeed);
        }   
        //Moving left and right.

        if (isGrounded && Input.GetKeyDown(KeyCode.UpArrow))
        {
            DrM.AddForce(Vector3.up * jumpForce , ForceMode.Impulse); 
        }
        //Simple jump with ground check.
    }
    private void OnCollisionExit()
    {
        isGrounded = false;
    }*/
}


    