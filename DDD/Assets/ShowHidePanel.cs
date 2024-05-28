using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHidePanel : MonoBehaviour
{
    public GameObject buttonsPanel;

    public void Show()
    {
        buttonsPanel.SetActive(true);
    }
    public void Hide()
    {
        buttonsPanel.SetActive(false);
    }

}
