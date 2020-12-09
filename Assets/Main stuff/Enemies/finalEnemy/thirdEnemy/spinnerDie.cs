using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinnerDie : MonoBehaviour
{
    public GameObject diePs;

    private AudioSource enemiesDamageAudioPlayer;
    public AudioClip enemiesDamageAudio;

    void Start()
    {
        enemiesDamageAudioPlayer = GameObject.FindGameObjectWithTag("Enemies Audio Manager").GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        #region cases
        if (coll.tag == "Player")
        {
            enemiesDamageAudioPlayer.PlayOneShot(enemiesDamageAudio);

            inGameScoreMangaer.score += inGameScoreMangaer.scoreEachTime;

            Instantiate(diePs, coll.transform.position, coll.transform.rotation);
            Destroy(this.gameObject);
        }

        if (coll.tag == "Pistol Bullet")
        {
            enemiesDamageAudioPlayer.PlayOneShot(enemiesDamageAudio);

            inGameScoreMangaer.score += inGameScoreMangaer.scoreEachTime;

            Instantiate(diePs, coll.transform.position, coll.transform.rotation);
            Destroy(this.gameObject);
        }

        if (coll.tag == "Rifle Bullet")
        {
            enemiesDamageAudioPlayer.PlayOneShot(enemiesDamageAudio);

            inGameScoreMangaer.score += inGameScoreMangaer.scoreEachTime;

            Instantiate(diePs, coll.transform.position, coll.transform.rotation);
            Destroy(this.gameObject);
        }

        if (coll.tag == "Sniper Bullet")
        {
            enemiesDamageAudioPlayer.PlayOneShot(enemiesDamageAudio);

            inGameScoreMangaer.score += inGameScoreMangaer.scoreEachTime;

            Instantiate(diePs, coll.transform.position, coll.transform.rotation);
            Destroy(this.gameObject);
        }

        if (coll.tag == "Shotgun Bullet")
        {
            enemiesDamageAudioPlayer.PlayOneShot(enemiesDamageAudio);

            inGameScoreMangaer.score += inGameScoreMangaer.scoreEachTime;
            Instantiate(diePs, coll.transform.position, coll.transform.rotation);
            Destroy(this.gameObject);
        }

        if (coll.tag == "Super Enemy Killer")
        {
            enemiesDamageAudioPlayer.PlayOneShot(enemiesDamageAudio);

            inGameScoreMangaer.score += inGameScoreMangaer.scoreEachTime;
            Instantiate(diePs, coll.transform.position, coll.transform.rotation);
            Destroy(this.gameObject);
        }
        #endregion
    }
}
