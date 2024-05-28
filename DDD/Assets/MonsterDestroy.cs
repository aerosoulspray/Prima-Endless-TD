using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonsterDestroy : MonoBehaviour
{
    public GameObject monster;
    public int endLife = 10;
    public Text scoreText;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "End")
        {
            GameObject.Destroy(monster);
            PlayerStats.Lives--;
            Debug.Log("collison detected");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "End")
        {
            GameObject.Destroy(monster);
            PlayerStats.Lives--;
            Debug.Log("collison detected");
            
            
        }
    }
    private void Update()
    {
        
    }
}
