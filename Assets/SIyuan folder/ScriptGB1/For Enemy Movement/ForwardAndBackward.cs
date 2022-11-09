using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace S1
{
    public class ForwardAndBackward : MonoBehaviour
    {
        public float movementTimer;
        public float movementSpeed = 1.8f;
        private float turningPoint = 3.0f; //A specific time point. 

        // Start is called before the first frame update
        void Start()
        {
            movementTimer = 0.0f;
        }

        // Update is called once per frame
        void Update()
        {
            movementTimer += Time.deltaTime;
            Vector3 EnemyMovementS1 = Vector3.right * movementSpeed;

            if (movementTimer <= turningPoint) //Before turn around
            {
                this.transform.localRotation = Quaternion.Euler(0, 180, 0);
                transform.Translate(EnemyMovementS1 * Time.deltaTime);
            }

            if (movementTimer > turningPoint) //Turn around after 3rd second.
            {
                this.transform.localRotation = Quaternion.Euler(0, 0, 0);
                transform.Translate(EnemyMovementS1 * Time.deltaTime);
            }

            if (movementTimer >= 6.0f) //Timer set to zero.
            {
                movementTimer = 0.0f;
            }

        }
    }
}
