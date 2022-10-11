using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShootingS1 : MonoBehaviour
{
   [SerializeField] private GameObject _bulletS1;
    public int fireCheckS1 = 0;
    public int fireRate = 25;
  
    private void Update()
    {
       fireCheckS1 = Random.Range(0, 1000); //returns random int number between 0-999.
    }

    private void FixedUpdate()
    {
        if (fireCheckS1 <= fireRate)
        {
            Instantiate(_bulletS1, transform.position, Quaternion.identity);
        }
    }
}
