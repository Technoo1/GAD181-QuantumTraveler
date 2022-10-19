using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShootingS1Left : MonoBehaviour
{
    [SerializeField] private GameObject _bulletS1L;
    public int fireCheckS1 = 0;
    public int fireRate = 25;
    Vector3 ShootPosition; //Set a Vector3 position for shooting distance
  
    private void Update()
    {
       fireCheckS1 = Random.Range(0, 1000); //returns random int number between 0-999.
    }

    private void FixedUpdate()
    {
        if (fireCheckS1 <= fireRate)
        {
            ShootPosition = transform.position + new Vector3(-0.7f, 0, 0);

                Instantiate(_bulletS1L, ShootPosition, Quaternion.identity);
        }
    }
}
