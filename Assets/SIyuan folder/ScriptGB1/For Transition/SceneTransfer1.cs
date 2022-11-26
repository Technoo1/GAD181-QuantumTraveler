using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransfer1 : MonoBehaviour
{
    public float timerT1;
    // Start is called before the first frame update
    void Start()
    {
        timerT1 = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        timerT1 +=  Time.deltaTime;

        if (timerT1 >= 4.0f)
        {
            SceneManager.LoadScene("SoldierBoy");
        }
    }
}
