using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrMshooting1 : MonoBehaviour
{
    [SerializeField] private GameObject _bulletS2R; //bullet objects with different directions.
    [SerializeField] private GameObject _bulletS2L;
    bool leftCheck = false;
    bool rightCheck = true;
    Vector3 ShootPosition; //Set a Vector3 position for shooting distance

    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            leftCheck = false;
            rightCheck = true;
        }

        if (Input.GetKey(KeyCode.A))
        {
            leftCheck = true;
            rightCheck = false;
        }

        if (Input.GetKeyUp(KeyCode.J))   //Use GetKeyUp here! 
           {
            if (rightCheck == true)
             {
                ShootPosition = transform.position + new Vector3(1f, 0, 0);

                Instantiate(_bulletS2R, ShootPosition, Quaternion.identity);
             }

            if (leftCheck == true)
            {
                ShootPosition = transform.position - new Vector3(1f, 0, 0);    // Currently have a small bug here.

                Instantiate(_bulletS2L, transform.position, Quaternion.identity);
            }
        }
    }
}
