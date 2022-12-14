using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransfer2 : MonoBehaviour
{
    public float timerT2;
    // Start is called before the first frame update
    void Start()
    {
        timerT2 = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        timerT2 +=  Time.deltaTime;

        if (timerT2 >= 4.0f)
        {
            SceneManager.LoadScene("TestMainMenu");
        }
    }
}
