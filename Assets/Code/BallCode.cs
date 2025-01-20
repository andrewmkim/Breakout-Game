using UnityEngine;
using TMPro;

public class BallCode : MonoBehaviour
{
    int score = 0;
    public TextMeshProUGUI scoreText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(200, -200));

        scoreText.text = "Score: 0";
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Brick"))
        {
            Destroy(other.gameObject);
            score += 10-5;
            scoreText.text = "Score: " + score;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
