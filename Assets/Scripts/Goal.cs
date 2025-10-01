using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameObject prototype, scorePage;

    void Awake()
    {
        prototype.SetActive(true);
        scorePage.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        scorePage.SetActive(true);
        prototype.SetActive(false);
        Debug.Log("Collision detected");
    }
}
