using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideHider : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag != "Enemy")
        {
            collision.gameObject.SetActive(false);
        }   
    }
}
