using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FT
{
    [RequireComponent(typeof(AudioSource))]
    public class Health : MonoBehaviour
    {
        [SerializeField] private float startingHealth;
        [SerializeField] public float currentHealth { get; private set; }
        private Animator anim; 
        public PlayerTakesDamage hitCheck;
        private bool takingDamage = false;
        private float damageTime = 0.5f;
        private float curTime = 0f;

        public AudioClip takeDamageSFX;
        AudioSource audioSource; 

        private void Awake()
        {
            currentHealth = startingHealth;
            anim = GetComponent<Animator>();
            audioSource = GetComponent<AudioSource>(); 
        }


        public void TakeDamage(float damage)
        {
            currentHealth -= damage;
            Debug.Log("Damaged, current health " + currentHealth + " minus " + damage);
            if (currentHealth > 0)
            {
                anim.SetBool("TakesDamage", true);   //these will trigger the animations 
                audioSource.PlayOneShot(takeDamageSFX, 1f);
                takingDamage = true;
            }
        }


        //uncomment to test if the health bar is correctly recording current health 
       public void Update()
       {
            if (takingDamage)
            {
                if(curTime < damageTime)
                {
                    curTime += Time.deltaTime;
                }
                else
                {
                    anim.SetBool("TakesDamage", false);
                    curTime = 0f;
                    takingDamage = false;
                }
            }
            if (hitCheck.hit == 1)
            {
                Debug.Log("Hit " + hitCheck.hit);
                TakeDamage(1);
                hitCheck.hit = 0;
            }

           if (Input.GetKeyDown(KeyCode.E))
            {
                TakeDamage(1);
            }
       }


    }



}

