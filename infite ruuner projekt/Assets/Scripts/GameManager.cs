using System.Collections;
using TMPro;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;
using System;
//licznik
public class GameManager : MonoBehaviour
{
    public int score;
    public static GameManager inst;

    public TextMeshProUGUI scoreText, distanceScore;

  //  public static event  Action OnPlayerDeath;




    public void IncrementScore()
    {
        score++;
        scoreText.text = "Coins: " + score;
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
        distanceScore.text = "Score: " + (int)zpos;
    }
}
