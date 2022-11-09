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

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.E))
                TakeDamage(1);
        }

    }
}

