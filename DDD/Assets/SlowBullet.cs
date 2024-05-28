using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SlowBullet : MonoBehaviour
{
    private Transform target;
    public float speed = 100f;

    public float slowSpeed = 2f;

    //public static int counter = 0;

    public int amount = 1;

    public GameObject impactEffect;

    public void Seeker(Transform _target)
    {
        target = _target;
    }

    void Update()
    {
        if (target == null)
        {
            Destroy(this.gameObject);
            return;
        }
        Vector3 dir = target.position - transform.position;
        float distanceThisFrame = speed * Time.deltaTime;

        if (dir.magnitude <= distanceThisFrame)
        {
            HitTargeter();
            Damager(target);
            return;
        }
        transform.Translate(dir.normalized * distanceThisFrame, Space.World);
       StartCoroutine(destroyItself());
    }

    void Damager(Transform enemy)
    {
        Debug.Log("Igooo");
        MonsterMovement e = enemy.GetComponent<MonsterMovement>();
        if (e != null)
        {
            e.TakeDamage(amount);
        }

    }

    void HitTargeter()
    {
        GameObject effect = (GameObject)Instantiate(impactEffect, transform.position, transform.rotation);
        Destroy(effect, 1f);
        Destroy(gameObject);
        if (target.GetComponent<NavMeshAgent>().speed <= target.GetComponent<NavMeshAgent>().speed - slowSpeed)
        {
            return;
        }
        else
        {
            target.GetComponent<NavMeshAgent>().speed -= slowSpeed;
        }
        target.GetComponent<NavMeshAgent>().speed -= slowSpeed;
        StartCoroutine(returnSpeed());
        //Debug.Log("Naigo");
        return;
    }
    IEnumerator destroyItself()
    {
        yield return new WaitForSeconds(2f);
        Destroy(gameObject);
    }
    IEnumerator returnSpeed()
    {
        yield return new WaitForSeconds(.5f);
        target.GetComponent<NavMeshAgent>().speed += slowSpeed;
    }
}
