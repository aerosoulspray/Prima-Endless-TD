using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Loadidng : MonoBehaviour
{
    public GameObject button;
    private void Update()
    {
        float randomizer = Random.Range(0.0000001f,0.0000005f);
        this.gameObject.GetComponent<Image>().fillAmount += 0.001f;
    if(this.gameObject.GetComponent<Image>().fillAmount >= 1f)
        {
            button.SetActive(true);
        }

    }
}
