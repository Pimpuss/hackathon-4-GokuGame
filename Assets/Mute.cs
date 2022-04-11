using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mute : MonoBehaviour
{
    bool Pause = true;
    AudioSource _audioSource;
    public void PauseGame()
    {
        _audioSource = GetComponent<AudioSource>();

        if(Pause) {
            Time.timeScale = 0f;
            _audioSource.Stop();
            Pause = !Pause;
        } else {
            Time.timeScale = 1;
             _audioSource.Play();
            Pause = !Pause;
        }
    }
}
