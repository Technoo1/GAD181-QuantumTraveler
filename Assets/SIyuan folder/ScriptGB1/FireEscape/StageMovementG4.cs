using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace S1
{

    public class StageMovementG4 : MonoBehaviour
    {
        public float movementTimer4;
        public float movementSpeed4 = 2.0f;
        private float turningPoint4 = 2.2f; //A specific time point. 

        // Start is called before the first frame update
        void Start()
        {
            movementTimer4 = 0.0f;
        }

        // Update is called once per frame
        void Update()
        {
            movementTimer4 += Time.deltaTime;
            Vector3 StageMovementS1 = Vector3.left * movementSpeed4;
            Vector3 StageMovementS2 = Vector3.right * movementSpeed4;

            if (movementTimer4 <= turningPoint4) //Before turn around
            {

                transform.Translate(StageMovementS1 * Time.deltaTime);
            }

            if (movementTimer4 > turningPoint4) //Turn around after 3rd second.
            {

                transform.Translate(StageMovementS2 * Time.deltaTime);
            }

            if (movementTimer4 >= 4.4f) //Timer set to zero.
            {
                movementTimer4 = 0.0f;
            }

        }
    }
}
