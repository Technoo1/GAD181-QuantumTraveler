using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FT
{

    public class Health : MonoBehaviour
    {
        [SerializeField] private float startingHealth;
        [SerializeField] public float currentHealth { get; private set; }
        private Animator anim; 
        public PlayerTakesDamage hitCheck;

        private void Awake()
        {
            currentHealth = startingHealth;
            anim = GetComponent<Animator>();
        }


        public void TakeDamage(int damage)
        {
            currentHealth -= damage;
            if (currentHealth > 0)
            {
                anim.SetBool("TakesDamage", true);   //these will trigger the animations 
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
              //audio
              hitCheck.hit = 0;
            }

           if (Input.GetKeyDown(KeyCode.E))
           TakeDamage(1);
       }


    }



}

