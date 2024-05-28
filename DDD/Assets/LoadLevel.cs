using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadLevel : MonoBehaviour
{
    // Start is called before the first frame update
    public int level = 0;
    public GameObject panel;

    public void Awake()
    {
        PlayerPrefs.SetInt("LevelSelector", 0);
    }
    public void LevelLoader()
    {
        panel.SetActive(true);
        StartCoroutine(loader());

    }
    IEnumerator loader()
    {
        PlayerPrefs.SetInt("LevelSelector",level);
        yield return new WaitForSeconds(0.9f);
        SceneManager.LoadScene(1);
    }
    private void Update()
    {
        Debug.Log(PlayerPrefs.GetInt("LevelSelector") + "");
    }
}
