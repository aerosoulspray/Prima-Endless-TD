using System.Collections;
using System.Collections.Specialized;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Node : MonoBehaviour
{

    public Color hoverColor;
    public Vector3 positionOffset;


    [HideInInspector]
    public GameObject tower;

    public GameObject destroyeffect;

    [HideInInspector]
    public TowerBlueprint towerBlueprint;

    [HideInInspector]
    public bool isUpgraded = false;

    private Color startColor;
    private Renderer rend;

    BuildManager buildManager;


  
    public Vector3 GetBuildPosition()
    {
        return transform.position + positionOffset;
    }

    private void Update()
    {
        GameObject poof = GameObject.FindGameObjectWithTag("Whoosh");
        AudioSource whoosh = poof.GetComponent<AudioSource>();
        if (tower != null)
        {
            int tree = Random.Range(1, 25000);
            //Debug.Log(tree);
            if (tree == 999)
            {
                whoosh.Play();
                PlayerStats.Money += towerBlueprint.cost;
                GameObject _destroyEffect = (GameObject)Instantiate(destroyeffect, GetBuildPosition(), Quaternion.identity);
                Destroy(_destroyEffect, 1f);
                isUpgraded = false;
                Destroy(tower);
                towerBlueprint = null;
            }
        }
        if (PlayerStats.Lives <= 0)
        {
            Destroy(tower);
        }
        
    }

    private void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
        buildManager = BuildManager.instance;
        
    }

    private void OnMouseDown()
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }
        

        if (tower != null)
        {
            buildManager.SelectNode(this);
            return;
        }

        if (!buildManager.CanBuild)
        {
            return;
        }

        BuildTower(buildManager.GetTowerToBuild());

    }

    void BuildTower(TowerBlueprint blueprint)
    {
        if (PlayerStats.Money < blueprint.cost)
        {
            return;
        }
        PlayerStats.Money -= blueprint.cost;
        towerBlueprint = blueprint;
        GameObject poof = GameObject.FindGameObjectWithTag("Whoosh");
        AudioSource whoosh = poof.GetComponent<AudioSource>();
        whoosh.Play();
        GameObject _tower = (GameObject)Instantiate(blueprint.prefab, GetBuildPosition(), Quaternion.identity);
        tower = _tower;

       // Debug.Log("Money Left: " + PlayerStats.Money);
    }

    public void TowerUpgrade()
    {
        if (PlayerStats.Money < towerBlueprint.upgrade)
        {
            return;
        }
        PlayerStats.Money -= towerBlueprint.upgrade;

        Destroy(tower);
        GameObject poof = GameObject.FindGameObjectWithTag("Whoosh");
        AudioSource whoosh = poof.GetComponent<AudioSource>();
        whoosh.Play();
        GameObject _tower = (GameObject)Instantiate(towerBlueprint.prefabUpgrade, GetBuildPosition(), Quaternion.identity);
        tower = _tower;

        isUpgraded = true;

        //Debug.Log("Money Left: " + PlayerStats.Money);
    }

    private void OnMouseEnter()
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }

        if (!buildManager.CanBuild)
        {
            return;
        }
        rend.material.color = hoverColor;
    }

    private void OnMouseExit()
    {
        
        rend.material.color = startColor;
    }

    public void SellTower()
    {
        PlayerStats.Money += SellAmount();
        GameObject poof = GameObject.FindGameObjectWithTag("Whoosh");
        AudioSource whoosh = poof.GetComponent<AudioSource>();
        whoosh.Play();
        GameObject _destroyEffect = (GameObject)Instantiate(destroyeffect, GetBuildPosition(), Quaternion.identity);
        Destroy(_destroyEffect, 1f);
        isUpgraded = false;
        Destroy(tower);
        towerBlueprint = null;
    }

    public int SellAmount ()
    {
        if(isUpgraded == true)
        {
            return towerBlueprint.sellUpgrade;
        }
        else
        {
            return towerBlueprint.sellBasic;
        }
    }

}
