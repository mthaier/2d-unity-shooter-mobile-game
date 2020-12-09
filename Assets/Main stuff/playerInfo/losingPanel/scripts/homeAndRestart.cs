using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class homeAndRestart : MonoBehaviour
{
    private string homeSceneName = "Start Menu";
    public void Restart()
    {
        string sceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(sceneName);
    }

    public void Home()
    {
        SceneManager.LoadScene(homeSceneName);
    }
}
