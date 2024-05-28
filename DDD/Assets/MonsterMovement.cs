using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MonsterMovement : MonoBehaviour
{
    
    public int health = 10;

    public int drop = 20;

    private float speed;

    public Transform goal;

    private GameObject imp;
    private AudioSource impa;
    // Start is called before the first frame update

    void Start()
    {
        imp = GameObject.FindGameObjectWithTag("Hit");
        impa = imp.GetComponent<AudioSource>();
        speed = this.GetComponent<NavMeshAgent>().speed;
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = goal.position;

    }
    private void Update()
    {
        //impa.Play();
        if(speed > this.GetComponent<NavMeshAgent>().speed)
        {
            StartCoroutine(waiting());
        }
    }
    public void TakeDamage(int amount)
    {
        impa.Play();
        //Debug.Log("Igo? Igo");
        health -= amount;
        if (health <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        Destroy(this.gameObject);
        PlayerStats.Money += drop;
        PlayerStats.Score += drop;
    }
    IEnumerator waiting()
    {
        yield return new WaitForSeconds(2f);
        this.GetComponent<NavMeshAgent>().speed = speed;

    }



}
