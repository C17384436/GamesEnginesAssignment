using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //Creating a variable to keep track of the score
    public int score;

    public static GameManager inst;


    //Variable to present a display of the user's current score
    public Text scoreText;

    //Function to add score
    public void IncrementScore()
    {
        //Adding 1 to the score
        score++;

        //Displaying the Score text as well as the currect value of the score
        scoreText.text = "SCORE: " + score;
    }

    void Awake()
    {
        
        inst = this;

    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
