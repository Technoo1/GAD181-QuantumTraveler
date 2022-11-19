using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FT
{
    /*public class PlayerMovement : MonoBehaviour
    {
        //public float DrSpeed = 15f;
        public float playerSpeedX;
        private Rigidbody rigbod;
        public float jumpForce = 20;
        private Vector2 playerDirection;

        public bool isGrounded;
        public Animator anim;

        [SerializeField] private AudioClip jumpSound;

        void Start()
        {
            //DrSpeed = 15f;
            rigbod = GetComponent<Rigidbody>();
            anim = GetComponent<Animator>();
            playerDirection = new Vector2(0, 0).normalized;

        }
        private void OnCollisionStay()
        {
            isGrounded = true;
            anim.SetBool("IsGrounded", true);
        }
        private void Update()
        {
            float directionX = Input.GetAxisRaw("Horizontal");
        }


        void FixedUpdate()
        {
            rigbod.velocity = new Vector2(playerDirection.x * playerSpeedX, playerDirection.y * jumpForce);

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
                rigbod.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            }
             
        }
        private void OnCollisionExit()
        {
            isGrounded = false;
            anim.SetBool("IsGrounded", false);
        }
    }*/

    public class PlayerMovement : MonoBehaviour
    {
        Rigidbody2D rb;
        private SpriteRenderer sprite;
        private Animator anim;

        private float dirX;
        [SerializeField] private float moveSpeed = 15f;
        [SerializeField] private float jumpForce = 25f;

        private enum MovementState { idle, running, jumping, falling }

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
                rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            }

            UpdateAnimationState();
        }

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

            if(rb.velocity.y > .01f)
            {
                state = MovementState.jumping;
            }
            else if (rb.velocity.y < -.01f)
            {
                state = MovementState.falling;
            }

            anim.SetInteger("state", (int)state);
        }
    }
}


