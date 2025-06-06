using UnityEngine;

public class MenuCloser : MonoBehaviour
{
    public GameObject closeButton;
    public TowerPlot reference;

    void Awake()
    {
        closeButton.SetActive(false);
    }

    void Update()
    {
        if (reference.towerSelection == false && reference.towerOptions == false)
        {
            closeButton.SetActive(false);
        }

        if (reference.towerSelection == true || reference.towerOptions == true)
        {
            closeButton.SetActive(true);
        }
    }

    public void Reference()
    {

    }

    public void CloseMenu()
    {
        reference.towerSelection.SetActive(false);
        reference.towerOptions.SetActive(false);
    }
}
