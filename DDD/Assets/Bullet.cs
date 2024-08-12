using System;
using System.Collections;

using UnityEngine;
using UnityEngine.AI;

public class Bullet : MonoBehaviour
{
//Cooment
    private Transform target;
    public float speed = 100f;
    public float slowSpeed = 1f;
    public int counter = 0;

    public int amount = 1;

    

    public GameObject impactEffect;

    public void Seek(Transform _target)
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
            HitTarget();
            Damage(target);
            return;
        }
        transform.Translate(dir.normalized * distanceThisFrame, Space.World);
        StartCoroutine(destroyItself());
    }

    void Damage(Transform enemy)
    {
        MonsterMovement e = enemy.GetComponent<MonsterMovement>();
        if (e != null)
        {
            e.TakeDamage(amount);
        }
             
    }

    void HitTarget()
    {
        
        GameObject effect =  (GameObject)Instantiate(impactEffect, transform.position, transform.rotation);
        Destroy(effect, 0.5f);
        //Debug.Log("Naigo");
        float originalSpeed = target.GetComponent<NavMeshAgent>().speed;
        float targetSpeed = originalSpeed;
        if (this.gameObject.tag == "Slow")
        {
            if (originalSpeed > targetSpeed - slowSpeed)
            {
                originalSpeed -= slowSpeed;
                target.GetComponent<NavMeshAgent>().speed = 1;

            }
            originalSpeed += slowSpeed;

        }
        Destroy(this.gameObject);
        return;
    }
    IEnumerator destroyItself()
    {
      
        yield return new WaitForSeconds(2f);
        Destroy(gameObject);
    }



}

