using UnityEngine;

public class Shop : MonoBehaviour
{
    BuildManager buildManager;

    public TowerBlueprint Stone;
    public TowerBlueprint Spear;
    public TowerBlueprint Mud;
    private void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void SelectTower1()
    {
        
        buildManager.SelectTowerToBuild(Stone);
    }
    public void SelectTower2()
    {
       
        buildManager.SelectTowerToBuild(Spear);
    }

    public void SelectTower3()
    {

        buildManager.SelectTowerToBuild(Mud);
    }

    public void TowerReset()
    {
        buildManager.SelectTowerToBuild(null);
    }
}
