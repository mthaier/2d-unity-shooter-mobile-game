using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthManager : MonoBehaviour
{
    public GameObject whoDie;
    public int health;
    private int enemyHealth;
    private int hitStrong;
    public Slider healthSlider;


    ///for the unreal animation
    private bool startingFrame;
    public GameObject theShapeColor;
    private Color regularColor;
    public Color hitColor;
    public float animSpeed;
    private bool startHitAnim;

    public SpriteRenderer whoColored;

    //scoreStuff
    public int scoreEachTime;

    //Audios
    private AudioSource enemiesDamageAudioPlayer;
    public AudioClip enemiesDamageAudio;

    void Start()
    {
        enemyHealth = health;
        healthSlider.maxValue = enemyHealth;
        healthSlider.value = enemyHealth;
        startingFrame = true;

        enemiesDamageAudioPlayer = GameObject.FindGameObjectWithTag("Enemies Audio Manager").GetComponent<AudioSource>();
    }

    void Update()
    {
        if (startingFrame)
        {
            regularColor = theShapeColor.GetComponent<SpriteRenderer>().color;
            startingFrame = false;
        }

        if (startHitAnim)
        {
            whoColored.color = Color.Lerp(whoColored.color, regularColor, animSpeed);
            if (whoColored.color == regularColor)
            {
                startHitAnim = false;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        #region bullet types

        if (coll.tag == "Pistol Bullet")
        {
            hitStrong = 2;
            GotHit();
        }

        if(coll.tag == "Rifle Bullet")
        {
            hitStrong = 1;
            GotHit();
        }

        if (coll.tag == "Shotgun Bullet")
        {
            hitStrong = 2;
            GotHit();
        }

        if (coll.tag == "Sniper Bullet")
        {
            hitStrong = 10;
            GotHit();
        }

        if (coll.tag == "Super Enemy Killer")
        {
            hitStrong = 100;
            GotHit();
        }

        #endregion
    }
    
    private void GotHit()
    {
        enemiesDamageAudioPlayer.PlayOneShot(enemiesDamageAudio);
        enemyHealth -= hitStrong;
        healthSlider.value = enemyHealth;
        startHitAnim = false;
        hitAnimation();
        if (enemyHealth <= 0)
        {
            inGameScoreMangaer.score += inGameScoreMangaer.scoreEachTime;
            Destroy(whoDie);
        }
    }

    private void hitAnimation()
    {
        whoColored.color = hitColor;
        startHitAnim = true;
    }


}
