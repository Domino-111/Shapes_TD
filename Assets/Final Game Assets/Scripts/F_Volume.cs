using UnityEngine;
using UnityEngine.UI;

public class F_Volume : MonoBehaviour
{
    public F_AudioManager am;

    public string channelName;

    private Slider slider;

    void Awake()
    {
        slider = GetComponent<Slider>();
    }

    public void SetVolume(float volume)
    {
        // Translates -80 & 10 to 0 & 1 on the slider
        float volumeActual = Mathf.Lerp(-80f, 10f, volume);

        am.SetVolume(channelName, volumeActual);
    }
}
