using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FT
{
    public class PlayerMovement : MonoBehaviour
    {
        Rigidbody2D rbPlayer;
        private SpriteRenderer sprite;
        private Animator anim;

        public bool isGrounded;

        private float dirX;
        [SerializeField] private float moveSpeed = 15f;
        [SerializeField] private float jumpForce = 25f;

        private enum MovementState { idle, running, jumping, falling }

        [SerializeField] private AudioSource jumpSound;
        [SerializeField] private AudioSource walkSound;

        //start
        void Start()
        {
            rbPlayer = GetComponent<Rigidbody2D>();
            sprite = GetComponent<SpriteRenderer>();
            anim = GetComponent<Animator>();
        }
        
        private void OnCollisionStay2D()
        {
           
            isGrounded = true;
            Debug.Log("is grounded");
        }
        //update
        void Update()
        {
            dirX = Input.GetAxisRaw("Horizontal");
            rbPlayer.velocity = new Vector2(dirX * moveSpeed, rbPlayer.velocity.y);
            Debug.Log("moving ok");

            if (isGrounded && Input.GetKeyDown("x"))
            {
                //Debug.Log("X pressed.");
                jumpSound.Play();
                rbPlayer.velocity = new Vector2(rbPlayer.velocity.x, jumpForce);
            }
            else if (rbPlayer.velocity.x != 0f)
            {
                if (!walkSound.isPlaying)
                {
                    walkSound.Play();
                }
            }
            
            else
            {
                walkSound.Stop();
            }


            UpdateAnimationState();
        }

        //animations
        private void UpdateAnimationState()
        {
            MovementState state;
            
            if (dirX > 0f)
            {
                state = MovementState.running;
                sprite.flipX = false; 
            }
            else if (dirX < 0f)
            {
                state = MovementState.running;
                sprite.flipX = true;
            }
            else
            {
                state = MovementState.idle;
            }
             
             if(isGrounded == false)
            {
                state = MovementState.jumping;
            }
            
            /*if(rbPlayer.velocity.y != 0f)
            {
                state = MovementState.jumping;
            }
            */

            /*else if (rb.velocity.y < -.01f)
            {
                state = MovementState.falling;
            }*/

            anim.SetInteger("state", (int)state);
        }

        private void OnCollisionExit2D()
        {
            isGrounded = false;
        }
    }
}


