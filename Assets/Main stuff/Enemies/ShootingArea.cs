using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ShootingArea : MonoBehaviour
{
    #region shootingArea
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == "Player")
        {
            faceEnemy.inShootingArea = true;
        }
    }

    private void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.tag == "Player")
        {
            faceEnemy.inShootingArea = false;
        }
    }
    #endregion shootingArea
}