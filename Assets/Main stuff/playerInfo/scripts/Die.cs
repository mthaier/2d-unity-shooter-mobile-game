using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Die : MonoBehaviour
{

    #region health stuff
    public int health;
    private int mineHealth;
    private int maxHealth;

    ///who die
    public GameObject ps;
    public GameObject playerShape;
    public GameObject gunParent;
    public GameObject healthBar;
    public GameObject ScorePanel;
    public GameObject guiPanel;

    //who showen
    public GameObject losingPanel;

    ///for the health bar
    public Slider healthBarSlider;
    #endregion


    #region items stuff

    public static int inGamePlayStaticCoins;
    public int coinEachGet;
    public GameObject coinGetPs;

    public int heartToGet;
    public GameObject heartGetPs;

    #endregion

    #region audio stuff
    private AudioSource collisionAudioSource;
    public AudioClip damageAudio;
    public AudioClip itemGetAudio;
    #endregion
    void Start()
    {
        inGamePlayStaticCoins = 0;
        mineHealth = health;
        maxHealth = mineHealth;
        healthBarSlider.maxValue = health;

        collisionAudioSource = this.GetComponent<AudioSource>();
    }

    void Update()
    {
        healthBarSlider.value = mineHealth;

        if (mineHealth > maxHealth)
        {
            mineHealth = maxHealth;
        }
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        Debug.Log(coll.tag);

        #region health collision
        if (coll.tag == "Killer")
        {
            mineHealth--;
            collisionAudioSource.PlayOneShot(damageAudio);
        }

        if (coll.tag == "Spinner Killer")
        {
            mineHealth = 0;
            collisionAudioSource.PlayOneShot(damageAudio);
        }

        if (coll.tag == "SuperKiller")
        {
            HeDie();
            collisionAudioSource.PlayOneShot(damageAudio);
        }

        if (mineHealth <= 0)
        {
            HeDie();
            collisionAudioSource.PlayOneShot(damageAudio);
        }

        #endregion

        #region items collision

        if (coll.tag == "Coin")
        {
            Instantiate(coinGetPs, coll.transform.position, coll.transform.rotation);
            Debug.Log("Here we go"); 
            GetCoin();
            Destroy(coll.gameObject);
            collisionAudioSource.PlayOneShot(itemGetAudio);
        }

        if (coll.tag == "health")
        {
            Instantiate(heartGetPs, coll.transform.position, coll.transform.rotation);
            Debug.Log("Here we go");
            GetHeart();
            Destroy(coll.gameObject);
            collisionAudioSource.PlayOneShot(itemGetAudio);
        }

        #endregion
    }

    private void HeDie()
    {
        ps.active = true;
        ps.gameObject.transform.position = playerShape.transform.position;
        playerShape.active = false;
        gunParent.active = false;
        healthBar.active = false;
        ScorePanel.active = false;
        guiPanel.active = false;
        losingPanel.active = true;
    }

    #region items events

    private void GetCoin()
    {
        inGamePlayStaticCoins += coinEachGet;
    }

    private void GetHeart()
    {
        mineHealth += heartToGet;
    }

    #endregion
}
