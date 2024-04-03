using UnityEngine;
using System.Collections;


public class GuardMovement : MonoBehaviour
{
    public float moveDistance = 5000f; // Hareket mesafesi
    public float moveSpeed = 50f; // Hareket hızı
    public float moveInterval = 3f; // Hareket aralığı (saniye)

    private Vector3 startPosition; // Başlangıç pozisyonu
    private Vector3 targetPosition; // Hedef pozisyonu

    private bool movingForward = true; // İleri mi hareket ediyor, geri mi?

    private void Start()
    {
        startPosition = transform.position;
        targetPosition = startPosition + new Vector3(moveDistance, 0f, 0f); // Başlangıçta ileri doğru hareket et
        StartCoroutine(MoveSpear()); // Coroutine'i başlat
    }

    private IEnumerator MoveSpear()
    {
        while (true)
        {
            // Belirtilen hızda hedefe doğru hareket et
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

            // Eğer hedefe ulaşıldıysa, hedefi değiştir
            if (transform.position == targetPosition)
            {
                movingForward = !movingForward; // Yönü tersine çevir

                if (movingForward)
                {
                    targetPosition = startPosition + new Vector3(moveDistance, 0f, 0f); // İleri doğru hedef
                }
                else
                {
                    targetPosition = startPosition - new Vector3(moveDistance, 0f, 0f); // Geri doğru hedef
                }
            }

            yield return new WaitForSeconds(moveInterval); // Belirtilen aralıkta bekle
        }
    }
}