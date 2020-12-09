using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour
{
    public float bulletForce;
    public GameObject bulletPrefab;
    private Transform bulletParent;
    public Transform firePoint;
    public ParticleSystem firePs;


    public float bulletsTimer;
    private float bewteenEachBullet;

    //audios
    private AudioSource fireAudioSource;
    public AudioClip fireAudio;

    //pc controler
    public bool pcControler;

    void Start()
    {
        bulletParent = GameObject.FindGameObjectWithTag("Bullet Parent").GetComponent<Transform>();
        fireAudioSource = GameObject.FindGameObjectWithTag("Fire Audio Manager").GetComponent<AudioSource>();
    }

    void LateUpdate()
    {
        bewteenEachBullet -= Time.deltaTime;

        #region fire manager

        if (bewteenEachBullet <= 0)
        {
            #region pc controler
            if (pcControler)
            {
                if (Input.GetKey(KeyCode.S))
                {
                    Fire();
                    bewteenEachBullet = bulletsTimer;
                }
            }
            #endregion

            #region phone controler
            else
            {
                if (folowTouchTest.fire == true)
                {
                    Fire();
                    bewteenEachBullet = bulletsTimer;
                }
            }
            #endregion

        }

        #endregion shootingBulletManager

    }

    void Fire()
    {
        firePs.Play(true);
        GameObject bullet = Instantiate(bulletPrefab, firePoint.transform.position, firePoint.transform.rotation, bulletParent);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.right * bulletForce, ForceMode2D.Impulse);
        fireAudioSource.PlayOneShot(fireAudio);
    }
}
