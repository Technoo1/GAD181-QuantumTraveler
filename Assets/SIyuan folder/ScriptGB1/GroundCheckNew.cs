using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace S1
{
public class GroundCheckNew : MonoBehaviour
{
        public Rigidbody DrM;
        public float jumpForce = 6.8f;
        public bool isGrounded;

        public Transform offsetPosition1;
        public Transform offsetPosition2;
        public float groundCheckDistance;
        public LayerMask groundLayer;

        // Start is called before the first frame update
        void Start()
        {
        
        }
        private void OnCollisionStay()
        {
            isGrounded = true;
        }

        // Update is called once per frame
        void Update()
        {
             if (IsGrounded() && Input.GetKeyDown(KeyCode.X))
                {
                    DrM.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
                    //DrMJump.Play();
                }
        }

        private bool IsGrounded()
        {
                return Physics.Raycast(offsetPosition1.position, -transform.up, groundCheckDistance, groundLayer) || Physics.Raycast(offsetPosition2.position, -transform.up, groundCheckDistance, groundLayer);
                
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.yellow;
            Gizmos.DrawLine(offsetPosition1.position, offsetPosition1.position   + (-transform.up) * groundCheckDistance);
            Gizmos.DrawLine(offsetPosition2.position, offsetPosition2.position + (-transform.up) * groundCheckDistance);
        }

        private void OnCollisionExit()
        {
            isGrounded = false;
        }
    }
}
