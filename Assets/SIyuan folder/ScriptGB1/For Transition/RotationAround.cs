using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationAround : MonoBehaviour
{
    public GameObject targetPoint;

    void Update()
    {
        // Spin the object around the target at 230 degrees/second.
        transform.RotateAround(targetPoint.transform.position, Vector3.forward, -230 * Time.deltaTime);
    }
}
