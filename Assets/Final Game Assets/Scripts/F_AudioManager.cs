using UnityEngine;
using UnityEngine.Audio;

public class F_AudioManager : MonoBehaviour
{
    public AudioMixer mixer;

    void Start()
    {
        mixer.SetFloat("EffectsVolume", 0f);
    }

    // Adjusts the volume for everything in the game with a slider
    public void MasterVolume()
    {

    }

    // Adjusts the volume for the music in the game with a slider
    public void MusicVolume()
    {

    }

    // Adjusts the volume for the effects in the game with a slider
    public void EffectsVolume()
    {

    }
}
