using UnityEngine;

public class TowerPlot : MonoBehaviour
{
    public bool towerPlaced = false;

    public GameObject towerSelection, towerOptions, tower1, tower2, tower3;

    void Awake()
    {
        towerSelection.SetActive(false);
        towerOptions.SetActive(false);
    }

    void Update()
    {

    }

    public void Selection()
    {
        if (towerPlaced == false)
        {
            towerSelection.SetActive(true);
        }

        if (towerPlaced == true)
        {
            towerSelection.SetActive(false);
        }
    }

    public void Options()
    {
        if (towerPlaced == true)
        {
            towerOptions.SetActive(true);
        }

        if (towerPlaced == false)
        {
            towerOptions.SetActive(false);
        }
    }

    public void Circle()
    {
        Instantiate(tower1);
        towerPlaced = true;
    }

    public void Triangle()
    {
        Instantiate(tower2);
        towerPlaced = true;
    }

    public void Hexagon()
    {
        Instantiate(tower3);
        towerPlaced = true;
    }
}
