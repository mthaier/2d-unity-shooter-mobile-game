using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rifleBullet : MonoBehaviour
{
    public GameObject destroyMe;
    public GameObject hitPs;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Instantiate(hitPs, destroyMe.transform.position, destroyMe.transform.rotation);
        Destroy(destroyMe);
    }
}
