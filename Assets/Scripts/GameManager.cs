using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject prototype, scorePage;

    void Awake()
    {
        prototype.SetActive(true);
        scorePage.SetActive(false);
    }

    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        scorePage.SetActive(true);
        prototype.SetActive(false);
        Debug.Log("Collision detected");
    }

    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
