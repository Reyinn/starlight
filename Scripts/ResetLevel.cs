using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetLevel : MonoBehaviour
{

    public string currentLevel;
        void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(currentLevel);
            }
        if(Input.GetKeyDown(KeyCode.Q))
            {
                SceneManager.LoadScene("MainMenu");
            }    
    }
}
