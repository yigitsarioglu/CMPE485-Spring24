using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerCollison : MonoBehaviour
{

  bool caughtByGuard = false;  

  void OnCollisionEnter(Collision collision)
    {
        // Çarpışmanın olduğu objenin etiketini kontrol et
        if (collision.gameObject.CompareTag("Trap"))
        {
            // Eğer player bir tuzakla çarpıştıysa, oyunu game over yap
            Debug.Log("Game Over!");
            
            SceneManager.LoadSceneAsync(2);

        }

        if (collision.gameObject.CompareTag("Guard"))
        {
            // Player guard'ın önünden geçti mi? (Önünde birim bir mesafe olup olmadığı kontrol edilir)
            float distanceToGuard = Mathf.Abs(transform.position.x - collision.transform.position.x);
            if (distanceToGuard < 1f)
            {
                Debug.Log("Caught by Guard!");
                SceneManager.LoadSceneAsync(2);
            }
        }
    }
}
