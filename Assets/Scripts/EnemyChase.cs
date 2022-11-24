using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FT
{
    public class EnemyChase : MonoBehaviour
    {
        private Rigidbody2D rb;
        public Transform player;
        public float speed;
        public Health checkLife;

        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
        }

        void Update()
        {
            if (checkLife.currentHealth > 0)
            {
                Vector2 pos = new Vector2(player.position.x, rb.velocity.y);

                rb.velocity = Vector2.MoveTowards(this.transform.position, pos, speed * Time.deltaTime);
            }
            else
            {

            }
        }
    }
}
