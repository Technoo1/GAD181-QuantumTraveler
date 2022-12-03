using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransfer4 : MonoBehaviour
{
     public float timerT4;
    // Start is called before the first frame update
    void Start()
    {
        timerT4 = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        timerT4 +=  Time.deltaTime;

        if (timerT4 >= 4.0f)
        {
            SceneManager.LoadScene("FireEscape");
        }
    }
}
