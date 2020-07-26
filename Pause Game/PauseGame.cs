using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Space))
        {
            //To slow down the game we can use the different values of time.timeScale like 0.25,0.5 etc.
            Time.timeScale = 0;
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            Time.timeScale = 1;
        }
    }
}
