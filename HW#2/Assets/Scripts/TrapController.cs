using UnityEngine;
using System.Collections;

public class TrapController : MonoBehaviour
{
    public GameObject firePrefab; // Ateş engeli prefab
    public int maxTraps = 6; // Maksimum tuzak sayısı
    public float trapInterval = 5f; // Tuzak aralığı

    private int currentTrapsCount = 0; // Mevcut tuzak sayısı

    public float minX = -10f; // Tuzakların en küçük x koordinatı
    public float maxX = 10f; // Tuzakların en büyük x koordinatı

    void Start()
    {
        // Coroutine'i başlat
        StartCoroutine(TrapRoutine());
    }

    IEnumerator TrapRoutine()
    {
        while(true)
        {
            currentTrapsCount = GameObject.FindGameObjectsWithTag("Trap").Length;
            
            Debug.Log("Current Traps Count: " + currentTrapsCount);
            
            // Eğer mevcut tuzak sayısı maksimum tuzak sayısına ulaşmadıysa yeni bir tuzak oluştur
            if (currentTrapsCount < maxTraps)
            {
                CreateTrap();
                currentTrapsCount = GameObject.FindGameObjectsWithTag("Trap").Length;
            }
            
            yield return new WaitForSeconds(trapInterval);
            
            // Tuzakları temizle
            ClearTraps();
            yield return new WaitForSeconds(1);
            Debug.Log("After clear Current Traps Count: " + currentTrapsCount);

        }
        
    }

    void CreateTrap()
    {
        // Rastgele x koordinatı seç
        float randomX = Random.Range(minX, maxX);
        // Tuzak objesini oluştur
        Vector3 trapPosition = new Vector3(randomX, transform.position.y, transform.position.z);
        Instantiate(firePrefab, trapPosition, Quaternion.identity);
    }

    void ClearTraps()
    {
        // Tuzakları temizle
        GameObject[] traps = GameObject.FindGameObjectsWithTag("Trap");
        foreach (GameObject trap in traps)
        {
            Destroy(trap);
        }
       
    }
}