using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class faceEnemy2 : MonoBehaviour
{
    private Transform player;

    public float dashingLoadTimer;
    private float mineDashingLoadTimer;

    public float dashingWorkTimer;
    private float mineDashingWorkTimer;

    public float dashingSpeed;
    public float rotateForce;
    private float currentForce;

    //for starting color
    public Color white;
    public Color black;
    private SpriteRenderer myColor;
    void Start()
    {
        #region color setter
        myColor = GetComponent<SpriteRenderer>();
        int colorPossible = Random.Range(0, 2);
        if (colorPossible == 0)
        {
            myColor.color = white;
        }
        if (colorPossible == 1)
        {
            myColor.color = black;
        }
        #endregion

        #region sizeSetter
        float sizeScale = Random.Range(0.35f, 0.70f);
        this.transform.localScale = new Vector3(sizeScale, sizeScale, sizeScale);
        #endregion

        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

        mineDashingLoadTimer = dashingLoadTimer;
        mineDashingWorkTimer = dashingWorkTimer;
    }

    void Update()
    {
        Dash();
    }

    private void Dash()
    {
        if (mineDashingLoadTimer >= 0)
        {
            mineDashingWorkTimer = dashingWorkTimer;
            mineDashingLoadTimer -= Time.deltaTime;
        }

        if (mineDashingLoadTimer < 0)
        {
            this.transform.position = Vector3.Lerp(this.transform.position, player.transform.position, dashingSpeed);

            #region rotate

            currentForce += rotateForce;
            Vector3 rotatePose = new Vector3(0, 0, currentForce);
            this.transform.rotation = Quaternion.Euler(rotatePose);

            #endregion rotate


            mineDashingWorkTimer -= Time.deltaTime;

            if (mineDashingWorkTimer <= 0)
            {
                mineDashingLoadTimer = dashingLoadTimer;
            }
        }
    }
}
