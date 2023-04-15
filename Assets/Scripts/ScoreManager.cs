using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    public GameObject winPannel;
    public int Score = 0;
    public TextMeshProUGUI ScoreText;
   

    private void Start()
    {
        Instance= this;
        winPannel.SetActive(false);
        
    }
    private void Update()
    {
        if (Score >= 1000)
        {
            YouWin();
        }
    }

    void YouWin()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        CountDownTimer.Instance.gameOverPanel.SetActive(false);
        CountDownTimer.Instance.pausePanel.SetActive(false);
        CountDownTimer.Instance.inGamePanel.SetActive(false);
        winPannel.SetActive(true);
        Time.timeScale = 0;
    }
    //private void OnTriggerEnter(Collider other)
    //{
    //    Destroy(other.gameObject);
    //    AddScore();
    //}
    public void AddScore()
    {
        //Score++;
        ScoreText.text = "Points :" + Score.ToString();
    }
}
