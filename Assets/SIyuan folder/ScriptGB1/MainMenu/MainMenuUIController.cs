using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUIController : MonoBehaviour
{
    public bool StartGame;
    public GameObject StartIcon;
    public GameObject QuitIcon;
    
    void Start()
    {
        StartGame = true;
    }

    void Update()
    {
         if (Input.GetKey(KeyCode.UpArrow) )
         {
             StartGame = true;
              StartIcon.SetActive(true);
                QuitIcon.SetActive(false);
         }

          if (Input.GetKey(KeyCode.DownArrow) )
         {
             StartGame = false;
              StartIcon.SetActive(false);
                QuitIcon.SetActive(true);
         }

          if (StartGame == true && Input.GetKeyDown(KeyCode.Z))
            {
                SceneManager.LoadScene("SoldierBoy");
            }
    }
}
