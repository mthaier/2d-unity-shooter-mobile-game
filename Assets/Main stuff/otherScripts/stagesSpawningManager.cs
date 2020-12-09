using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stagesSpawningManager : MonoBehaviour
{
    public float highestX;
    public float lowestX;
    public float highestY;
    public float lowestY;

    public float timerToSpawn;
    private float timerToSpawnButPrivate;

    public int maxmizeMonster;
    private int currentMonsters;

    private GameObject[] existMonsters;

    public GameObject firstBossPrefab;
    public GameObject secBossPrefab;
    public GameObject thirdBossPrefab;
    public bool theirIsThird;
    
    void Start()
    {
        timerToSpawnButPrivate = timerToSpawn;
    }


    void Update()
    {
        existMonsters = GameObject.FindGameObjectsWithTag("Monster");
        currentMonsters = existMonsters.Length + 1;

        if (currentMonsters < maxmizeMonster)
        {
            timerToSpawnButPrivate -= Time.deltaTime;
            if (timerToSpawnButPrivate <= 0)
            {
                Instantiate(firstBossPrefab, new Vector3(
                    Random.Range(lowestX, highestX),
                    Random.Range(lowestY, highestY),
                    0),
                    Quaternion.Euler(0, 0, 0)
                    );

                int possibleToSetSec = Random.Range(0, 3);
                if (possibleToSetSec == 1)
                {
                    Instantiate(secBossPrefab, new Vector3(
                    Random.Range(lowestX, highestX),
                    Random.Range(lowestY, highestY),
                    0),
                    Quaternion.Euler(0, 0, 0)
                    );
                }

                if (theirIsThird)
                {
                    int possibleToSetThird = Random.Range(0, 3);
                    if (possibleToSetThird == 1)
                    {
                        Instantiate(thirdBossPrefab, new Vector3(
                        Random.Range(lowestX, highestX),
                        Random.Range(lowestY, highestY),
                        0),
                        Quaternion.Euler(0, 0, 0)
                        );
                    }
                }

                timerToSpawnButPrivate = timerToSpawn;
            }
        }
    }
}
