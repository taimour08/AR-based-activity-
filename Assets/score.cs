
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Transform obstacle;  
    public Text scoreText;
    int gameScore = 0;  // The variable to keep the game score 
    // Update is called once per frame
    void Update()
    {
        if (obstacle.position.x >= -5.4f && obstacle.position.x <= -5.3f)   // If the obstacle surpasses the player
        {
            gameScore++;   // Score value increase being controlled by divisible of timer          
        }

        scoreText.text = gameScore.ToString();  // To display the score  
    }
}
