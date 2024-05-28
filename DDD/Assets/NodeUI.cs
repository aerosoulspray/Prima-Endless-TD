using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NodeUI : MonoBehaviour
{
    public GameObject ui;


    public Text upgradeText;
    public Text sellText;
    public Button upgradeButton;

    private Node target;
    public Vector3 offset;
    public void SetTarget(Node node)
    {
        this.target = node;
        offset = new Vector3(0, 5, 5);
        transform.position = target.GetBuildPosition() + offset;

        if (!target.isUpgraded)
        {
            upgradeText.text = target.towerBlueprint.upgrade + "";
            sellText.text = target.towerBlueprint.sellBasic + "";
            upgradeButton.interactable = true;

        }
        else
        {
            upgradeText.text = "done";
            sellText.text = target.towerBlueprint.sellUpgrade + "";
            upgradeButton.interactable = false;
        }
        

        ui.SetActive(true);
    }

    public void Hide()
    {
            ui.SetActive(false);
    }

    public void Upgrade()
    {
        target.TowerUpgrade();
        BuildManager.instance.DeselectNode();
    }
    public void Sell()
    {
        target.SellTower();
        ui.SetActive(false);
    }

}
