using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitButton : MonoBehaviour
{
    public void ExitTheGame()
    {
        Debug.Log("I Exit");
        Application.Quit();
    }
}