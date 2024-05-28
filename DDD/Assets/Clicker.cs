using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clicker : MonoBehaviour
{
    public AudioSource clicker;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) == true)
        {
            clicker.Play();
        }
    }
}
