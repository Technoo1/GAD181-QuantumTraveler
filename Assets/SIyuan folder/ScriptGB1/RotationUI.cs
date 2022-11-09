using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace S1
{
    public class RotationUI : MonoBehaviour
    {
        public InnerTimerDraft1 checkT1; //Call from the Timer script.
        public float degreesPerSecond = 12.0f;
        public float DSpeed2 = 60.0f;
        public float DSpeed3 = 180.0f;

        public void Update()
        {
            transform.Rotate(0, 0, degreesPerSecond * Time.deltaTime); //z axis rotation.

            if (checkT1.difficultyL2 == true)
            {
                degreesPerSecond = DSpeed2;
            }
            else if (checkT1.difficultyL3 == true)
            {
                degreesPerSecond = DSpeed3;
            }

        }
    }
}
