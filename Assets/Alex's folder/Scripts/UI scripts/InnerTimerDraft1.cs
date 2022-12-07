using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FT
{

    public class InnerTimerDraft1 : MonoBehaviour
    {
        public float difficultyCheckL2 = 10f;
        public float difficultyCheckL3 = 20f;    //Set the time point of difficulty level to be change.
        public float innerTimerG2 = 0.0f;           //Yes, a timer.
        public bool difficultyL1;
        public bool difficultyL2;
        public bool difficultyL3;

        // Update is called once per frame
        void Start()
        {
            difficultyL1 = true;
            difficultyL2 = false;
            difficultyL3 = false;
        }
        void Update()
        {
            innerTimerG2 += Time.deltaTime;

            if (innerTimerG2 >= difficultyCheckL2 && innerTimerG2 < difficultyCheckL3)  //When reach the specific time point.
            {
                difficultyL1 = false;
                difficultyL2 = true;
            }
            else if (innerTimerG2 >= difficultyCheckL3)
            {
                difficultyL2 = false;
                difficultyL3 = true;
            }
        }
    }
}