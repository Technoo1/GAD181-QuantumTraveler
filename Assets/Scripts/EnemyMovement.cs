using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FT

{

    public class EnemyMovement : MonoBehaviour
    {
        public float EnemySpeedFT = 1.0f;
        public bool phase;
        public InnerTimerDraft1 TimerFT;
        public float phaseTimer1 = 4.0f;
        public float phaseTimer2 = 2.5f;
        public float phaseTimer3 = 1.0f;
        public float phaseTime;
        public int phasehit;

        public PlayerTakesDamage phaseCheck;

        // Start is called before the first frame update
        void Start()
        {
            phase = false;
            phaseTime = 0.0f;
        }

        // Update is called once per frame
        void Update()
        {
            Vector3 EnemyMovementFT = Vector3.right * EnemySpeedFT;

            if (phaseTime >= 0.0f)
            {
                phaseTime -= Time.deltaTime;
            }

            if (phaseTime <= 0.0f)
            {
                phase = false;
            }

            if (TimerFT.difficultyL2 == false && TimerFT.difficultyL3 == false && phaseCheck.phasehit == 1)
            {
                phaseTime = phaseTimer1;

                phase = true;

                phaseCheck.phasehit = 0;

            }

            if ( TimerFT.difficultyL2 == true && TimerFT.difficultyL3 == false && phaseCheck.phasehit == 1)
            {
                phaseTime = phaseTimer2;

                phase = true;

                phaseCheck.phasehit = 0;

            }

            if (TimerFT.difficultyL3 == true && phaseCheck.phasehit == 1)
            {
                phaseTime = phaseTimer3;

                phase = true;

                phaseCheck.phasehit = 0;

            }

            if (phase == false) 
            {
               
                transform.Translate(EnemyMovementFT * Time.deltaTime);
            }

        }
    }
}
