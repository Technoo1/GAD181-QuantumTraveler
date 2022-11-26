using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToward : MonoBehaviour
{
    public float speed = 1.0f;

    public Transform targetPoint;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var step =  speed * Time.deltaTime; // calculate distance to move
        transform.position = Vector3.MoveTowards(transform.position, targetPoint.position, step);
    }
}
