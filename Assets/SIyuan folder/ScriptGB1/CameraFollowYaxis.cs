using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowYaxis : MonoBehaviour
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
