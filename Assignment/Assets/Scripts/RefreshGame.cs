using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RefreshGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //If statement which loads the unity scene again whenever the 'R' key is pressed down
        if (Input.GetKeyDown(KeyCode.R))
            Application.LoadLevel(0);

    }
}
