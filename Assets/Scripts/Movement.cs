using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Movement : MonoBehaviour
{
    int rand_num;
    int swtch = 1;  // Variable to switch between top and bottom obstacle
    float[] obstaclePosition1 = {8.2f, 6.8f, 5.5f }; // An array which sets the y position of the top obstacle. (Length of obstacle from top)
    float[] obstaclePosition2 = { -2.0f, -2.1f, -2.8f };  // An array which sets the y position of the bottom obstacle. 

    float x = -15.2f, y;    // x and y position of the obstacle

    int timer = 0;  // Variable to control the speed of the movement of the obstacle 
    bool move = false;  

    AudioSource myAudio;    // Audio variable created to play audio during activity

    void Start ()
    {
        myAudio = GetComponent<AudioSource>();  // Initializig variable with unity's AudioSource component 
    }

    // Update is called once per frame
    
    void Update()
    {       
        timer++;    // The game timer keeps increasing
        
        // What to do when the obstacle exceeds the right limit  
           if (x > -3.4f)
        {

            x = -12.2f;   // Return to start

            swtch *= -1;    // For changing position of obs from top to bottom. swtch variable is used below
            Debug.Log(swtch);
            
            System.Random rd = new System.Random(); // This random value's remainder with 3 is used as array index to change size of obstacle 

            rand_num = rd.Next(100, 200);
        }


            if (x == -8.299f)
        {
            myAudio.Play();     // Play audio

        }

        if (timer % 5 == 0) // For controlling speed of game
        {
            if (timer > 200)    // For delay in start 
            {                
                x += 0.1f;     // For moving obstacle to the right 
            }
        }




        // Change obstacle position from top to bottom
        if (swtch == 1)
            y = obstaclePosition1[rand_num % 3];    // This randomly assigns a value from the obstaclePosition array so obstacle is at different position everytime 
        else
            y = obstaclePosition2[rand_num % 3];


        transform.position = new Vector3(x, y, 0.3f);   // Transform function to update the position 


    }
}
