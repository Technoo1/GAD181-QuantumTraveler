using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace S1
{
    public class AnotherMovement : MonoBehaviour
    {
        public float movementTimer2;
        public float movementSpeed2 = 3.5f;
        private float turningPoint2 = 2.3f; //A specific time point. 

        // Start is called before the first frame update
        void Start()
        {
            movementTimer2 = 0.0f;
        }

        // Update is called once per frame
        void Update()
        {
            movementTimer2 += Time.deltaTime;
            Vector3 EnemyMovementS1 = Vector3.right * movementSpeed2;

            if (movementTimer2 <= turningPoint2) //Before turn around
            {
                this.transform.localRotation = Quaternion.Euler(0, 180, 0);
                transform.Translate(EnemyMovementS1 * Time.deltaTime);
            }

            if (movementTimer2 > turningPoint2) //Turn around after 3rd second.
            {
                this.transform.localRotation = Quaternion.Euler(0, 0, 0);
                transform.Translate(EnemyMovementS1 * Time.deltaTime);
            }

            if (movementTimer2 >= 4.6f) //Timer set to zero.
            {
                movementTimer2 = 0.0f;
            }

        }
    }
}
