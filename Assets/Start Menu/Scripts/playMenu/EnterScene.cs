using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterScene : MonoBehaviour
{
    public string sceneName;
    public void EnterTheXScene()
    {
        Debug.Log("Im working to go to scene this is stupid");
        SceneManager.LoadScene(sceneName);
    }
}
