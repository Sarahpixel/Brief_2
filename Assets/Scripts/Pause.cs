using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public GameObject pausePanel;
    public GameObject inGamePanel;
    public static bool GameIsPaused = false;
    private void Start()
    {
        pausePanel.SetActive(false);
        inGamePanel.SetActive(true);
    }
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Paused();
            }
        }

    }
    public void Resume()
    {
        pausePanel.SetActive(false);
        inGamePanel.SetActive(true);

        Time.timeScale = 1f;
        GameIsPaused = false;
        Cursor.lockState = CursorLockMode.Locked;

    }

    void Paused()
    {
        pausePanel.SetActive(true);
        inGamePanel.SetActive(false);

        Time.timeScale = 0f;
        GameIsPaused = true;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    public void LoadTitle()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Title");
    }
    public void QuitGame()
    {
        Debug.Log("Quitting Game");
        Application.Quit();
    }
}
