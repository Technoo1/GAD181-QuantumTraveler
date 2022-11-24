using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    [SerializeField] private AudioSource chipSound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Chip"))
        {
            chipSound.Play();
            Destroy(collision.gameObject);
        }
    }
}
