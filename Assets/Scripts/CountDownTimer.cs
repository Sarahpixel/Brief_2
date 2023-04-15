using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CountDownTimer : MonoBehaviour
{

    public static CountDownTimer Instance;
    float currentTime = 0f;
    float startingTime = 35f;
    public TextMeshProUGUI timerText;
    public GameObject inGamePanel;
    public GameObject pausePanel;
    bool timerStarted = false;
    public GameObject gameOverPanel;



    void Start()
    {
        Instance= this;
        gameOverPanel.SetActive(false);
        currentTime = startingTime;
    }


    void countdownfunction()
    {
        currentTime -= 1 * Time.deltaTime;
        timerText.text = currentTime.ToString("0");
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            timerStarted = true;
        if (timerStarted)
            countdownfunction();

        if (currentTime <= 0)
        {
            currentTime = 0;

        }
        if (currentTime == 0)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            pausePanel.SetActive(false);
            gameOverPanel.SetActive(true);
            Time.timeScale = 0f;
            inGamePanel.SetActive(false);
        }
        if (currentTime < 5.5f)
        {
            timerText.color = Color.red;
        }
        if (currentTime >= 5.5f)
        {
            timerText.color = Color.white;
        }
    }
}
   

