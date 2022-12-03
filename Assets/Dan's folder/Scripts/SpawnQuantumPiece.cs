using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace TG
{

public class SpawnQuantumPiece : MonoBehaviour
{

    public GameObject QuantumPiece;
    public float maxXQp;
    public float minXQp;
    public float maxYQp;
    public float minYQp;
    public float timeSpawnQp;
    public float currentTime;
    public bool countDown;
    
    void Update()
    {
        currentTime = countDown ? currentTime -= Time.deltaTime : currentTime += Time.deltaTime;
        
        if( currentTime >= timeSpawnQp )
        {
            SpawnQp();
            currentTime = 0f;
        }
    }

  
    void SpawnQp()
    {
        //float randomXQp = Random.Range(minXQp, maxXQp);
        //float randomYQp = Random.Range(minYQp, maxYQp);

        Instantiate(QuantumPiece, transform.position + new Vector3(0, 0, 0), transform.rotation);
        
    }
}

}

