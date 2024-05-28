using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyThis : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(stat());
    }
    IEnumerator stat()
    {
        yield return new WaitForSeconds(0.9f);
        this.gameObject.SetActive(false);
    }
}
