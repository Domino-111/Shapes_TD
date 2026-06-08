using UnityEngine;

public class F_Goal : MonoBehaviour
{
    public GameObject finalGame, scorePage;

    // Ensure the right pages are visible before game begins
    void Awake()
    {
        finalGame.SetActive(true);
        scorePage.SetActive(false);
    }

    // Once an enemy hits the base turn off the game page and show the score page
    private void OnTriggerEnter2D(Collider2D collision)
    {
        scorePage.SetActive(true);
        finalGame.SetActive(false);
        Debug.Log("Collision detected");
    }
}
