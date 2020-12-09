using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stagesShowingManager : MonoBehaviour
{
    public GameObject[] unLockedStages;
    public GameObject[] lockedStages;

    void Start()
    {
        if (PlayerPrefs.GetInt("2") == 1)
        {
            unLockedStages[1].active = true;
            lockedStages[1].active = false;
        }
        if (PlayerPrefs.GetInt("3") == 1)
        {
            unLockedStages[2].active = true;
            lockedStages[2].active = false;
        
        }
        if (PlayerPrefs.GetInt("4") == 1)
        {
            unLockedStages[3].active = true;
            lockedStages[3].active = false;
        }
        if (PlayerPrefs.GetInt("5") == 1)
        {
            unLockedStages[4].active = true;
            lockedStages[4].active = false;
        }
    }
}
