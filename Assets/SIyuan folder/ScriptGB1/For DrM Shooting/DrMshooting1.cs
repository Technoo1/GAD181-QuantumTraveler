using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace S1
{
    public class DrMshooting1 : MonoBehaviour
    {
        [SerializeField] private GameObject _bulletS2R; //bullet objects with different directions.
        [SerializeField] private GameObject _bulletS2L;
        bool leftCheck = false;
        bool rightCheck = true;
        Vector3 ShootPosition; //Set a Vector3 position for shooting distance
        public AudioSource DrmShoot;

        void Update()
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                leftCheck = false;
                rightCheck = true;
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                leftCheck = true;
                rightCheck = false;
            }

            if (Input.GetKeyUp(KeyCode.Z))   //Use GetKeyUp here! 
            {

                if (rightCheck == true)
                {
                    ShootPosition = transform.position + new Vector3(1f, 0, 0);

                    Instantiate(_bulletS2R, ShootPosition, Quaternion.identity);

                    DrmShoot.Play();
                }

                if (leftCheck == true)
                {
                    ShootPosition = transform.position + new Vector3(-1f, 0, 0);

                    Instantiate(_bulletS2L, ShootPosition, Quaternion.identity);

                    DrmShoot.Play();
                }
            }
        }
    }
}