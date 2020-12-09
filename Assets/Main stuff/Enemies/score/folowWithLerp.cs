using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class folowWithLerp : MonoBehaviour
{
    public Transform postToFollow;
    public float lerpSpeed;
    private Vector3 finalPose;
    
    void Start()
    {
        //player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void FixedUpdate()
    {
        finalPose = Vector3.Lerp(transform.position, postToFollow.transform.position, lerpSpeed);
        this.transform.position = finalPose;
    }
}
