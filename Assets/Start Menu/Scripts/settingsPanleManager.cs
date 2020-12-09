using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class settingsPanleManager : MonoBehaviour
{
    private int audioBollean;
    private int musicBollean;

    public Text audioText;
    public Text musicText;

    void Start()
    {
        if (PlayerPrefs.GetInt("Sound") == 1)
        {
            audioText.text = "ON";
            audioBollean = 1;
        }
        if (PlayerPrefs.GetInt("Sound") == -1)
        {
            audioText.text = "OFF";
            audioBollean = -1;
        }

        if (PlayerPrefs.GetInt("Music") == 1)
        {
            musicText.text = "ON";
            musicBollean = 1;
        }
        if (PlayerPrefs.GetInt("Music") == -1)
        {
            musicText.text = "OFF";
            musicBollean = -1;
        }
    }

    public void ChangeAudio()
    {
        audioBollean *= -1;
        PlayerPrefs.SetInt("Sound", audioBollean);
        if (audioBollean == 1)
        {
            audioText.text = "ON";
        }
        if (audioBollean == -1)
        {
            audioText.text = "OFF";
        }
    }

    public void ChangeMusic()
    {
        musicBollean *= -1;
        PlayerPrefs.SetInt("Music", musicBollean);
        if (musicBollean == 1)
        {
            musicText.text = "ON";
        }
        if (musicBollean == -1)
        {
            musicText.text = "OFF";
        }
    }
}