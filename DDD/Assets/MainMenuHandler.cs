using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuHandler : MonoBehaviour
{
    public Text serpent;
    public Text trident;
    public Text line;

    public AudioSource click;

    private void Awake()
    {
        serpent.text = PlayerPrefs.GetInt("Serpent") + "";
        trident.text = PlayerPrefs.GetInt("Trident") + "";
        line.text = PlayerPrefs.GetInt("Line") + "";
    }

    public void Clear()
    {
        PlayerPrefs.DeleteAll();
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0) == true)
        {
            click.Play();
        }
    }
}
