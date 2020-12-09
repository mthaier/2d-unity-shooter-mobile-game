using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunSelect : MonoBehaviour
{
    public Transform[] poses;
    public GameObject cursorObject;
    private int currentPose;

    void Update()
    {
        cursorObject.transform.position = poses[currentPose].position;
    }

    void Start()
    {
        if (PlayerPrefs.GetString("Gun") == "Pistol")
        {
            currentPose = 0;
        }
        if (PlayerPrefs.GetString("Gun") == "Shotgun")
        {
            currentPose = 1;
        }
        if (PlayerPrefs.GetString("Gun") == "Rifle")
        {
            currentPose = 2;
        }
        if (PlayerPrefs.GetString("Gun") == "Sniper")
        {
            currentPose = 3;
        }
    }

    public void posePistol()
    {
        currentPose = 0;
        PlayerPrefs.SetString("Gun", "Pistol");
    }

    public void poseShotgun()
    {
        currentPose = 1;
        PlayerPrefs.SetString("Gun", "Shotgun");
    }

    public void poseRifle()
    {
        currentPose = 2;
        PlayerPrefs.SetString("Gun", "Rifle");
    }

    public void poseSniper()
    {
        currentPose = 3;
        PlayerPrefs.SetString("Gun", "Sniper");
    }
}
