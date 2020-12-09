using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unLockedGuns : MonoBehaviour
{
    public Animator shotgunAnim;
    public Animator rifleAnim;
    public Animator sniperAnim;

    public float animTimer;
    private float shotgunAnimTimer;
    private float rifleAnimTimer;
    private float sniperAnimTimer;

    private bool shotGunWork;
    private bool rifleWork;
    private bool sniperWork;


    void FixedUpdate()
    {
        if (shotGunWork)
        {
            shotgunAnimTimer -= Time.fixedDeltaTime;
            if (shotgunAnimTimer <= 0)
            {
                shotgunAnim.ResetTrigger("On");
                shotgunAnim.SetTrigger("Off");
                shotGunWork = false;
            }
        }

        if (rifleWork)
        {
            rifleAnimTimer -= Time.fixedDeltaTime;
            if (rifleAnimTimer <= 0)
            {
                rifleAnim.ResetTrigger("On");
                rifleAnim.SetTrigger("Off");
                rifleWork = false;
            }
        }

        if (sniperWork)
        {
            sniperAnimTimer -= Time.fixedDeltaTime;
            if (sniperAnimTimer <= 0)
            {
                sniperAnim.ResetTrigger("On");
                sniperAnim.SetTrigger("Off");
                sniperWork = false;
            }
        }
    }

    public void ShotgunAnimWork()
    {
        shotgunAnim.ResetTrigger("Off");
        shotgunAnim.SetTrigger("On");
        shotgunAnimTimer = animTimer;
        shotGunWork = true;
    }
    public void RifleAnimWork()
    {
        rifleAnim.ResetTrigger("Off");
        rifleAnim.SetTrigger("On");
        rifleAnimTimer = animTimer;
        rifleWork = true;
    }
    public void SniperAnimWork()
    {
        sniperAnim.ResetTrigger("Off");
        sniperAnim.SetTrigger("On");
        sniperAnimTimer = animTimer;
        sniperWork = true;
    }
}
