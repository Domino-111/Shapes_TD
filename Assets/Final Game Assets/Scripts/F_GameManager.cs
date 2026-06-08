using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class F_GameManager : MonoBehaviour
{
    public static F_GameManager game;

    public TMP_Text scoreText;
    public int score = 0;

    void Awake()
    {
        game = this;
    }

    // Constantly update the score once an enemy is defeated
    void Update()
    {
        UpdateScore();
    }

    // Restarts the game
    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
    }

    // Updates the score text
    public void UpdateScore()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}
