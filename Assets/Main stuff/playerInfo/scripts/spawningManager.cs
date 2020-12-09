
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawningManager : MonoBehaviour
{
    //firstType
    public GameObject setMoreThingObject;
    public GameObject[] thingsToSet;
    public Transform startingPoint;
    public float nextPointRange;
    private float currentPoint;
    private Vector3 settingPose;
    public float highestY;
    public float lowestY;
    
    //secType
    public GameObject[] thingsToSetTypeTwo;
    public float highestSecTypeY;
    public float lowestSecTypeY;

    //enemies
    public GameObject firstEnemy;
    private int firstEnemyShowenPossible;

    public GameObject secEenemy;
    private int secEnemyShowenPossible;

    public GameObject thirdEnemey;
    private int thirdEnemyShowenPossible;


    #region items

    public GameObject coinPrefab;
    public int[] howMuchInstaint;

    public GameObject heartPrefab;
    public int maxPossibleToSetHeart;
    #endregion
    void Start()
    {
        currentPoint = 0;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "SpawningTrigger")
        {
            int wichOne = Random.Range(0, 2);

            if (wichOne == 0)
            {
                SpawningTypeOne();
            }

            if (wichOne == 1)
            {
                SpawningTypeTwo();
            }

            Destroy(col.gameObject);
        }
    }

    private void SpawningTypeOne()
    {
        Debug.Log("Spawning Start");
        currentPoint += nextPointRange;
        settingPose = new Vector3(startingPoint.position.x + currentPoint, Random.Range(lowestY, highestY));

        int objectToInstaint = Random.Range(0, thingsToSet.Length);
        Instantiate(thingsToSet[objectToInstaint], settingPose, Quaternion.Euler(new Vector3(0, 0, 0)));
        Instantiate(setMoreThingObject, settingPose, Quaternion.Euler(new Vector3(0, 0, 0)));


        #region enime

        firstEnemyShowenPossible = Random.Range(1, 4);
        if (firstEnemyShowenPossible == 3)
        {
            Instantiate(firstEnemy, settingPose, Quaternion.Euler(new Vector3(0, 0, 0)));

            secEnemyShowenPossible = Random.Range(0, 2);
            if (secEnemyShowenPossible == 1)
            {
                Instantiate(secEenemy, new Vector3(settingPose.x, settingPose.y - 3, settingPose.z), Quaternion.Euler(new Vector3(0, 0, 0)));
            }

            thirdEnemyShowenPossible = Random.Range(0, 2);
            if (thirdEnemyShowenPossible == 1)
            {
                Instantiate(thirdEnemey, new Vector3(settingPose.x, settingPose.y + 3, settingPose.z), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
        }

        #endregion



        #region items

        //money
        foreach (int i in howMuchInstaint)
        {
            Instantiate(coinPrefab, new Vector3(settingPose.x + Random.Range(20, -20), Random.Range(-20, -7), 3.3f), Quaternion.Euler(new Vector3(0, 0, 0)));
        }

        //heart
        int possibleToSetHeart = Random.Range(0, maxPossibleToSetHeart);
        if (possibleToSetHeart == 1)
        {
            Instantiate(heartPrefab, new Vector3(settingPose.x + Random.Range(20, -20), Random.Range(-20, -7), 3.3f), Quaternion.Euler(new Vector3(0, 0, 0)));
        }
        #endregion
    }

    private void SpawningTypeTwo()
    {
        currentPoint += nextPointRange;
        settingPose = new Vector3(startingPoint.position.x + currentPoint, Random.Range(lowestY, highestY));

        //the upper
        Instantiate(thingsToSetTypeTwo[Random.Range(0, thingsToSetTypeTwo.Length)], new Vector3(settingPose.x, highestSecTypeY), Quaternion.Euler(new Vector3(0, 0, 0)));


        //the lower
        Instantiate(thingsToSetTypeTwo[Random.Range(0, thingsToSetTypeTwo.Length)], new Vector3(settingPose.x, lowestSecTypeY), Quaternion.Euler(new Vector3(0, 0, 0)));

        //setterSetter
        Instantiate(setMoreThingObject, settingPose, Quaternion.Euler(new Vector3(0, 0, 0)));


        #region enime

        firstEnemyShowenPossible = Random.Range(1, 4);
        if (firstEnemyShowenPossible == 3)
        {
            Instantiate(firstEnemy, settingPose, Quaternion.Euler(new Vector3(0, 0, 0)));
        }

        #endregion

        #region items

        //money
        foreach(int i in howMuchInstaint)
        {
            Instantiate(coinPrefab, new Vector3(settingPose.x + Random.Range(20, -20), Random.Range(-20, -7), 3.3f), Quaternion.Euler(new Vector3(0, 0, 0)));
        }

        //heart

        int possibleToSetHeart = Random.Range(0, maxPossibleToSetHeart);
        if (possibleToSetHeart == 1)
        {
            Instantiate(heartPrefab, new Vector3(settingPose.x + Random.Range(20, -20), Random.Range(-20, -7), 3.3f), Quaternion.Euler(new Vector3(0, 0, 0)));
        }
        #endregion
    }
}
//0.4
//-21