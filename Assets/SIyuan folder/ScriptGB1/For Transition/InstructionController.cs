using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InstructionController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Return))
        {
            SceneManager.LoadScene("ControlTutorialScene");
        }
    }
}
