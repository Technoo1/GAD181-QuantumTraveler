using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace TG
{

public class EnemyWeapon : MonoBehaviour
{
   public Transform firePointEnemy;
   public GameObject EnemyBulletPrefab;
   public AudioSource EnemyFire;
   public float shootSpeed1 = 0.3f;
   public float shootSpeed2 = 0.7f;
   public float shootSpeed3 = 0.9f;
   private int pickOne;
   private float shootSpeedTime; //freeze time between shooting.  



   void Update() 
   {
        pickOne = Random.Range(0, 3);

        if (shootSpeedTime <= 0f && pickOne == 0)
        {
            Shoot();
            shootSpeedTime = shootSpeed1;
        } 
        else
        {
            shootSpeedTime -= Time.deltaTime;
        }

        if (shootSpeedTime <= 0f && pickOne == 1)
        {
            Shoot();
            shootSpeedTime = shootSpeed2;
        } 
        else
        {
            shootSpeedTime -= Time.deltaTime;
        }

        if (shootSpeedTime <= 0f && pickOne == 2)
        {
            Shoot();
            shootSpeedTime = shootSpeed3;
        } 
        else
        {
            shootSpeedTime -= Time.deltaTime;
        }


   }

   void Shoot()
   {
        //shooting logic
        EnemyFire.Play();
        Instantiate(EnemyBulletPrefab, firePointEnemy.position, firePointEnemy.rotation);
   }


        
}
}
