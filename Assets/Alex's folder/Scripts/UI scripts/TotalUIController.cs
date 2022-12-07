using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace FT
{
    public class TotalUIController : MonoBehaviour
    {
        [SerializeField] public Health playerLifeCheck;
        public ItemCollector GetQPiece;
        public bool CanvasCheckB = false;
        public GameObject CanvasB;
        public GameObject CanvasC;
        public GameObject Yes;
        public GameObject No;
        public GameObject QPiece;
        public bool ResetScene;
        public GameObject PlayerAlex;
        public GameObject EnemyFT;

        public void start()
        {
            ResetScene = false;
        }

        public void Update()
        {
            if (playerLifeCheck.currentHealth <= 0 && CanvasCheckB == false)
            {
                CanvasB.SetActive(true);
                Yes.SetActive(true);
                ResetScene = true;
                No.SetActive(false);
                QPiece.SetActive(false);
                CanvasCheckB = true;
                Destroy(PlayerAlex);
                Destroy(EnemyFT);
            }
            if (Input.GetKey(KeyCode.RightArrow) && CanvasCheckB == true)
            {
                Yes.SetActive(false);
                ResetScene = false;
                No.SetActive(true);
            }
            else if (Input.GetKey(KeyCode.LeftArrow) && CanvasCheckB == true)
            {
                Yes.SetActive(true);
                ResetScene = true;
                No.SetActive(false);
            }

            if (GetQPiece.teleport == true)
            {
                SceneManager.LoadScene("TransitionANI4");
            }
            

            if (ResetScene == true && Input.GetKeyDown(KeyCode.Return) && CanvasCheckB == true)
            {
                SceneManager.LoadScene("Fame Trap");
            }

            if (ResetScene == false && Input.GetKeyDown(KeyCode.Return) && CanvasCheckB == true)
           {
               SceneManager.LoadScene("TestMainMenu");
           }
           
        }
    }
}
