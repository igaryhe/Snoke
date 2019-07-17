using TMPro;
using UnityEngine;

public class Gate : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    public GameObject ball;

    private int score = 0;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject != ball) return;
        score++;
        scoreText.text = score.ToString();
        ball.GetComponent<Ball>().Reposition();
    }
}
