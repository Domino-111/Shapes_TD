using UnityEngine;
using UnityEngine.Audio;

public class F_AudioManager : MonoBehaviour
{
    public AudioMixer mixer;

    public AudioSource menuSong, gameSong;

    public F_GameManager gm;

    // Changes the volume
    public void SetVolume(string channel, float volume)
    {
        mixer.SetFloat(channel, volume);
    }

    void Update()
    {
        // Checks if the game is playing and the song hasn't already started
        if (gm.isPlaying == false && menuSong.isPlaying == false)
        {
            gameSong.Stop();
            menuSong.Play();
        }

        if (gm.isPlaying == true && gameSong.isPlaying == false)
        {
            menuSong.Stop();
            gameSong.Play();
        }
    }
}
