using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loaderskie : MonoBehaviour
{
    public GameObject panel;
   IEnumerator Clicked()
    {
        yield return new WaitForSeconds(0.9f);
        if(PlayerPrefs.GetInt("LevelSelector") == 1)
        {
            SceneManager.LoadScene(2);
        }
        else if (PlayerPrefs.GetInt("LevelSelector") == 2)
        {
            SceneManager.LoadScene(3);
        }
        else if (PlayerPrefs.GetInt("LevelSelector") == 3)
        {
            SceneManager.LoadScene(4);
        }
        else
        {
            SceneManager.LoadScene(0);
        }
    }
    public void ClickMotion()
    {
        panel.SetActive(true);
        StartCoroutine(Clicked());
    }
}
