using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetGun : MonoBehaviour
{
    public GameObject[] Guns;
    void Start()
    {
        if (PlayerPrefs.GetString("Gun") == "Pistol")
        {
            Debug.Log("Im pistol");
            Instantiate(Guns[0], transform);
        }
        if (PlayerPrefs.GetString("Gun") == "Shotgun")
        {
            Instantiate(Guns[1], transform);
        }
        if (PlayerPrefs.GetString("Gun") == "Rifle")
        {
            Instantiate(Guns[2], transform);
        }
        if (PlayerPrefs.GetString("Gun") == "Sniper")
        {
            Instantiate(Guns[3], transform);
        }
    }
}
