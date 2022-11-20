using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace S1
{
    public class BackGroundMusicController : MonoBehaviour
    {
        public AudioSource BackGrounM1;
        public InnerTimerDraft1 TimeCheckSFX;
        public TotalUIcontriller checkCanvasB;
        public AudioSource phaseMenuM1;
        public bool phaseMusic;
        public AudioSource EnemyShootS1;
        void Start()
        {
            phaseMusic = false;
        }

        void Update()
        {
            if (TimeCheckSFX.difficultyL2 == true)
            {
                
            }

            if (checkCanvasB.CanvasCheckB == true && phaseMusic == false)
            {
                BackGrounM1.volume = 0.0f;
                EnemyShootS1.volume = 0.0f;
                phaseMenuM1.Play();
                phaseMusic = true;
            }
        }
    }
}
