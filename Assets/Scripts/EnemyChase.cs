using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FT
{
    public class EnemyChase : MonoBehaviour
    {
        public Transform player;
        public float speed;
        public Health checkLife;

        void Update()
        {
            if (checkLife.currentHealth > 0)
            {
                Vector3 pos = new Vector3(player.position.x, transform.position.y, transform.position.z);

                transform.position = Vector3.MoveTowards(this.transform.position, pos, speed * Time.deltaTime);
            }
            else
            {

            }
        }
    }
}
