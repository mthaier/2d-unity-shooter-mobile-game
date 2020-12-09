using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenGuns : MonoBehaviour
{
    public GameObject shotgun;
    public GameObject lockedShotgun;

    public GameObject rifle;
    public GameObject lockedRifle;

    public GameObject sniper;
    public GameObject lockedSniper;
    void Start()
    {
        if (PlayerPrefs.GetInt("First oppen") != 1)
        {
            PlayerPrefs.SetInt("Sound", 1);
            PlayerPrefs.SetInt("Music", 1);
            PlayerPrefs.SetInt("Pistol", 1);
            PlayerPrefs.SetString("Gun", "Pistol");
            PlayerPrefs.SetInt("First oppen", 1);
        }

        else
        {
            if (PlayerPrefs.GetInt("Shotgun") == 1)
            {
                shotgun.active = true;
                lockedShotgun.active = false;
            }

            if (PlayerPrefs.GetInt("Rifle") == 1)
            {
                rifle.active = true;
                lockedRifle.active = false;
            }

            if (PlayerPrefs.GetInt("Sniper") == 1)
            {
                sniper.active = true;
                lockedSniper.active = false;
            }
        }
        
    }
}
