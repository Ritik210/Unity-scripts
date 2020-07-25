using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInput : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Key pressing
      if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space Key");
        }

      //holding a key
      if(Input.GetKey(KeyCode.E))
        {
            Debug.Log("E Key");
        }

      // message when key is lifting up
      if(Input.GetKeyUp(KeyCode.F))
        {
            Debug.Log("F key");
        }
    }
}
