using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneChanger : MonoBehaviour
{
    public void PlayGame(){
        //SceneManager.LoadSceneAsync(1);
        SceneManager.LoadScene("Maze");
    }

    public void ExitGame(){
        // Oyunu kapat
        Application.Quit();
    }

    public void ReturnMainMenu(){
        // Main Menuye Dön
        SceneManager.LoadScene("MainMenu");
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


