using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace S1
{

    public class HealthBarS1 : MonoBehaviour
    {
        [SerializeField] private HealthS1 playerHealth;
        [SerializeField] private Image totalHealthBar;
        [SerializeField] private Image currentHealthBar;

        private void Start()
        {
            totalHealthBar.fillAmount = playerHealth.currentHealth / 4;
        }

        private void Update()
        {
            currentHealthBar.fillAmount = playerHealth.currentHealth / 4;
        }
    }
}