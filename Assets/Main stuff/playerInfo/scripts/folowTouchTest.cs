using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class folowTouchTest : MonoBehaviour
{
    //pc controler
    public bool pcControler;

    //phone controler
    private bool stopGetMe;
    private Touch scoopingTouch;
    int touchIntiger;
    public static bool fire;

    private bool scoopWork;
    void FixedUpdate()
    {
        if (scoopWork)
        {
            fire = true;
            scoopDown();
        }

        if (!scoopWork)
        {
            fire = false;
            scoopUp();
        }
    }

    void FaceMouse()
    {
        #region pc controler

        if (pcControler)
        {
            Vector3 mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            Vector2 direction = new Vector2(
            mousePosition.x - transform.position.x,
            mousePosition.y - transform.position.y
            );

            transform.right = direction;
        }
        #endregion

        #region phone controler



        #endregion
    }

    #region scooping events

    //events for buttons
    public void goScoopTrue()
    {
        scoopWork = true;
    }
    public void goScoopFalse()
    {
        scoopWork = false;
    }

    //events for work
    private void scoopDown()
    {
        if (!stopGetMe)
        {
            touchIntiger = Input.touches.Length - 1;
            stopGetMe = true;
        }

        scoopingTouch = Input.GetTouch(touchIntiger);
        //the real working
        Vector3 mousePosition = scoopingTouch.position;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        Vector2 direction = new Vector2(
        mousePosition.x - transform.position.x,
        mousePosition.y - transform.position.y
        );

        transform.right = direction;

    }
    private void scoopUp()
    {
        stopGetMe = false;
    }

    #endregion

}
