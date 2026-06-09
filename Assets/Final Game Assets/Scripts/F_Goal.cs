using UnityEngine;

public class F_Goal : MonoBehaviour
{
    public F_GameManager gm;

    // <Removed: Awake and transferred management of canvases to the game manager>

    // Once an enemy hits the base turn off the game page and show the score page
    private void OnTriggerEnter2D(Collider2D collision)
    {
        gm.scorePage.SetActive(true);
        gm.gamePage.SetActive(false);
        gm.isPlaying = false;
        gm.gameEnded = true;

        Debug.Log("Collision detected");
    }
}
