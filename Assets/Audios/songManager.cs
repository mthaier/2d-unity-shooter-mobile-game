using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class songManager : MonoBehaviour
{
    private AudioSource songPlayer;
    void Start()
    {
        songPlayer = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (PlayerPrefs.GetInt("Music") == -1)
        {
            songPlayer.volume = 0;
        }

        if (PlayerPrefs.GetInt("Music") == 1)
        {
            songPlayer.volume = 0.5f;
        }
    }
}
