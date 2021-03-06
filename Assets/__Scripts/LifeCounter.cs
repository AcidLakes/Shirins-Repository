﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCounter : MonoBehaviour
{
    // == private fields ==
    [SerializeField] private LifeIcon lifeIconPrefab; // whatever using for lives

    private int startingLives;  // read from the Game Controller
    private GameController gc;
    void Start()
    {
        // get the GameController object
        gc = FindObjectOfType<GameController>();
        if (gc)
        {
            // retrieve the starting lives value
            // set up a read only public property to return
            // the number of starting lives
            startingLives = gc.StartingLives;
            CreateIcons();
        }
    }

    private void CreateIcons()
    {
        // show the appropriate number of lives on the screen
        // use a loop
        for (int i = 0; i < startingLives; i++)
        {
            LifeIcon icon = Instantiate(lifeIconPrefab, transform);
        }
    }

    private void updateLives()
    {

    }
}

