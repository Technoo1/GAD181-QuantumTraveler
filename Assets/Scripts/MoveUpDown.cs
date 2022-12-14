using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace TG
{
public class MoveUpDown : MonoBehaviour
{
  public float movementTimerT;
        public float movementSpeedT = 0.5f;
        private float turningPointT = 1.1f; //A specific time point. 

        // Start is called before the first frame update
        void Start()
        {
            movementTimerT = 0.0f;
        }

        // Update is called once per frame
        void Update()
        {
            movementTimerT += Time.deltaTime;
            Vector3 StageMovementT = Vector3.down * movementSpeedT;
            Vector3 StageMovementT2 = Vector3.up * movementSpeedT;

            if (movementTimerT <= turningPointT) //Before turn around
            {

                transform.Translate(StageMovementT * Time.deltaTime);
            }

            if (movementTimerT > turningPointT) //Turn around after 3rd second.
            {

                transform.Translate(StageMovementT2 * Time.deltaTime);
            }

            if (movementTimerT >= 2.2f) //Timer set to zero.
            {
                movementTimerT = 0.0f;
            }
        }

}
}
