using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DraftBullet2 : MonoBehaviour
{
    [SerializeField] private float _spd = 6.0f;

    private void Update()
    {
        BulletSiyuanMovement1();

        Object.Destroy(gameObject,2.4f);
        //Set a delay time to remove the bullet.
    }

    private void BulletSiyuanMovement1()
    {
        Vector3 bulletVelocityS1 = Vector3.left * _spd;
        transform.Translate(bulletVelocityS1 * Time.deltaTime);
    }

}
