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
        if (collision.TryGetComponent<Enemy>(out Enemy combatant))
        {
            scorePage.SetActive(true);
            prototype.SetActive(false);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
