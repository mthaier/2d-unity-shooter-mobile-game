using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class faceEnemy1 : MonoBehaviour
{
    private Transform player;
    public float speed;
    public static bool inShootingArea;
    public Animator shootingAnimator;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void Update()
    {
        if (inShootingArea)
        {
            FaceMouse();
            this.transform.position = Vector3.Lerp(this.transform.position, player.transform.position, speed);
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
            mousePosition.x - transform.position.x,
            mousePosition.y - transform.position.y
            );
            transform.right = -direction;
        }
    }
}
