using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoad : MonoBehaviour
{
    public GameObject outside;
    public int setter = 0;
    IEnumerator click()
    {
        Time.timeScale = 1;
        yield return new WaitForSeconds(0.01f);
        SceneManager.LoadScene(setter);
    }
    public void clook()
    {
        outside.SetActive(true);
        StartCoroutine(click());
    }
}
