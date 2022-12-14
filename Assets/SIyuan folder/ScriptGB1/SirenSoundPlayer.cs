using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace S1
{
    public class SirenSoundPlayer : MonoBehaviour
    {
        public AudioSource SirenSFX;
        public InnerTimerDraft1 TimeCheckSFX;
        public bool OnlyPlayOnceL2;
        public bool OnlyPlayOnceL3;
        void Start()
        {
            OnlyPlayOnceL2 = false;
            OnlyPlayOnceL3 = false;
        }

        void Update()
        {
            if (OnlyPlayOnceL2 == false && TimeCheckSFX.difficultyL2 == true)
            {
                SirenSFX.Play();
                OnlyPlayOnceL2 = true; //So this SFX only can be played once when difficultyL2 is ture.
            }

            if (OnlyPlayOnceL3 == false && TimeCheckSFX.difficultyL3 == true)
            {
                SirenSFX.Play();
                OnlyPlayOnceL3 = true; //So this SFX only can be played once when difficultyL3 is ture.
            }
        }
    }
}
