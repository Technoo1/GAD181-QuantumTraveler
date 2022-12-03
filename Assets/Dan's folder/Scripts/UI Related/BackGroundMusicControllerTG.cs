using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace TG
{
    public class BackGroundMusicControllerTG : MonoBehaviour
    {
        public AudioSource BackGroundM2;
        public InnerTimerDraft1 TimeCheckSFX;
        public TotalUIcontriller checkCanvasB;
        public AudioSource phaseMenuM1;
        public AudioSource GameOverSFX; //6 seconds length.
        public bool phaseMusic;
        public bool GameOverMusic;
        
        public GameObject SirenSound;
        void Start()
        {
            phaseMusic = false;
            GameOverMusic = false;
        }
            

        void Update()
        {

            if (checkCanvasB.CanvasCheckB == true && GameOverMusic == false && phaseMusic == false)
            {
                BackGroundM2.volume = 0.0f;
                
                GameOverSFX.Play();
                phaseMenuM1.Play();
                SirenSound.SetActive(false);
                GameOverMusic = true;
                phaseMusic = true;

            }
            
         
        }
        
    }
}
