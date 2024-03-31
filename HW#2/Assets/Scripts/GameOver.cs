using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameOver : MonoBehaviour
{

    public void LoadMainScene()
    {
        // Ana oyun sahnesini yükle
        SceneManager.LoadScene("Maze");
    }


    public void ExitGame(){
        // Oyunu kapat
        Application.Quit();
    }

    
    void Update()
    {
        // Check for input to load main screen
        if (Input.GetKeyDown(KeyCode.X))
        {
            SceneManager.LoadScene("Maze");
        }

        // Check for input to quit game
        else if (Input.GetKeyDown(KeyCode.D))
        {
            Application.Quit();
        }

   
    }
}
