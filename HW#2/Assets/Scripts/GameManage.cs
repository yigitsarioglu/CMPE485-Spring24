using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManage : MonoBehaviour
{
    // Reference to the key and door objects
    public GameObject key;
    public GameObject door;

    void OnCollisionEnter(Collision collision)
    {
        // Check if the collision involves the key and the door
        if (collision.gameObject == key && collision.gameObject == door)
        {
            // End the game (You can add your game over logic here)
            Debug.Log("Game Over! Key and door collided.");
            // For example, you can use Unity's built-in functionality to end the game
            SceneManager.LoadScene("gameWin");
            
        }
    }
}