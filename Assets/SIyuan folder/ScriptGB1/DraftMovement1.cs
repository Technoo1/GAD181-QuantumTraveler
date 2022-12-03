using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace S1
{
    public class DraftMovement1 : MonoBehaviour
    {
        public float DrSpeed = 3.0f;
        public Rigidbody DrM;
        public float jumpForce = 6.8f;
        public bool isGrounded;
        public Animator anim;
       
        public AudioSource DrMJump;
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
            anim.SetBool("WalkWithGun", false);
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(Vector3.right * Time.deltaTime * DrSpeed);
                anim.SetBool("WalkWithGun", true);
                this.transform.localRotation = Quaternion.Euler(0, 0, 0);
            }


            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(Vector3.right * Time.deltaTime * DrSpeed);
                anim.SetBool("WalkWithGun", true);
                this.transform.localRotation = Quaternion.Euler(0, 180, 0);
            }
            //Moving left and right.

            if (isGrounded && Input.GetKeyDown(KeyCode.X))
            {
                DrM.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
                DrMJump.Play();
            }
            //Simple jump with ground check.

        }
        
        private void OnCollisionExit()
        {
            isGrounded = false;
        }
    }
}
