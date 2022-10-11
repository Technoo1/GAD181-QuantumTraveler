using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DraftMovement1 : MonoBehaviour
{
    public float DrSpeed = 3.0f;
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
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * DrSpeed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * DrSpeed);
        }   
        //Moving left and right.

        if (isGrounded && Input.GetKeyDown(KeyCode.W))
        {
            DrM.AddForce(Vector3.up * jumpForce , ForceMode.Impulse); 
        }
        //Simple jump with ground check.
    }
    private void OnCollisionExit()
    {
        isGrounded = false;
    }
}
