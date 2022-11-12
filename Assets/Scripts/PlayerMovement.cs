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

        [SerializeField] private AudioClip jumpSound;

        void Start()
        {
            DrSpeed = 15f;
            anim = GetComponent<Animator>();
        }
        private void OnCollisionStay()
        {
            isGrounded = true;
            anim.SetBool("IsGrounded", true);
        }
        void Update()
        {
            anim.SetBool("Walk", false);

            //Moving left and right.
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

            //Simple jump with ground check.
            if (isGrounded && Input.GetKeyDown(KeyCode.Space))
            {
                SoundManager.instance.PlaySound(jumpSound);
                DrM.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            }
             
        }
        private void OnCollisionExit()
        {
            isGrounded = false;
            anim.SetBool("IsGrounded", false);
        }
    }
}
