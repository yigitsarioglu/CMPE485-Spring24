using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class KeyCollison : MonoBehaviour
{
 

    void OnCollisionEnter(Collision col)
    {
        // Check if the collision involves the key and the door
        if (col.gameObject.name == "Door" )
        {
            // End the game (You can add your game over logic here)
            Debug.Log("You win the game.. Key and door collided.");
            Destroy(col.gameObject);
            

            StartCoroutine( Test() );
            // Shows the GameWin Scene
            // SceneManager.LoadSceneAsync(3);
            
        }
    }

    IEnumerator Test()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("GameWin");
    }
}
