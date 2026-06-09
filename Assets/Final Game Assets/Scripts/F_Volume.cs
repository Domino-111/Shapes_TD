using UnityEngine;
using UnityEngine.UI;

public class F_Volume : MonoBehaviour
{
    public F_AudioManager am;

    public string channelName;

    private Slider slider;

    private float volumeActual;

    void Awake()
    {
        slider = GetComponent<Slider>();
    }

    public void SetVolume(float volume)
    {
        // Translates -80 & 10 to 0 & 1 on the slider
        volumeActual = Mathf.Lerp(-60f, 0f, volume);

        am.SetVolume(channelName, volumeActual);
    }
}
