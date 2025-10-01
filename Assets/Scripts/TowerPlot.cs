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

    public void Selection()
    {
        if (towerPlaced == false)
        {
            towerSelection.SetActive(true);
            Invoke("MenuTimer", 4f);
        }
    }

    public void Options()
    {
        if (towerPlaced == true)
        {
            towerOptions.SetActive(true);
            Invoke("MenuTimer", 4f);
        }
    }

    public void Circle()
    {
        Instantiate(tower1, gameObject.transform.position, Quaternion.identity, gameObject.transform);
        towerPlaced = true;
        towerSelection.SetActive(false);
    }

    public void Triangle()
    {
        Instantiate(tower2, gameObject.transform.position, Quaternion.identity, gameObject.transform);
        towerPlaced = true;
        towerSelection.SetActive(false);
    }

    public void Hexagon()
    {
        Instantiate(tower3, gameObject.transform.position, Quaternion.identity, gameObject.transform);
        towerPlaced = true;
        towerSelection.SetActive(false);
    }

    public void Demolish()
    {
        Destroy(transform.GetChild(2).gameObject);
        towerPlaced = false;
        towerOptions.SetActive(false);
    }

    public void MenuTimer()
    {
        towerSelection.SetActive(false);
        towerOptions.SetActive(false);
    }
}
