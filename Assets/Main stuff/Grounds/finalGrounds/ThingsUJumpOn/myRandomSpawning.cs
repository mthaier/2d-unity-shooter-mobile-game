using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myRandomSpawning : MonoBehaviour
{
    public float upperSize;
    public float lowerSize;
    // Start is called before the first frame update
    void Start()
    {
        this.transform.rotation = Quaternion.Euler(new Vector3(0, 0, Random.Range(-60, 0)));

        float sizeScale = Random.Range(lowerSize, upperSize);
        this.transform.localScale = new Vector3(sizeScale, sizeScale, sizeScale);
    }
}
