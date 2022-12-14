using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace S1
{
    public class BackGroundMusicControllerS : MonoBehaviour
    {
        public AudioSource BackGrounM1;
        public InnerTimerDraft1 TimeCheckSFX;
        public TotalUIcontroller checkCanvasB;
        public AudioSource phaseMenuM1;
        public bool phaseMusic;
        public AudioSource EnemyShootS1;
        public bool GameOverMusic;
        public AudioSource GameOverSFX;


        void Start()
        {
            phaseMusic = false;
            GameOverMusic = false;
        }

        void Update()
        {
           

            if (checkCanvasB.CanvasCheckB == true && phaseMusic == false && GameOverMusic == false)
            {
                BackGrounM1.volume = 0.0f;
                EnemyShootS1.volume = 0.0f;
                GameOverSFX.Play();
                phaseMenuM1.Play();
                phaseMusic = true;
                GameOverMusic = true;
            }
        }
    }
}
