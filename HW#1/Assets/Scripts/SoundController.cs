using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    private AudioSource audioSource;
    private bool isSoundPlaying = false;


    // Start is called before the first frame update
    void Start()
    {

        // Get the AudioSource component attached to the GameObject
        audioSource = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {

           // Check for input to toggle sound playback, if unput is M, stops the sound
        if (Input.GetKeyDown(KeyCode.M))
        {
            if (isSoundPlaying)
            {
                // If sound is currently playing, pause it
                audioSource.Pause();
            }
            else
            {
                // If sound is currently paused, resume playing
                audioSource.UnPause();
            }

            // Toggle the isSoundPlaying flag
            isSoundPlaying = !isSoundPlaying;
        }
    
        
    }
}
