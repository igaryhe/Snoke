using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class UIManager : MonoBehaviour
{

    public static bool IsPaused;

    public GameObject pauseMenu, main, gameOver;
    

    public Gate gate1, gate2;

    public Ball ball;
    private void Start()
    {
        pauseMenu.SetActive(false);
        gameOver.SetActive(false);
    }

    // Update is called once per frame
    private void Update()
    {
        if (!Input.GetKeyDown(KeyCode.Escape) && !Input.GetKeyDown(KeyCode.Joystick1Button9)) return;
        if (IsPaused) Resume();
        else Pause();
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        main.SetActive(true);
        Time.timeScale = 1f;
        IsPaused = false;
    }

    private void Pause()
    {
        pauseMenu.SetActive(true);
        main.SetActive(false);
        Time.timeScale = 0f;
        IsPaused = true;
    }

    public void Restart()
    {
        gate1.Restart();
        gate2.Restart();
        ball.Reposition();
        gameOver.SetActive(false);
        Resume();
        
    }

    public void Exit()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1f;
        IsPaused = false;
    }

    public void GameOver()
    {
        gameOver.SetActive(true);
        main.SetActive(false);
        Time.timeScale = 0f;
    }
}
