using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InnerTimerDraft1 : MonoBehaviour
{
    public float difficultyCheckL2 = 8.0f;
    public float difficultyCheckL3 = 16.0f;    //Set the time point of difficulty level to be change.
    public float innerTimerG1= 0.0f;           //Yes, a timer.
    public bool difficultyL1; 
    public bool difficultyL2;
    public bool difficultyL3;

    // Update is called once per frame
    void Start()
    {
        difficultyL1 = true;
        difficultyL2 = false;
        difficultyL3 = false;
    }
    void Update()
    {
        innerTimerG1 += Time.deltaTime;

        if (innerTimerG1 >= difficultyCheckL2 && innerTimerG1 < difficultyCheckL3)  //When reach the specific time point.
        {
            difficultyL1 = false;
            difficultyL2 = true;
        }
        else if (innerTimerG1 >= difficultyCheckL3)
        {
            difficultyL2 = false;
            difficultyL3 = true;
        }
    }
}
