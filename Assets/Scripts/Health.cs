using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace TG
{

public class Health : MonoBehaviour
{
    [SerializeField] private float startingHealth; 
    public float currentHealth {get; private set;} 
    public PlayerTakeDamage hitByBullet;
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
       if (hitByBullet.hitCheck == 1)
       {
           TakeDamage(1);
           hitByBullet.hitCheck = 0;
       }

        if (Input.GetKeyDown(KeyCode.E))
        TakeDamage(1);
    }

}



}



