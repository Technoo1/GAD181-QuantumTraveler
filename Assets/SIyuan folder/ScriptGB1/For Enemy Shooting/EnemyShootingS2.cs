using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace S1
{
    public class EnemyShootingS2 : MonoBehaviour
    {
        public GameObject _bulletS1L;
        public GameObject _bulletS1R;
        bool EnemyleftCheck = true;
        bool EnemyrightCheck = false;
        public AnotherMovement DirectionCheck;  //Call from EnemyMovement script to check face direction.
        public int fireCheckS2 = 0;
        public int fireRate = 8; //Set as default difficulty level 1.
        Vector3 ShootPosition; //Set a Vector3 position for shooting distance
        public InnerTimerDraft1 checkT1; //Call from the Timer script.

        public void Update()
        {
            fireCheckS2 = Random.Range(0, 1000); //Returns random int number between 0-999.
            if (checkT1.difficultyL2 == true) //Use variables from another script.
            {
                fireRate = 30; //Difficulty level 2.
            }
            else if (checkT1.difficultyL3 == true)
            {
                fireRate = 100; //Difficulty level 3.
            }

            if (DirectionCheck.movementTimer2 < 2.3f)
            {
                EnemyleftCheck = true;
                EnemyrightCheck = false;
            }
            else if (DirectionCheck.movementTimer2 > 2.3f)
            {
                EnemyleftCheck = false;
                EnemyrightCheck = true;
            }
        }

        private void FixedUpdate()
        {
            if (fireCheckS2 <= fireRate && EnemyleftCheck == true)
            {
                ShootPosition = transform.position + new Vector3(-1.1f, 0, 0);

                Instantiate(_bulletS1L, ShootPosition, Quaternion.identity);
            }

            if (fireCheckS2 <= fireRate && EnemyrightCheck == true)
            {
                ShootPosition = transform.position + new Vector3(1.1f, 0, 0);

                Instantiate(_bulletS1R, ShootPosition, Quaternion.identity);
            }
        }
    }
}
