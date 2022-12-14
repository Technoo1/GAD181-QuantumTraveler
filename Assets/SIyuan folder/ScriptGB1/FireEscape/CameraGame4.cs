using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace S1
{ 

public class CameraGame4 : MonoBehaviour
{
    public Transform targetObject;

    void Start()
    {

    }

    void FixedUpdate()
    {
        Vector3 pos = new Vector3(transform.position.x, targetObject.position.y + 1.0f, transform.position.z);
        transform.position = pos;
    }
}
}
