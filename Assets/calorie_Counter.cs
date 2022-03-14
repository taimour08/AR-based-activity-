using UnityEngine;
using UnityEngine.UI;
using System;

public class calorie_Counter : MonoBehaviour
{
    public Transform obstacle;
    public Transform sphere;
    public Text calorieText;
    // Left x -7.85, right x -7.02, Up y 1.18, Down y 1.14. (Box Position)



    // We took out the distance in term of y coordinates to real life in metres. 
    // 1 y moved will result in 7.7in = 0.2m 
    // Then measured how much calories will be burned when person moves 1 meter, 0.08 cals.
    // 6.1 moved in y coords will result in 47 inches in real life. Calculated using the difference in the height of the obstacle from the starting position of the face 

    // 0.24 calories burned on one squat. 


    // *Sphere: To dodge the sphere, the player has to move approx. 0.3m to the left or right.
   
    const float faceY = 1.16f; // Position of face 
    const float oneYCoordMoved = 0.2f; // 1 y moved will result in 7.7in = 0.2m 
    const float caloriesBurnedOneMeter = 0.08f; // Calories burned when a person moves 1m
    const float conversionToCalories = oneYCoordMoved * caloriesBurnedOneMeter; // = 0.016 calories. These are the calories burned when a person moves 1 y coordinate in session space  
    float caloriesBurned = 0; // This is the count of the calories burned which will be displayed 

    
   

    // Update is called once per frame
    void Update()
    {
        float xy = obstacle.position.y; // Y position of obstacle 

        Debug.Log("Y Position: " + xy);
        
        if (obstacle.position.x == -5.2f)   // If obstacle reaches the middle, increase calories burned 
        caloriesBurned += (Math.Abs(faceY - obstacle.position.y)) * conversionToCalories; // Keep adding to calories as position of obstacle changes. Take absolute of the
                                                                                          // difference of the face and obstacle position.
        if (sphere.position.y == 1.1f)  // Approx. value of the sphere surpassing the user, increase value 
            caloriesBurned += (Math.Abs(0.5f)); // Calories burnt when a user dodges the sphere

        Debug.Log("Calories Burned: " + caloriesBurned);

        calorieText.text = caloriesBurned.ToString("f2");   // To diplay the calories burned in the activity scene 
    }
}
