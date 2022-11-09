using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FT 
{
public class PickUpChip : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<PlayerMovement>();
            Destroy(this.gameObject);
        }


    }
}

}
