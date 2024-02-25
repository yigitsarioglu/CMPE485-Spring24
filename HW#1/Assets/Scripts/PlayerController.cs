using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    public float moveSpeed = 5f; // Speed of movement
    private Rigidbody rb; // Reference to the Rigidbody component
    // Start is called before the first frame update
    void Start()
    {

         // Get the Rigidbody component attached to the GameObject
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {

          // Get input values for horizontal and vertical axis (WASD or arrow keys)
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Calculate the movement direction based on the input values
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        // Add force to the Rigidbody component in the direction of the calculated movement
        rb.AddForce(movement * moveSpeed);
        
    }
}
