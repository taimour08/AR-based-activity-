using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class sphereMovement : MonoBehaviour
{

    float y = -2f, x = -7.4f, z = -9.0f;    // The coordinates of the sphere obstacle 
    float[] xPositions = { -7.4f, -8.3f, -7.7f, -6.8f, -8.1f }; // The x positions of the ball set manually so the ball is thrown from different positions 
    int timer = 0; // Timer to control speed of movement
    int xIndex = 0;  

   
    public AudioClip yourSound; // This variable has been assigned an audio in unity editor

    public void PlaySound()
    {
        GetComponent<AudioSource>().clip = yourSound;  // The AudioSource component of our obstacle will get the audio that we assigned in unity 
        GetComponent<AudioSource>().Play(); // Play the sound
    }

  

    // Update is called once per frame
    void Update()
    {
        timer++;    // Increase value of timer to control the speed of movement by using if statement below 
      
        if (y > 6.8f)   // To bring the ball to the start   
        {
            System.Random rd = new System.Random(); // This random value's remainder with 3 is used as array index to change size of obstacle 

            float rand_num = rd.Next(-9, -6);

            y = -1.3f;  // Bring the ball back from where it's thrown 
            z = -9f;    // z increasing to give a more 3D effect.
            x = xPositions[xIndex]; // To change the x positions of the ball 
            xIndex++;  
        }

   

        if (timer % 5 == 0) // To control the speed of the ball thrown
        {
            if (timer >= 200)   // For delay in start 
            {

                if (y > -1.2f && y < -1.0f) // Condition to play sound 
                {
                    PlaySound();
                }

                transform.position = new Vector3(x, y, z);  
                y += 0.2f;  // Move up
                z += 0.4f;  // Move away
            }

        }
    }
}
