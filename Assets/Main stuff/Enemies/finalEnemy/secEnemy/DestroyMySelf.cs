using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMySelf : MonoBehaviour
{
    public float dieTimer;
    public GameObject destroyMe;
    public bool selfDestroying;

    void Update()
    {
        dieTimer -= Time.deltaTime;
        if (dieTimer <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
