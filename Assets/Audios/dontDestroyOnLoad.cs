using UnityEngine;
using System.Collections;

public class dontDestroyOnLoad : MonoBehaviour
{

    private static dontDestroyOnLoad instance = null;
    public static dontDestroyOnLoad Instance
    {
        get { return instance; }
    }
    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }
}