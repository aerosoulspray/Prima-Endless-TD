using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageCounter : MonoBehaviour
{
    public int counter = 0;
    public int health = 3;
    public string monsterTag = "Part";
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            counter++;
            if (counter >= health)
            {
                Destroy(this);
                return;
            }
        }
    }
}
