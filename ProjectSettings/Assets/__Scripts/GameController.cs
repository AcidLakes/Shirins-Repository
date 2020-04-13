﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // text mesh pro library
using System;

public class GameController : MonoBehaviour
{
    // private fields
    private float timer;
    private float score = 0;
    [SerializeField] private TextMeshProUGUI ScoreText;
    [SerializeField] private int startingLives = 3;
    private int remainingLives;
    
    // public fields
    public int StartingLives { get { return startingLives; } }
    public int RemainingLives { get { return remainingLives; } }
    //private methods
    private void Awake()
    {
        //SetupSingleton();
    }

    private void Start()
    {
        score = 0;
        UpdateScore();
        remainingLives = startingLives;
    }
    void Update()
    {
        UpdateScore();
    }

    private void UpdateScore()
    {
        // display on screen
        timer += Time.deltaTime;

        if(timer > 0f)
        {
            score += 0.25f;
            
            if(score % 10 == 0f)
            {
                Debug.Log("Score: " + score / 10);
                float edittedScore = score / 10;
                ScoreText.text = edittedScore.ToString();
            }
        }
      
    }
    public void LoseOneLife()
    {
        remainingLives--;
    }
    public void AddOneLife()
    {
        remainingLives++;
    }
}
