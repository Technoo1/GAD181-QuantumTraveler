using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace TG
{

public class CameraMovement : MonoBehaviour
{
   public InnerTimerDraft1 TimerG2;
   public float cameraSpeed = 10f;
   public float FlySpeed2 = 25f;
   public float FlySpeed3 = 50f;

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(cameraSpeed * Time.deltaTime, 0, 0);

        if (TimerG2.difficultyL2 == true)
        {
            cameraSpeed = FlySpeed2;
        }
        else if (TimerG2.difficultyL3 == true)
        {
            cameraSpeed = FlySpeed3;
        }
    }
}

}


