using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCamMove : MonoBehaviour
{
    public Animator cams;
    public GameObject secondMenu;

    private void Awake()
    {
        secondMenu.SetActive(false);
    }

    public void MainClick()
    {
        cams.SetTrigger("move");
        StartCoroutine(showMenu());
    }
    IEnumerator showMenu()
    {
        yield return new WaitForSeconds(2f);
        secondMenu.SetActive(true);
    }
   
}
