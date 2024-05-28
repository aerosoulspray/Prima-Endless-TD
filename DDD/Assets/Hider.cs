using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hider : MonoBehaviour
{
    public GameObject quit;

    public void Quit()
    {
        quit.SetActive(true);
    }
    public void No()
    {
        quit.SetActive(false);
    }
    public void Yes()
    {
        Application.Quit();
    }
}
