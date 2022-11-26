using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUIController : MonoBehaviour
{
    public bool StartGame;
    public bool ShowCredit;
    public bool ExitGame;
    public GameObject StartIcon;
    public GameObject QuitIcon;
    public GameObject CreditIcon;
    
    void Start()
    {
        StartGame = true;
        ShowCredit = false;
        ExitGame = false;

    }

    void Update()
    {
         if (Input.GetKeyDown(KeyCode.UpArrow) && StartGame == true && ShowCredit == false && ExitGame == false)
         {
             StartGame = true;
             ShowCredit = false;
             ExitGame = false;
              StartIcon.SetActive(true);
              CreditIcon.SetActive(false);
                QuitIcon.SetActive(false);
         }

         if (Input.GetKeyDown(KeyCode.UpArrow) && StartGame == false && ShowCredit == true && ExitGame == false)
         {
             StartGame = true;
             ShowCredit = false;
             ExitGame = false;
              StartIcon.SetActive(true);
              CreditIcon.SetActive(false);
                QuitIcon.SetActive(false);
         }

         if (Input.GetKeyDown(KeyCode.UpArrow) && StartGame == false && ShowCredit == false && ExitGame == true)
         {
             StartGame = false;
             ShowCredit = true;
             ExitGame = false;
              StartIcon.SetActive(false);
              CreditIcon.SetActive(true);
                QuitIcon.SetActive(false);
         }

          if (Input.GetKeyDown(KeyCode.DownArrow) && StartGame == true && ShowCredit == false && ExitGame == false)
         {
            StartGame = false;
            ShowCredit = true;
            ExitGame = false;
             
              StartIcon.SetActive(false);
              CreditIcon.SetActive(true);
               QuitIcon.SetActive(false);

         }

          if (Input.GetKeyDown(KeyCode.DownArrow) && StartGame == false && ShowCredit == true && ExitGame == false)
         {
             StartGame = false;
             ShowCredit = false;
             ExitGame = true;
              StartIcon.SetActive(false);
              CreditIcon.SetActive(false);
                QuitIcon.SetActive(true);
         }
         

          if (Input.GetKeyDown(KeyCode.DownArrow) && StartGame == false && ShowCredit == false && ExitGame == true)
         {
             StartGame = false;
              ShowCredit = false;
              ExitGame = true;
              StartIcon.SetActive(false);
              CreditIcon.SetActive(false);
                QuitIcon.SetActive(true);
         }


          if (StartGame == true && Input.GetKeyDown(KeyCode.Z))
            {
                SceneManager.LoadScene("TransitionANI1");
            }
    }
}
