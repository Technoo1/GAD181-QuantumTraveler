using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShootingS1Left : MonoBehaviour 
{
    [SerializeField] private GameObject _bulletS1L;
    public int fireCheckS1 = 0;
    public int fireRate = 8; //Set as default difficulty level 1.
    Vector3 ShootPosition; //Set a Vector3 position for shooting distance
    public InnerTimerDraft1 checkT1; //Call from the Timer script.

    public void Update()
    {
       fireCheckS1 = Random.Range(0, 1000); //Returns random int number between 0-999.
        if (checkT1.difficultyL2 == true) //Use variables from another script.
        {
            fireRate = 30; //Difficulty level 2.
        }
        else if (checkT1.difficultyL3 == true)
        {
            fireRate = 100; //Difficulty level 3.
        }
    }

    private void FixedUpdate()
    {
        if (fireCheckS1 <= fireRate)
        {
            ShootPosition = transform.position + new Vector3(-0.8f, 0, 0);

                Instantiate(_bulletS1L, ShootPosition, Quaternion.identity);
        }
    }
}
