using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DefeatCounter : MonoBehaviour
{
    public GameObject gameOver;
    public Text score;
    public string Level = "";
    public GameObject nodes;
    private void Update()
    {
        if (PlayerStats.Lives <= 0)
        {
            //nodes.SetActive(false);
            GameObject theme = GameObject.FindGameObjectWithTag("MainTheme");
            AudioSource tema = theme.GetComponent<AudioSource>();
            tema.Stop();
            gameOver.SetActive(true);
            score.text = PlayerStats.Score + "";
            int scorebasic = PlayerStats.Score;
            int highScore = PlayerPrefs.GetInt(Level);
            if (scorebasic > highScore)
            {
                PlayerPrefs.SetInt(Level, scorebasic);
            }
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Boss")
        {
            PlayerStats.Lives -= 4;
            if(PlayerStats.Lives <= 0)
            {
                Time.timeScale = 0;
            }
            return;
            
        }
        else if (other.gameObject.tag == "Enemy")
        {
            PlayerStats.Lives--;
            if (PlayerStats.Lives <= 0)
            {
                Time.timeScale = 0;
            }
            return;
        }
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            if (PlayerStats.Lives <= 0)
            {
                Time.timeScale = 0;
            }
            PlayerStats.Lives--;
        }
        else if (collision.gameObject.tag == "Boss")
        {
            if (PlayerStats.Lives <= 0)
            {
                Time.timeScale = 0;
            }
            PlayerStats.Lives -= 4;
        }
    }
    

}
