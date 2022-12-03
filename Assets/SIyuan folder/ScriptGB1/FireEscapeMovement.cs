using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace S1
{
public class FireEscapeMovement : MonoBehaviour
{
    
        public float DrSpeedF = 3.0f;
        public Rigidbody DrMF;
        public float jumpForceF = 6.8f;
        public bool isGroundedF;
        public Animator animF;
       
        public AudioSource DrMJumpF;
        void Start()
        {
            DrSpeedF = 3.0f;
        }
        private void OnCollisionStay()
        {
            isGroundedF = true;
        }
        void Update()
        {
            animF.SetBool("WalkWithOutGun", false);
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(Vector3.right * Time.deltaTime * DrSpeedF);
                animF.SetBool("WalkWithOutGun", true);
                this.transform.localRotation = Quaternion.Euler(0, 0, 0);
            }


            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(Vector3.right * Time.deltaTime * DrSpeedF);
                animF.SetBool("WalkWithOutGun", true);
                this.transform.localRotation = Quaternion.Euler(0, 180, 0);
            }
            //Moving left and right.

            if (isGroundedF && Input.GetKeyDown(KeyCode.X))
            {
                DrMF.AddForce(Vector3.up * jumpForceF, ForceMode.Impulse);
                DrMJumpF.Play();
            }
            //Simple jump with ground check.

        }

        private void OnCollisionExit()
        {
            isGroundedF = false;
        }
    }
}
