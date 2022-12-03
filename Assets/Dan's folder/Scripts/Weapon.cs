using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace TG
{

public class Weapon : MonoBehaviour
{
   public Transform firePoint;
   public GameObject bulletPrefab;
   public AudioSource Fire;

   void Update() 
   {
        if (Input.GetKeyUp(KeyCode.Z))
        {
            Shoot();
        } 
   }

   void Shoot()
   {
        //shooting logic
        Fire.Play();
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
   }
}
}
