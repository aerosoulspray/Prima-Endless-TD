using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    public Transform walkerPrefab;
    public Transform runnerPrefab;
    public Transform chargerPrefab;
    public Transform inquisitorPrefab;
    public Transform fortressPrefab;

    public Transform startPoint;
    public Transform start2;

    public float timeBetweenWaves = 20f;
    private float countDown = 2f;

    private int waveNumber = 1;
    private int waveSecond = 1;

    private int counter = 0;

    private void Update()
    {
        if (countDown <= 0f)
        {
            StartCoroutine(SpawnWave());
            
            countDown = timeBetweenWaves;
        }

        countDown -= Time.deltaTime;


        //Time.timeScale = 2f;
 
    }
    IEnumerator SpawnWave()
    {
        for (int i = 0; i < waveNumber; i++)
        {
            SpawnWalker();
            yield return new WaitForSeconds(1f);

        }
        if(waveNumber % 3 == 0)
        {
            for(int i = 0; i < waveNumber/3; i++)
            {
                SpawnRunner();
            }
            yield return new WaitForSeconds(1f);
        }
        if (waveNumber % 5 == 0)
        {
            for (int i = 0; i < waveNumber / 5; i++)
            {
                SpawnCharger();
            }
            yield return new WaitForSeconds(1f);
        }
        if (waveNumber % 10 == 0)
        {
            for (int i = 0; i < waveNumber / 10; i++)
            {
                SpawnInquisitor();
            }
            yield return new WaitForSeconds(2f);
        }
        if (waveNumber % 20 == 0)
        {
            for (int i = 0; i < waveNumber / 20; i++)
            {
                SpawnWFortress();
            }
            yield return new WaitForSeconds(2f);
        }
        if(waveSecond >= 30 && waveSecond%10 == 0)
        {
            for (int i = 0; i < waveSecond / 10; i++)
            {
                SpawnInquisitor2();
                SpawnWFortress2();
            }
            yield return new WaitForSeconds(2f);

        }
        
        

        if(waveNumber!= 1)
        {
            PlayerStats.Money += 50;
        }
        if (waveNumber > 20)
        {
            waveNumber = 9;
            counter++;
        }
        waveNumber++;
        waveSecond++;
        
    }

    public void SpawnWalker()
    {
        Instantiate(walkerPrefab,startPoint.position,startPoint.rotation);
    }
    public void SpawnRunner()
    {
        Instantiate(runnerPrefab, startPoint.position, startPoint.rotation);
    }
    public void SpawnCharger()
    {
        Instantiate(chargerPrefab, startPoint.position, startPoint.rotation);
    }
    public void SpawnWFortress()
    {
        GameObject horn = GameObject.FindGameObjectWithTag("Horn");
        AudioSource hornsound = horn.GetComponent<AudioSource>();
        hornsound.Play();
        Instantiate(fortressPrefab, startPoint.position, startPoint.rotation);
    }
    public void SpawnWFortress2()
    {
        GameObject horn = GameObject.FindGameObjectWithTag("Horn");
        AudioSource hornsound = horn.GetComponent<AudioSource>();
        hornsound.Play();
        Instantiate(fortressPrefab, start2.position, startPoint.rotation);
    }
    public void SpawnInquisitor()
    {
        Instantiate(inquisitorPrefab, startPoint.position, startPoint.rotation);
    }
    public void SpawnInquisitor2()
    {
        Instantiate(inquisitorPrefab, start2.position, startPoint.rotation);
    }
    IEnumerator spawnA()
    {
        yield return new WaitForSeconds(5f);
        SpawnWalker();
    }
}

