using TMPro;
using UnityEngine;

public class Gate : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    public TextMeshProUGUI win;

    public GameObject ball;

    public int player;

    public GameObject GameOver, Main;

    private int score = 0;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject != ball) return;
        score++;
        if (score == 7)
        {
            GameOver.SetActive(true);
            Main.SetActive(false);
            Time.timeScale = 0f;
            win.text = "Player " + player + " win!";
        }
        scoreText.text = score.ToString();
        ball.GetComponent<Ball>().Reposition();
    }

    public void Restart()
    {
        score = 0;
        scoreText.text = score.ToString();
    }
}
