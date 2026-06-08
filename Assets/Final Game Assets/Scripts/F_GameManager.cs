using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class F_GameManager : MonoBehaviour
{
    public static F_GameManager game;

    public TMP_Text scoreText;
    public int score = 0;
    public int highScore;

    // <Addition: Keep track of canvases involved with the game>
    public GameObject menuPage, gamePage, scorePage, settingsPage;

    void Awake()
    {
        game = this;

        menuPage.SetActive(true);
        scorePage.SetActive(false);
        gamePage.SetActive(false);
        settingsPage.SetActive(false);
    }

    // Constantly update the score once an enemy is defeated
    void Update()
    {
        UpdateScore();
    }

    // Restarts the game
    public void Restart()
    {
        SceneManager.LoadScene("Final Game");
    }

    // Updates the score text
    public void UpdateScore()
    {
        scoreText.text = "Score:\n" + score.ToString();
    }

    // <Addition: Begins the game>
    public void StartGame()
    {
        menuPage.SetActive(false);
        gamePage.SetActive(true);
    }

    // <Addition: Opens the settings menu>
    public void OpenSettings()
    {
        settingsPage.SetActive(true);
    }

    // <Addition: Closes the settings menu>
    public void CloseSettings()
    {
        settingsPage.SetActive(false);
    }
}
