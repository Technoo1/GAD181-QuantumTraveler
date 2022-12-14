using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace S1
{

    public class RotationForFinalPortal : MonoBehaviour
    {
        public float degreesPerSecond = 45.0f;


        public void Update()
        {
            transform.Rotate(0, 0, degreesPerSecond * Time.deltaTime); //z axis rotation.

        }
    }
}
