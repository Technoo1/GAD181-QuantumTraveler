using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FT
{
    public class PlayerMovement : MonoBehaviour
    {
        Rigidbody2D rb;
        private SpriteRenderer sprite;
        private Animator anim;

        private float dirX;
        [SerializeField] private float moveSpeed = 15f;
        [SerializeField] private float jumpForce = 25f;

        private enum MovementState { idle, running, jumping, falling }

        [SerializeField] private AudioSource jumpSound;
        [SerializeField] private AudioSource walkSound;

        //start
        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
            sprite = GetComponent<SpriteRenderer>();
            anim = GetComponent<Animator>();
        }

        //update
        void Update()
        {
            dirX = Input.GetAxisRaw("Horizontal");
            rb.velocity = new Vector2(dirX * moveSpeed, rb.velocity.y);

            if (Input.GetButtonDown("Jump"))
            {
                jumpSound.Play();
                rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            }
            else if (rb.velocity.x != 0f)
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

            if(rb.velocity.y != 0f)
            {
                state = MovementState.jumping;
            }
            /*else if (rb.velocity.y < -.01f)
            {
                state = MovementState.falling;
            }*/

            anim.SetInteger("state", (int)state);
        }
    }
}


