﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeMake : MonoBehaviour
{
    public GameObject wall;
    int[,] mazeLayout = new int [,]
    {
        {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
        {1,0,0,0,0,1,1,1,0,0,1,1,0,0,0,1,0,0,0,0,0,0,1},
        {1,0,1,1,0,1,0,1,0,1,0,0,0,1,0,0,0,1,1,1,1,0,1},
        {1,1,0,0,0,0,0,1,0,0,0,1,0,1,1,1,0,1,1,0,0,0,1},
        {1,1,1,1,0,1,1,1,1,1,1,1,0,1,0,1,0,1,0,1,1,1,1},
        {1,0,1,0,0,0,0,0,0,0,1,0,0,1,0,1,0,1,0,0,0,1,1},
        {1,0,1,0,1,1,0,1,1,1,1,1,0,0,0,1,0,1,1,1,0,1,1},
        {1,0,1,1,1,0,0,0,0,0,0,1,1,1,1,0,0,0,0,0,0,0,1},
        {1,0,1,0,0,0,0,1,0,1,0,0,0,0,0,0,1,1,1,0,1,0,1},
        {1,0,1,1,1,1,0,1,0,1,0,0,0,1,1,1,1,0,1,0,1,0,1},
        {1,0,0,0,0,1,0,1,0,1,0,0,0,1,0,0,0,0,1,0,1,0,1},
        {1,1,1,1,0,0,0,1,0,0,1,0,1,0,0,1,1,1,1,0,1,0,1},
        {1,1,0,0,0,1,1,1,1,1,1,0,1,1,0,1,0,1,0,1,1,0,1},
        {1,0,0,1,1,1,1,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,1},
        {1,1,1,1,0,1,1,1,1,0,1,1,1,1,1,1,1,1,1,1,1,0,1},
        {1,1,0,1,0,1,1,0,0,0,0,0,0,0,1,0,0,0,0,0,1,0,1},
        {1,0,0,0,0,0,1,0,1,1,1,0,1,0,1,1,0,1,1,0,1,1,1},
        {1,0,1,1,1,0,0,0,0,0,1,0,1,0,0,0,0,1,0,0,0,0,1},
        {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1}
    };

    void Start()
    {
        Debug.Log("x: " + mazeLayout.GetLength(0) + ". y: " + mazeLayout.GetLength(1));
        for (int y = 0; y < mazeLayout.GetLength(1); y++)
        {
            for (int x = 0; x < mazeLayout.GetLength(0); x++)
            {
                if (mazeLayout[x, y] == 1)
                {
                    GameObject newWall = Instantiate(wall);
                    newWall.transform.position = new Vector3(y * 0.5f-5.5f, x * -0.5f+4.5f, 0);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
