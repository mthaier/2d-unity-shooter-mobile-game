using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secEnemyShooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    
    void Fire()
    {
        secEnemyShootingArea.areaIsWorking = false;
        Instantiate(bulletPrefab, firePoint.transform.position, firePoint.transform.rotation);
    }
}
