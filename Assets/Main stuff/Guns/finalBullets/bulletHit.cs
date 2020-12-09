using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletHit : MonoBehaviour
{
    public GameObject destroyMe;
    public GameObject hitPs;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ground")
        {
            hit();
        }

        if (other.tag == "SuperKiller")
        {
            hit();
        }

        if (other.tag == "Enemy")
        {
            hit();
        }

        if (other.tag == "Spinner Killer")
        {
            hit();
        }
    }

    private void hit()
    {
        Instantiate(hitPs, destroyMe.transform.position, destroyMe.transform.rotation);
        Destroy(destroyMe);
    }
}