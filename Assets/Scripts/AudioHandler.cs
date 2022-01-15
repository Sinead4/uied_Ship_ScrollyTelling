using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioHandler : MonoBehaviour
{
    public AudioSource WaveAudio;
    // Start is called before the first frame update

    public void handleWaves(float distance)
    {
        if (distance > 830)
        {
            WaveAudio.volume = 0.891f;
            WaveAudio.pitch = 2.0f;
        }
    }
}
