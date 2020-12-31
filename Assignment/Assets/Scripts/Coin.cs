using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    //Setting a variable with coin turnspeed
    public float turnSpeed = 90f;


    void OnTriggerEnter (Collider other)
    {

      //Checking that the object we collided with is the player
      if(other.gameObject.name != "Player")
        {
            return;
        }

        // Adding to player's score
        GameManager.inst.IncrementScore();


        //Destroy coin
        Destroy(gameObject);
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Rotating the coins
        transform.Rotate(0, 0, turnSpeed * Time.deltaTime);
    }
}
