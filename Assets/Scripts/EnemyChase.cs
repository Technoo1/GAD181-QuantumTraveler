using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FT
{
    public class EnemyChase : MonoBehaviour
    {
        private Rigidbody2D rbEnemy;

        public Transform player;
        public float speed = 5.0f;

        public Health checkLife;
        public PlayerTakesDamage phaseCheck;
        public float phaseTimer1 = 4.0f;
        public float phaseTime;
        public int phasehit;

        public float xMin;
        public float xMax;
        public float yMin;
        public float yMax;

        void Start()
        {
           rbEnemy = GetComponent<Rigidbody2D>();
           phaseTime = 0.0f;
        }

        void LateUpdate()
        {
            if (phaseTime > 0.0f)
            {
                phaseTime -= Time.deltaTime;
            }
            
            if (checkLife.currentHealth > 0 && phaseCheck.hit == 0 && phaseTime == 0.0f)
            {
                Vector2 pos = new Vector2(player.position.x, rbEnemy.velocity.y);
                //Vector2 pos = new Vector2(-25, rbEnemy.velocity.y);
                //var step =  speed * Time.deltaTime;

                //rb.velocity = Vector2.MoveTowards(this.transform.position, pos, speed * Time.deltaTime);
                //transform.position = Vector3.MoveTowards(transform.position, player.position, step);

                float x = Mathf.Clamp(player.transform.position.y, xMin, xMax);
                float y = Mathf.Clamp(player.transform.position.y, yMin, yMax);
                gameObject.transform.position = new Vector3(x-20f, y, gameObject.transform.position.z);
            }
            
            if  (phaseCheck.phasehit == 1)
            {
                phaseTime = phaseTimer1;

                phasehit = 0;

            }
        }
    } 
} 
