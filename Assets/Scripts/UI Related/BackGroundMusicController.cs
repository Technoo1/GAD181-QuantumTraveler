using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace TG
{
    public class BackGroundMusicController : MonoBehaviour
    {
        public AudioSource BackGroundM2;
        public InnerTimerDraft1 TimeCheckSFX;
        public TotalUIcontriller checkCanvasB;
        public AudioSource phaseMenuM1;
        public bool phaseMusic;
        //public AudioSource EnemyShoot;
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
                BackGroundM2.volume = 0.0f;
                //EnemyShoot.volume = 0.0f;
                phaseMenuM1.Play();
                phaseMusic = true;
            }
        }
    }
}
