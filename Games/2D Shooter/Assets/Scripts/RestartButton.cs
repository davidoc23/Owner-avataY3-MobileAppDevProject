using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    public AudioClip buttonClickSound; // Reference to the button click sound
    private AudioSource audioSource; // Reference to the AudioSource component

    void Start()
    {
        // Get the AudioSource component attached to the GameObject
        audioSource = GetComponent<AudioSource>();
    }

    public void StartGame()
    {
        // Play the button click sound
        if (buttonClickSound != null && audioSource != null)
        {
            audioSource.PlayOneShot(buttonClickSound);
        }

        // Start a coroutine to delay loading the scene
        StartCoroutine(LoadSceneAfterDelay("Scene1", 1.5f));
    }

    IEnumerator LoadSceneAfterDelay(string sceneName, float delay)
    {
        // Wait for the specified delay
        yield return new WaitForSeconds(delay);

        // Load the scene after the delay
        SceneManager.LoadScene(sceneName);
    }
}
