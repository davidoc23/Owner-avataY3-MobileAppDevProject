using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerLives : MonoBehaviour
{
    public int startingLives = 3;
    private int lives;
    public Text livesText; // Reference to the UI Text element for displaying lives count

    void Start()
    {
        lives = startingLives;
        UpdateLivesText(); // Update UI Text element when the game starts
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            // Reduce player's lives
            lives--;

            // Update UI Text element
            UpdateLivesText();

            // Check if player has no lives left
            if (lives <= 0)
            {
                // End the game
                EndGame();
            }
        }
    }

    void UpdateLivesText()
    {
        // Update UI Text element with the current lives count
        livesText.text = "Lives: " + lives.ToString();
    }

    void EndGame()
    {
        // You can implement your game over logic here
        Debug.Log("Game Over");
        // For example, reload the current scene
        SceneManager.LoadScene("EndScene");
    }
}
