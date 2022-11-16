using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace S1
{
 public class TotalUIcontriller : MonoBehaviour
 {
    [SerializeField] public HealthS1 playerLifeCheck;
    public DrMTakeDamage GetQPiece;
    public bool CanvasCheckB = false;
    public GameObject CanvasB;
    public GameObject CanvasC;
    public GameObject FlashBack;
    public GameObject Nope;
    public GameObject QPiece;
    public bool ResetScene;  

    public void start()
    {
        ResetScene = false;
    }

        public void Update()
        {
            if (playerLifeCheck.currentHealth <= 0 && CanvasCheckB == false)
            {
                CanvasB.SetActive(true);
                FlashBack.SetActive(true);
                ResetScene = true;
                Nope.SetActive(false);
                QPiece.SetActive(false);
                CanvasCheckB = true;
            }
            if (Input.GetKey(KeyCode.RightArrow) && CanvasCheckB == true)
            {
                FlashBack.SetActive(false);
                ResetScene = false;
                Nope.SetActive(true);
            }
            else if (Input.GetKey(KeyCode.LeftArrow) && CanvasCheckB == true)
            {
                FlashBack.SetActive(true);
                ResetScene = true;
                Nope.SetActive(false);
            }

            if (GetQPiece.teleport == true)
            {
                CanvasC.SetActive(true);
            }

            if (ResetScene == true && Input.GetKeyDown(KeyCode.Z))
            {
                SceneManager.LoadScene("SoldierBoy");
            }
        }
    }
}
