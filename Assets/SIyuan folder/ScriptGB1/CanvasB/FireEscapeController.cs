using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace S1
{
 public class FireEscapeController : MonoBehaviour
 {
    [SerializeField] public HealthS1 playerLifeCheck;
    public DrMTakeDamage GetQPieceF;
    public bool CanvasCheckB = false;
    public GameObject CanvasB;
    public GameObject CanvasC;
    public GameObject FlashBack;
    public GameObject Nope;
    public GameObject QPieceF;
    public bool ResetScene;
    public GameObject PlayerS1;

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
                QPieceF.SetActive(false);
                CanvasCheckB = true;
                Time.timeScale = 0f;

                Destroy(PlayerS1);
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

            if (GetQPieceF.teleport == true)
            {
               Time.timeScale = 1f;
               SceneManager.LoadScene("TransitionANI5");
            }

            if (ResetScene == true && Input.GetKeyDown(KeyCode.Return) && CanvasCheckB == true)
            {
                Time.timeScale = 1f;
                SceneManager.LoadScene("FireEscape");
            }

             if (ResetScene == false && Input.GetKeyDown(KeyCode.Return) && CanvasCheckB == true)
            {
                Time.timeScale = 1f;
                SceneManager.LoadScene("TestMainMenu");
            }
        }
    }
}
