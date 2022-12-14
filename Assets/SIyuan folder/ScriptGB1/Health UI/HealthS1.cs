using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace S1
{
    public class HealthS1 : MonoBehaviour
    {
        [SerializeField] private float startingHealth;
        public float currentHealth { get; private set; }
        private Animator anim;
        public DrMTakeDamage hitCheck;
        public AudioSource DrMDamage;

        private void Awake()
        {
            currentHealth = startingHealth;
            anim = GetComponent<Animator>();
        }

        public void TakeDamage(float _damage)
        {
            currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);

            if (currentHealth > 0)
            {
                //anim.SetTrigger("hurt");   these will trigger the animations 
            }

            else
            {
                //anim.SetTrigger("die");
            }
        }
        //uncomment to test if the health bar is correctly recording current health 

        public void Update()
        {
            if (hitCheck.hit == 1)
            {
              TakeDamage(1);
              DrMDamage.Play();
              hitCheck.hit = 0;
            }

            if (hitCheck.hit == 2)
            {
                TakeDamage(4);
                DrMDamage.Play();
                hitCheck.hit = 0;
            }


            if (Input.GetKeyDown(KeyCode.E))
            {
              TakeDamage(1);
            }
        }

    }
}

