using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FT
{
    public class PlayerMovement : MonoBehaviour
    {
        public float DrSpeed = 15f;
        public Rigidbody DrM;
        public float jumpForce = 20;

        public bool isGrounded;
        public Animator anim;

        void Start()
        {
            DrSpeed = 15f;
            //mpHeight = 5f;
            anim = GetComponent<Animator>();
        }
        private void OnCollisionStay()
        {
            isGrounded = true;
            anim.SetBool("IsGrounded", true);
        }
        void Update()
        {
            //if (!isGrounded)
            //{

            //}
            //else
            //{
            anim.SetBool("Walk", false);

            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(Vector3.right * Time.deltaTime * DrSpeed);
                anim.SetBool("Walk", true);
                this.transform.localRotation = Quaternion.Euler(0, 0, 0);
            }

            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(Vector3.right * Time.deltaTime * DrSpeed);
                anim.SetBool("Walk", true);
                this.transform.localRotation = Quaternion.Euler(0, 180, 0);
            }
            //Moving left and right.

            if (isGrounded && Input.GetKeyDown(KeyCode.Space))
            {
                DrM.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);

            }
            //Simple jump with ground check.
            //
        }
        private void OnCollisionExit()
        {
            isGrounded = false;
            anim.SetBool("IsGrounded", false);
        }
    }

}
