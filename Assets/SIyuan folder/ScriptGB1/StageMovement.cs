using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace S1
{
    public class StageMovement : MonoBehaviour
    {
        public float movementTimer3;
        public float movementSpeed3 = 1.0f;
        private float turningPoint3 = 4.0f; //A specific time point. 

        // Start is called before the first frame update
        void Start()
        {
            movementTimer3 = 0.0f;
        }

        // Update is called once per frame
        void Update()
        {
            movementTimer3 += Time.deltaTime;
            Vector3 StageMovementS1 = Vector3.down * movementSpeed3;
            Vector3 StageMovementS2 = Vector3.up * movementSpeed3;

            if (movementTimer3 <= turningPoint3) //Before turn around
            {

                transform.Translate(StageMovementS1 * Time.deltaTime);
            }

            if (movementTimer3 > turningPoint3) //Turn around after 3rd second.
            {

                transform.Translate(StageMovementS2 * Time.deltaTime);
            }

            if (movementTimer3 >= 8.0f) //Timer set to zero.
            {
                movementTimer3 = 0.0f;
            }

        }
    }
}
