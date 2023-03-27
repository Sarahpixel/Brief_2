using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    private void Awake()
    {
        Time.timeScale = 1f;
    }
    public void LoadTitle()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Title");
    }
    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Game");
    }
    public void QuitGame()
    {
        Debug.Log("Quiting Game.....");
        Application.Quit();
    }
}
