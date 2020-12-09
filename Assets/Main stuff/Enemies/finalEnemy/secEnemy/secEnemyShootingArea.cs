using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class secEnemyShootingArea : MonoBehaviour
{
    //in shooting area script stuff
    public static bool areaIsWorking;

    #region old script

    private Transform player;
    public Transform theEenemy;
    public float speed;
    private bool canFight;
    public Animator shootingAnimator;

    void Start()
    {
        areaIsWorking = true;
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void Update()
    {
        if (canFight)
        {
            FaceMouse();
            theEenemy.position = Vector3.Lerp(theEenemy.transform.position, player.transform.position, speed);
            shootingAnimator.SetBool("Shoot", true);
        }
        else
        {
            shootingAnimator.SetBool("Shoot", false);
        }
    }

    private void FaceMouse()
    {
        if (player != null)
        {
            Vector3 mousePosition = player.position;
            Vector2 direction = new Vector2(
            mousePosition.x - theEenemy.position.x,
            mousePosition.y - theEenemy.position.y
            );
            theEenemy.right = -direction;
        }
    }

    #endregion

    #region in shooting area
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == "Player")
        {
            areaIsWorking = true;
            canFight = true;
        }
    }

    private void OnTriggerExit2D(Collider2D coll)
    {
        if (areaIsWorking)
        {
            if (coll.tag == "Player")
            {
                canFight = false;
            }
        }
    }
    #endregion
}
