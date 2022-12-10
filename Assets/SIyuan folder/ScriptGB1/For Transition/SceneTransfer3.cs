using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransfer3: MonoBehaviour
{
    
     public float timerT3;
    // Start is called before the first frame update
    void Start()
    {
        timerT3 = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        timerT3 +=  Time.deltaTime;

        if (timerT3 >= 4.0f)
        {
            SceneManager.LoadScene("TopGun");
        }
    }
}
