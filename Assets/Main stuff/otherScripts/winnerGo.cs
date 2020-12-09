using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winnerGo : MonoBehaviour
{
    public GameObject[] thingsToTurnOff;
    public GameObject winPanel;
    public int theScoreGoal;
    private bool end;

    public bool forShotgun;
    public bool forRifle;
    public bool forSniper;

    public string lvlValue;
    void LateUpdate()
    {
        if (inGameScoreMangaer.score >= theScoreGoal && !end)
        {
            Win();
        }
    }

    private void Win()
    {
        winPanel.active = true;
        PlayerPrefs.SetInt(lvlValue, 1);
        foreach (GameObject i in thingsToTurnOff)
        {
            i.active = false;
        }
        if (forShotgun)
        {
            PlayerPrefs.SetInt("Shotgun", 1);
        }
        if (forRifle)
        {
            PlayerPrefs.SetInt("Rifle", 1);
        }
        if (forSniper)
        {
            PlayerPrefs.SetInt("Sniper", 1);
        }
    }
}
