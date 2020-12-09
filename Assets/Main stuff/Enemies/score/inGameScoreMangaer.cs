using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inGameScoreMangaer : MonoBehaviour
{
    public static int score;
    public static int scoreEachTime;
    public int scoreEachTimeValue;
    public Text scoreText;

    void Start()
    {
        scoreEachTime = scoreEachTimeValue;
        score = 0;
    }

    void Update()
    {
        scoreText.text = score.ToString("0");
    }
}
