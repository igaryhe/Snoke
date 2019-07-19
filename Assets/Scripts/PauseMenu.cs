using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class PauseMenu : MonoBehaviour
{

    public static bool IsPaused = false;

    public GameObject pauseMenu, Main, GameOver;

    // public TextMeshProUGUI score1, score2;

    public GameObject gate1, gate2;

    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Joystick1Button9))
        {
            if (IsPaused) Resume();
            else Pause();
        }
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        Main.SetActive(true);
        Time.timeScale = 1f;
        IsPaused = false;
    }

    public void Pause()
    {
        pauseMenu.SetActive(true);
        Main.SetActive(false);
        Time.timeScale = 0f;
        IsPaused = true;
    }

    public void Restart()
    {
        // score1.text = "0";
        // score2.text = "0";
        gate1.GetComponent<Gate>().Restart();
        gate2.GetComponent<Gate>().Restart();
        ball.GetComponent<Ball>().Reposition();
        GameOver.SetActive(false);
        Resume();
        
    }

    public void Exit()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1f;
        IsPaused = false;
    }
}
