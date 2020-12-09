using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioManager : MonoBehaviour
{
    #region audios
    public AudioSource clickButtonAudioSource;
    public AudioClip clickOnButtonAudio;

    public AudioSource errorAudioSource;
    public AudioClip errorAudio;

    public AudioSource selectAudioSource;
    public AudioClip selectAudio;
    #endregion

    #region events
    public void AudioClickButton()
    {
        if (PlayerPrefs.GetInt("Sound") == 1)
        {
            clickButtonAudioSource.PlayOneShot(clickOnButtonAudio);
        }
    }

    public void AudioErrorSound()
    {
        if (PlayerPrefs.GetInt("Sound") == 1)
        {
            errorAudioSource.PlayOneShot(errorAudio);
        }
    }

    public void AudioSelectSound()
    {
        if (PlayerPrefs.GetInt("Sound") == 1)
        {
            selectAudioSource.PlayOneShot(selectAudio);
        }
    }
    #endregion
}
