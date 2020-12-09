using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class throwingParticles : MonoBehaviour
{
    public GameObject throwenParticle;
    public float ShowenParticleTimer;
    private float PrivateShowenParticleTimer;


    void Start()
    {
        PrivateShowenParticleTimer = ShowenParticleTimer;
    }

    void Update()
    {
        PrivateShowenParticleTimer -= Time.fixedDeltaTime;

        if (PrivateShowenParticleTimer <= 0)
        {
            ThrowParticle();
            PrivateShowenParticleTimer = ShowenParticleTimer;
        }
    }


    private void ThrowParticle()
    {
        Vector3 thorwenPose = new Vector3(this.transform.position.x + Random.Range(-34, 34), -23.5f, 0f);
        Instantiate(throwenParticle, thorwenPose, Quaternion.Euler(new Vector3(0, 0, 0)));
    }
}
