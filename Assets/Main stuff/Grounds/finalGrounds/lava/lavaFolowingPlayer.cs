using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lavaFolowingPlayer : MonoBehaviour
{
    GameObject player;
    private Vector3 finalPose;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        finalPose = new Vector3(player.transform.position.x, this.transform.position.y);
        this.transform.position = finalPose;
    }
}
//to now poses
//x =34
//x = -34
//y = -23.5f