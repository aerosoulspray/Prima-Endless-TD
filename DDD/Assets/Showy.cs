using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Showy : MonoBehaviour
{
    public GameObject panelskie;

    IEnumerator strata()
    {
        yield return new WaitForSeconds(5f);
        panelskie.SetActive(false);
    }
    public void clook()
    {
        panelskie.SetActive(true);
        StartCoroutine(strata());
    }
}
