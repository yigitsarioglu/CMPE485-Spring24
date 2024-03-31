using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
   [SerializeField] TextMeshProUGUI timerText;
   float elapsedTime;
   private bool isPaused = false;


   void Update()
   {
      elapsedTime += Time.deltaTime ;
      int  minutes = Mathf.FloorToInt(elapsedTime/60);
      int seconds = Mathf.FloorToInt(elapsedTime % 60);

      //timerText.text = elapsedTime.ToString();
      timerText.text = string.Format("{0:00}:{1:00}",minutes,seconds);

      // Kullanıcı "P" tuşuna bastığında oyunu duraklat veya devam ettir
      if (Input.GetKeyDown(KeyCode.P))
      {
         TogglePause();
      }
   }

   public void TogglePause()
    {
        // Oyun duraklatılmışsa devam ettir, devam ediyorsa duraklat
        if (isPaused)
        {
            Time.timeScale = 1f;
        }
        else
        {
            Time.timeScale = 0f;
        }

        // Duraklatma durumunu güncelle
        isPaused = !isPaused;
    }
}