using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class faceEnemy : MonoBehaviour
{
    private bool canFight;

    #region old script
    //for facing
    private Transform player;
    public Transform theEnemy;

    //for shooting
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float bulletForce;

    public float shootingTimer;
    private float fireTimer;


    public float speed;

    //if in the shooting area
    public static bool inShootingArea;

    //FOR ALL THE FACES
    public bool rightFacing;


    //the StartingColor
    public Color[] colors;

    public SpriteRenderer myColor;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        fireTimer = shootingTimer;

        int colorPossible = Random.Range(0, colors.Length);
        myColor.color = colors[colorPossible];
    }

    void Update()
    {
        if (canFight)
        {
            FaceMouse();
            fireTimer -= Time.deltaTime;
            if (fireTimer <= 0)
            {
                Shoot();
                fireTimer = shootingTimer;
            }
            theEnemy.transform.position = Vector3.Lerp(this.transform.position, player.transform.position, speed);
        }

        if (!canFight)
        {
            Debug.Log("The scripted varaible works!");
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

            if (rightFacing)
            {
                theEnemy.transform.right = direction;
            }
            if (!rightFacing)
            {
                theEnemy.transform.right = -direction;
            }
        }
    }

    private void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.right * bulletForce, ForceMode2D.Impulse);
    }
    #endregion

    #region shootingArea
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == "Player")
        {
            canFight = true;
        }
    }

    private void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.tag == "Player")
        {
            canFight = false;
        }
    }
    #endregion shootingArea
}