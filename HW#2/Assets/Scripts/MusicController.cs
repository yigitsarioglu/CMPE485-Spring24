using UnityEngine;
using UnityEngine.UI;

public class MusicController : MonoBehaviour
{
    public AudioSource musicSource;
    public Button musicButton;
    private bool isMusicPlaying = true;

    private static MusicController instance;

    void Awake()
    {
        // Singleton pattern uygulayarak yalnızca bir tane MusicController olmasını sağlıyoruz
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // GameObject'in yok olmasını engelliyoruz
        }
        else
        {
            Destroy(gameObject); // Eğer başka bir MusicController zaten varsa, bu GameObject'i yok ediyoruz
        }
    }
        

    void Start()
    {
        musicButton.onClick.AddListener(ToggleMusic);
    }

    void ToggleMusic()
    {
        if (isMusicPlaying)
        {
            musicSource.Pause();
        }
        else
        {
            musicSource.Play();
        }
        isMusicPlaying = !isMusicPlaying;
    }



    
    void Update()
    {
        // Check for input to toggle sound playback
        if (Input.GetKeyDown(KeyCode.M))
        {
            if (isMusicPlaying)
            {
                // If sound is currently playing, pause it
                musicSource.Pause();
            }
            else
            {
                // If sound is currently paused, resume playing
                musicSource.Play();
            }

            // Toggle the isSoundPlaying flag
            isMusicPlaying = !isMusicPlaying;
        }
    }
}