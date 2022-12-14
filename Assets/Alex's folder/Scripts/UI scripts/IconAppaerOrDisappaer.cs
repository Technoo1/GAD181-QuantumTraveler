using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FT
{

public class IconAppaerOrDisappaer : MonoBehaviour
{

     public GameObject IconRun;
     public float TimePoint = 3.1f;
     public float timerFTIcon;
    // Start is called before the first frame update
    void Start()
    {
        timerFTIcon = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        timerFTIcon += Time.deltaTime;

        if(timerFTIcon >= TimePoint)
        {
            IconRun.SetActive(false);
        }
        
    }
}
}
