using UnityEngine;

public class WallCode : MonoBehaviour
{
    [SerializeField] private GameObject gameOverPanel;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ball"))
        {
            // Show the game over panel
            gameOverPanel.SetActive(true);

            // Optionally stop the game
            // Time.timeScale = 0f;
        }
    }
}