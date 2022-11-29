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
   public float shootSpeed;
   private float shootSpeedTime;

   void Update() 
   {
        if (shootSpeedTime <= 0f)
        {
            Shoot();
            shootSpeedTime = shootSpeed;
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
