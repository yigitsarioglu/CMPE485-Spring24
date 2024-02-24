using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript2 : MonoBehaviour
{
  public GameObject prefabToSpawn; // Reference to the prefab to spawn


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         // Check if the specified key is pressed
        if (Input.GetKeyDown(KeyCode.X))
        {
            // Spawn a new object based on the prefab at the current position
            Instantiate(prefabToSpawn, transform.position, Quaternion.identity);
        }
    }
}
