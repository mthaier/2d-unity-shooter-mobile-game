using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotGunFire : MonoBehaviour
{
    public float bulletForce;
    public GameObject bulletPrefab;
    private Transform bulletParent;
    public Transform[] firePoints;
    public ParticleSystem firePs;


    public float bulletsTimer;
    private float bewteenEachBullet;

    //Audios
    private AudioSource fireAudioSource;
    public AudioClip fireAudio;
    
    //pc controler
    public bool pcControler;

    void Start()
    {
        fireAudioSource = GameObject.FindGameObjectWithTag("Fire Audio Manager").GetComponent<AudioSource>();

        bulletParent = GameObject.FindGameObjectWithTag("Bullet Parent").GetComponent<Transform>();
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
        fireAudioSource.PlayOneShot(fireAudio);
        firePs.Play(true);
        GameObject bullet = Instantiate(bulletPrefab, firePoints[0].transform.position, firePoints[0].transform.rotation, bulletParent);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoints[0].right * bulletForce, ForceMode2D.Impulse);

        GameObject bullet1 = Instantiate(bulletPrefab, firePoints[1].transform.position, firePoints[1].transform.rotation, bulletParent);
        Rigidbody2D rb1 = bullet1.GetComponent<Rigidbody2D>();
        rb1.AddForce(firePoints[1].right * bulletForce, ForceMode2D.Impulse);

        GameObject bullet2 = Instantiate(bulletPrefab, firePoints[2].transform.position, firePoints[2].transform.rotation, bulletParent);
        Rigidbody2D rb2 = bullet2.GetComponent<Rigidbody2D>();
        rb2.AddForce(firePoints[2].right * bulletForce, ForceMode2D.Impulse);
    }
}