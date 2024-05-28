using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPause : MonoBehaviour
{
    public GameObject one;
    public GameObject two;
    public GameObject four;
    public GameObject pause;
    public GameObject restartPanel;
    public GameObject quitPanel;


    private void Awake()
    {
        two.SetActive(false);
        four.SetActive(false);
        pause.SetActive(false);
    }

    public void Standby()
    {
        Time.timeScale = 0f;
        pause.SetActive(true);
    }

    public void ResumeClick()
    {
        pause.SetActive(false);
        Time.timeScale = 1;
        two.SetActive(false);
        four.SetActive(false);
        one.SetActive(true);
    }
    public void RestartClick()
    {
        restartPanel.SetActive(true);
    }
    public void QuitClick()
    {
        quitPanel.SetActive(true);
    }
    public void No()
    {
        restartPanel.SetActive(false);
        quitPanel.SetActive(false);
        pause.SetActive(true);
    }
    public void One()
    {
        Time.timeScale = 2f;
        one.SetActive(false);
        two.SetActive(true);
    }
    public void Two()
    {
        Time.timeScale = 4f;
        two.SetActive(false);
        four.SetActive(true);
    }
    public void Four()
    {
        Time.timeScale = 1f;
        four.SetActive(false);
        one.SetActive(true);
    }
}
