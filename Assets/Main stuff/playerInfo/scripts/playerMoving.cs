using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMoving : MonoBehaviour
{
    //for the moving 
    private Rigidbody2D rb;
    public float speed;
    public float backToNormalSpeed;

    //for the jumping
    public ParticleSystem jumpingPs;
    private float jumpCount;
    public float jumpForce;

    //for pc controler
    public bool pcControler;

    //some events managamanet;
    private bool goRight;
    private bool goLeft;
    private bool goJump;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        #region pc controler

        if (pcControler)
        {
            Debug.Log(jumpCount);
            #region moving right and left
            if (Input.GetKey(KeyCode.A))
            {
                Debug.Log("A is pressed");
                rb.AddForce(new Vector2(-speed, 0f), ForceMode2D.Impulse);
            }
            if (Input.GetKey(KeyCode.D))
            {
                Debug.Log("D is pressed");
                rb.AddForce(new Vector2(speed, 0f), ForceMode2D.Impulse);
            }
            #endregion moving right and left

            if (Input.GetKey(KeyCode.Space) && jumpCount > 0)
            {
                Jump();
            }
        }


        #endregion

        #region phone controler

        if (goLeft)
        {
            Left();
        }
        if (!goLeft)
        {
            if (rb.velocity.x < 0.1)
            {
                Debug.Log("I Should go back");
                rb.AddForce(new Vector2(speed, 0f), ForceMode2D.Impulse);
            }
        }

        if (goRight)
        {
            Right();
        }
        if(!goRight)
        {
            if (rb.velocity.x > 0.1)
            {
                Debug.Log("I Should go back");
                rb.AddForce(new Vector2(-speed, 0f), ForceMode2D.Impulse);
            }
        }

        if (goJump)
        {
            Jump();
        }

        #endregion
    }


    #region collisions

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.collider.tag == "Ground")
        {
            jumpCount = 1;
        }
    }

    private void OnCollisionExit2D(Collision2D coll)
    {
        if (coll.collider.tag == "Ground")
        {
            jumpCount = 1;
        }
    }

    #endregion collisions

    //all the voids you could use

    #region move events
    //booleans
    public void rightTrue()
    {
        goRight = true;
    }
    public void rightFalse()
    {
        goRight = false;
    }


    public void leftTrue()
    {
        goLeft = true;
    }
    public void leftFalse()
    {
        goLeft = false;
    }


    public void jumpTrue()
    {
        goJump = true;
    }
    public void jumpFalse()
    {
        goJump = false;
    }


    //whats happen
    private void Left()
    {
        Debug.Log("Moving right");
        rb.AddForce(new Vector2(-speed, 0f), ForceMode2D.Impulse);
    }

    private void Right()
    {
        Debug.Log("Moving left");
        rb.AddForce(new Vector2(speed, 0f), ForceMode2D.Impulse);
    }

    private void Jump() 
    {
        Debug.Log("Jump start");
        rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        jumpingPs.Play(true);
        jumpCount--;
    }

    #endregion
}