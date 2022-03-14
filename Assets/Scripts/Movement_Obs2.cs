using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Movement_Obs2 : MonoBehaviour
{

    // x and y arrays to place ball on random positions




    int resetCounter = 0, rand_num; // Index for positions array
    float[] obstaclePosition = { 4.55f, 4.05f, 5.2f }; // Length of obstacle from top

    float x = -14f;



    // Start is called before the first frame update

    void Start()
    {
        //Debug.Log(transform);
        // Every object has a transform by default
    }


    // Update is called once per frame

    void Update()
    {
        resetCounter += 1;

        // Condition to bring obstacle back to start  
        if (x > -1f)
        {
            x = -14f;


            System.Random rd = new System.Random(); // This random value's remainder with 3 is used as array index to change size of obstacle 

            rand_num = rd.Next(100, 200);
            Debug.Log(rand_num);
        }


        if (resetCounter % 15 == 0) // For controlling speed of game
        {
            x++;
        }




        //Debug.Log(index);

        transform.position = new Vector3(x, obstaclePosition[rand_num % 3], 0.3f);


    }
}
