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

       private void Update()
       {
           if (Input.GetKeyDown(KeyCode.E))
           TakeDamage(1);
       }


    }
}

