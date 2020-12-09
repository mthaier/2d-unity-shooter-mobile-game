using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpingLavaMove : MonoBehaviour
{
    private Rigidbody2D rb;
    public float highestJumpSpeed;
    public float lowestJumpSpeed;

    public float highestToRight;
    public float highestToLeft;

    private float dieTimer;
    public GameObject father;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        rb.AddForce(new Vector2(0f, Random.Range(lowestJumpSpeed, highestJumpSpeed)), ForceMode2D.Impulse);
        rb.AddForce(new Vector2(Random.Range(highestToLeft, highestToRight), 0f), ForceMode2D.Impulse);
        dieTimer = 3f;
    }

    void Update()
    {
        dieTimer -= Time.deltaTime;
        if (dieTimer <= 0)
        {
            Destroy(father);
        }
    }
}
