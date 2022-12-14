using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace S1
{
    public class FireMovement : MonoBehaviour
    {
        public float FireMovementSpeed1 = 1.0f;
        public float FireMovementSpeed2 = 3.0f;
        public InnerTimerDraft1 TimerG4;

        // Update is called once per frame
        void Update()
        {
            Vector3 StageMovementG41 = Vector3.up * FireMovementSpeed1;
            Vector3 StageMovementG42 = Vector3.up * FireMovementSpeed2;
            if (TimerG4.difficultyL2 == true)
            {
                transform.Translate(StageMovementG41 * Time.deltaTime);
            }
            else if (TimerG4.difficultyL3 == true)
            {
                transform.Translate(StageMovementG42 * Time.deltaTime);
            }
        }
    }
}
