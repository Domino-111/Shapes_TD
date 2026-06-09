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
    public GameObject menuPage, gamePage, scorePage, settingsMenuPage, settingsGamePage, instructionsPage;

    public bool isPlaying = false;

    void Awake()
    {
        game = this;
        isPlaying = false;

        menuPage.SetActive(true);
        scorePage.SetActive(false);
        gamePage.SetActive(false);
        settingsMenuPage.SetActive(false);
        settingsGamePage.SetActive(false);
        instructionsPage.SetActive(false);
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

        isPlaying = true;
    }

    // <Addition: Opens the settings in the menu>
    public void OpenMenuSettings()
    {
        settingsMenuPage.SetActive(true);
    }

    // <Addition: Closes the settings in the menu>
    public void CloseMenuSettings()
    {
        settingsMenuPage.SetActive(false);
    }

    // <Addition: Opens the settings in the game>
    public void OpenGameSettings()
    {
        Time.timeScale = 0f;
        isPlaying = false;
        settingsGamePage.SetActive(true);
    }

    // <Addition: Closes the settings in the game>
    public void CloseGameSettings()
    {
        Time.timeScale = 1f;
        isPlaying = true;
        settingsGamePage.SetActive(false);
    }

    // <Addition: Opens the instructions page>
    public void OpenInstructions()
    {
        instructionsPage.SetActive(true);
    }

    // <Addition: Closes the instructions page>
    public void CloseInstructions()
    {
        instructionsPage.SetActive(false);
    }
}
