using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationUI : MonoBehaviour
{
    public InnerTimerDraft1 checkT1; //Call from the Timer script.
    public float degreesPerSecond = 10.0f;
    public float DSpeed2 = 35.0f;
    public float DSpeed3 = 70.0f;
    
    public void Update()
    {
        transform.Rotate(0, 0, degreesPerSecond * Time.deltaTime); //z axis rotation.

        if (checkT1.difficultyL2 == true)
        {
            degreesPerSecond = DSpeed2;
        }
        else if (checkT1.difficultyL3 == true)
        {
            degreesPerSecond = DSpeed3;
        }

    }
}
