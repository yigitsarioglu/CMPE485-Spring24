using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerCollison : MonoBehaviour
{
  void OnCollisionEnter(Collision collision)
    {
        // Çarpışmanın olduğu objenin etiketini kontrol et
        if (collision.gameObject.CompareTag("Trap"))
        {
            // Eğer player bir tuzakla çarpıştıysa, oyunu game over yap
            Debug.Log("Game Over!");
            
            SceneManager.LoadSceneAsync(2);

        }
    }
}
