using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FT 
{
public class PickUpChip : MonoBehaviour
{
    [SerializeField] private AudioClip itemSound;

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            SoundManager.instance.PlaySound(itemSound);
            other.gameObject.GetComponent<PlayerMovement>();
            Destroy(this.gameObject);
        }


    }
}

}
