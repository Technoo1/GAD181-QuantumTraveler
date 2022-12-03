using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransfer5 : MonoBehaviour
{
       public float timerT5;
    // Start is called before the first frame update
    void Start()
    {
        timerT5 = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        timerT5 +=  Time.deltaTime;

        if (timerT5 >= 4.0f)
        {
            SceneManager.LoadScene("EndScene");
        }
    }
}
