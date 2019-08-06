using TMPro;
using UnityEngine;

public class Gate : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    public TextMeshProUGUI win;

    public Ball ball;

    public int player;

    public UIManager uim;
    private int score;

    private int winScore = 7;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject != ball.gameObject) return;
        score++;
        if (score == winScore)
        {
            uim.GameOver();
            win.text = "Player " + player + " win!";
        }
        scoreText.text = score.ToString();
        ball.Reposition();
    }

    public void Restart()
    {
        score = 0;
        scoreText.text = score.ToString();
    }
}
