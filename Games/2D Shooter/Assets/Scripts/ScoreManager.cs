using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    private int score = 0;

    void Start()
    {
        if (scoreText == null)
        {
            Debug.LogError("Score text not assigned in the Inspector!");
            return;
        }

        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        if (scoreText == null)
        {
            Debug.LogError("Score text not assigned in the Inspector!");
            return;
        }

        scoreText.text = "Score: " + score.ToString();

         // Check if score reaches 100
        if (score >= 100)
        {
            // Load the end scene
            SceneManager.LoadScene("EndScene");
        }
    }

    public void AddScore(int value)
    {
        score += value;
        UpdateScoreText();
    }
}
