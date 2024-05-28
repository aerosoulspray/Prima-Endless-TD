using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIElement : MonoBehaviour
{
    public GameObject unHovered;
    public GameObject hovered;

    private void Awake()
    {
        unHovered.SetActive(true);
        hovered.SetActive(false);
    }
    public void Click()
    {
        unHovered.SetActive(false);
        hovered.SetActive(true);
    }
    public void CLick2()
    {
        unHovered.SetActive(true);
        hovered.SetActive(false);
    }
}
