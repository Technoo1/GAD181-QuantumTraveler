using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FT
{
    public class BackgroundMusicController : MonoBehaviour
    {
        public AudioSource BackGroundM2;
        public InnerTimerDraft1 TimeCheckSFXFT;
        public TotalUIController checkCanvasB;
        public AudioSource phaseMenuFT;
        public bool phaseMusicFT;
        public AudioSource SirenSFX;
        public bool GameOverMusicFT;
        public AudioSource GameOverSFX;

        void Start()
        {
            phaseMusicFT = false;
            GameOverMusicFT = false;
        }

        void Update()
        {
            if (TimeCheckSFXFT.difficultyL2 == true)
            {

            }

            if (checkCanvasB.CanvasCheckB == true && phaseMusicFT == false && GameOverMusicFT == false)
            {
                BackGroundM2.volume = 0.0f;
                SirenSFX.volume = 0.0f;
                phaseMenuFT.Play();
                GameOverSFX.Play();
                phaseMusicFT = true;
                GameOverMusicFT = true;
            }
        }
    }
}