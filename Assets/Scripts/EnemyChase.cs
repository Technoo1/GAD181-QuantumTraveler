using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FT
{
    public class EnemyChase : MonoBehaviour
    {
        public GameObject player;
        public float speed;
        private float distance;
        public Health checkLife;


        // Update is called once per frame
        void Update()
        {
            distance = Vector2.Distance(transform.position, player.transform.position);
            Vector2 direction = player.transform.position - transform.position;
            Vector3 newPos = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
            newPos.y = -4.2f;
            transform.position = newPos;

            if (checkLife.currentHealth > 0)
            {
                Vector3 pos = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);

                transform.position = Vector3.MoveTowards(this.transform.position, pos, speed * Time.deltaTime);
            }
            else
            {

            }
        }
    }

}
