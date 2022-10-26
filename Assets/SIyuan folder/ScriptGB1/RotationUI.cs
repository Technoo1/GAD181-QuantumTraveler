using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationUI : MonoBehaviour
{
    public float degreesPerSecond = 10.0f;
    public float DSpeed2 = 25.0f;
    public float DSpeed3 = 65.0f;
    public InnerTimerDraft1 checkT1; //Call from the Timer script.
    public void Update()
    {
        transform.Rotate(0, 0, degreesPerSecond * Time.deltaTime);

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
