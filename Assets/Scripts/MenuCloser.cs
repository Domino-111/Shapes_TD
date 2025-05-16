using UnityEngine;

public class MenuCloser : TowerPlot
{
    public GameObject closeButton;

    void Awake()
    {
        closeButton.SetActive(false);
    }

    void Update()
    {
        if (towerSelection == false && towerOptions == false)
        {
            closeButton.SetActive(false);
        }

        if (towerSelection == true || towerOptions == true)
        {
            closeButton.SetActive(true);
            CloseMenu();
        }
    }

    public void CloseMenu()
    {
        towerSelection.SetActive(false);
        towerOptions.SetActive(false);
    }
}
