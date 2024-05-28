using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;

    private TowerBlueprint towerToBuild;
    private Node selectedNode;

    public NodeUI nodeUI;

    public GameObject StandardTowerPrefab;
    public GameObject SpearThrower;

    public bool CanBuild { get { return towerToBuild != null; } }

    private void Awake()
    {
        if(instance != null)
        {
            //Debug.LogError("Yawa Mali");
            return;
        }
        instance = this;
    }


    public void SelectNode(Node node)
    {
       if (selectedNode == node)
        {
            DeselectNode();
            return;
        }
        selectedNode = node;
        towerToBuild = null;

        nodeUI.SetTarget(node);

        
    }

    public void DeselectNode()
    {
        selectedNode = null;
        nodeUI.Hide();
    }

    public void SelectTowerToBuild(TowerBlueprint tower)
    {
        towerToBuild = tower;
        DeselectNode();
    }

    public TowerBlueprint GetTowerToBuild()
    {
        return towerToBuild;
	//Try kung naay update
    }
}
