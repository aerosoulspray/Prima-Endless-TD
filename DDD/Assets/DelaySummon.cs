using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelaySummon : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject summoner1;
    public GameObject summoner2;
    public GameObject summoner3;
    public GameObject summoner4;
    public GameObject summoner5;
    void Start()
    {
        StartCoroutine(summon());
    }
    IEnumerator summon()
    {
        summoner1.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        summoner2.SetActive(true);
        yield return new WaitForSeconds(0.2f);
        summoner3.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        summoner4.SetActive(true);
        yield return new WaitForSeconds(0.4f);
        summoner5.SetActive(true);
    }
}
