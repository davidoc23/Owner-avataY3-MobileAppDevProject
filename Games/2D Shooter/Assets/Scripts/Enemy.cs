using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int scoreValue = 10;
    public ScoreManager scoreManager; // Reference to ScoreManager

    void Start()
    {
        // Find the ScoreManager in the scene
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bullet"))
        {
            // Increase score and update score display
            scoreManager.AddScore(scoreValue);
            
            // Destroy the enemy
            Destroy(gameObject);
        }
    }
}
