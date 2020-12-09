using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hideOneShowOne : MonoBehaviour
{
    public GameObject one;
    public GameObject two;
    public void hideOneShowTwo()
    {
        one.active = false;
        two.active = true;
    }
    public void hideTwoShowOne()
    {
        two.active = false;
        one.active = true;
    }
}
