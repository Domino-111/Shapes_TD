using UnityEngine;

public class F_TowerPlot : MonoBehaviour
{
    public bool towerPlaced = false;

    public GameObject towerSelection, tower1, tower2, tower3;

    // <Removed: towerOptions object and Options method as the demolish feature will be added into the tower selection>

    // Ensure the tower selection menu is not visible once the game starts 
    void Awake()
    {
        towerSelection.SetActive(false);
    }

    // When the tower plot is pressed the tower selection menu will appear
    public void Selection()
    {
        towerSelection.SetActive(true);
        Invoke("MenuTimer", 3f);
    }

    // Spawns the Circle tower
    public void Circle()
    {
        if (towerPlaced == true) // <Addition: Demolishing previous tower into the tower selection for faster gameplay>
        {
            Destroy(transform.GetChild(2).gameObject);
            towerPlaced = false;
        }

        Instantiate(tower1, gameObject.transform.position, Quaternion.identity, gameObject.transform);
        towerPlaced = true;
        towerSelection.SetActive(false);
    }

    // Spawns the Triangle tower
    public void Triangle()
    {
        if (towerPlaced == true) // <Addition: Demolishing previous tower into the tower selection for faster gameplay>
        {
            Destroy(transform.GetChild(2).gameObject);
            towerPlaced = false;
        }

        Instantiate(tower2, gameObject.transform.position, Quaternion.identity, gameObject.transform);
        towerPlaced = true;
        towerSelection.SetActive(false);
    }

    // Spawns the Hexagon tower
    public void Hexagon()
    {
        if (towerPlaced == true) // <Addition: Demolishing previous tower into the tower selection for faster gameplay>
        {
            Destroy(transform.GetChild(2).gameObject);
            towerPlaced= false;
        }

        Instantiate(tower3, gameObject.transform.position, Quaternion.identity, gameObject.transform);
        towerPlaced = true;
        towerSelection.SetActive(false);
    }

    // Closes the menu if nothing is pressed in a few seconds
    public void MenuTimer()
    {
        towerSelection.SetActive(false);
    }
}
