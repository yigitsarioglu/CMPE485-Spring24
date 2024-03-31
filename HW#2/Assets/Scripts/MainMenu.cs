using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
    public void PlayGame(){
        //SceneManager.LoadSceneAsync(1);
        SceneManager.LoadScene("Maze");
    }

    public void ExitGame(){
        // Oyunu kapat
        Application.Quit();
    }

}
