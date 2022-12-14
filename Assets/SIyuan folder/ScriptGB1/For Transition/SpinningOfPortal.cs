using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningOfPortal : MonoBehaviour
{
        public float degreesPerSecondT = 15.0f;
       

        public void Update()
        {
            transform.Rotate(0, 0, -degreesPerSecondT * Time.deltaTime); //z axis rotation.

        }
    
}
