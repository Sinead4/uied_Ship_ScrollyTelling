using UnityEngine;

public class AudioHandler : MonoBehaviour
{
    public AudioSource WaveAudio;

    public void handleWaves(float distance)
    {
        if (distance > 830)
        {
            WaveAudio.volume = 0.891f;
            WaveAudio.pitch = 2.0f;
        }
    }
}
