using System.Collections;
using TMPro;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int score;
    public static GameManager inst;

    public TextMeshProUGUI scoreText, distanceScore;



    public void IncrementScore()
    {
        score++;
        scoreText.text = "SCORE: " + score;
    }

    private void Awake()
    {
        inst = this;
    }

    void Start()
    {

    }


    void Update()
    {

    }
    public void SetDistanceScore(float zpos)
    {
        distanceScore.text = "SCORE: " + (int)zpos;
    }
}
