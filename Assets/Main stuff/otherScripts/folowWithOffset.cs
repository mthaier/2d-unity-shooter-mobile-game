using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class folowWithOffset : MonoBehaviour
{
    public Transform folowMe;
    public Vector3 offset;
    void Update()
    {
        Vector3 finalPose = folowMe.transform.position + offset;
        this.transform.position = finalPose;
    }
}
