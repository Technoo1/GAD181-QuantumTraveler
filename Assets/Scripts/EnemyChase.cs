using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChase : MonoBehaviour
{
    public Transform player;
    public float speed;


    // Update is called once per frame
    void Update()
    {

        Vector3 pos = new Vector3(player.position.x, transform.position.y, transform.position.z);

        transform.position = Vector3.MoveTowards(this.transform.position, pos, speed * Time.deltaTime);

    }
}
