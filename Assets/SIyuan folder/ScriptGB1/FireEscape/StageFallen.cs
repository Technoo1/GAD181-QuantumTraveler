using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace S1
{

    public class StageFallen : MonoBehaviour
    {
        public float FallenTimer;
        public float FallenSpeed;
        public float FallenPoint = 2.0f; //A specific time point. 
        void Start()
        {
            FallenTimer = 0.0f;
            FallenSpeed = 1.0f;
        }

        // Update is called once per frame
        void Update()
        {
            FallenTimer += Time.deltaTime;
            Vector3 StageFallen = Vector3.down * FallenSpeed;

            if (FallenTimer > FallenPoint)
            {
                transform.Translate(StageFallen * Time.deltaTime);
                FallenSpeed = FallenSpeed + 0.12f;
            }

            if (FallenTimer > 10.0f)
            {
                Destroy(gameObject);
            }
        }
    }
}
