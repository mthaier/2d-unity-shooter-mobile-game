using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class superPowerActive : MonoBehaviour
{
    private GameObject[] superTimes;
    public GameObject powerPrefab;
    private bool stop;

    //to work on pc
    public bool pcControler;

    //to work on phone
    public GameObject superPowerButton;

    void LateUpdate()
    {
        #region pc controler

        if (pcControler)
        {
            if (Input.GetKey(KeyCode.E) && stop == false)
            {
                SuperBoom();
                stop = true;
            }
        }
        
        #endregion
    }

    public void SuperBoom()
    {
        superTimes = GameObject.FindGameObjectsWithTag("Super Powers");
        
        if(superTimes != null)
        {
            int wichBomb = Random.Range(0, superTimes.Length);
            Instantiate(powerPrefab, superTimes[wichBomb].transform.position, Quaternion.Euler(new Vector3(0, 0, 0)));
            Destroy(superTimes[wichBomb]);
        }

        if (superTimes == null)
        {
            superPowerButton.active = false;
        }
    }
}
