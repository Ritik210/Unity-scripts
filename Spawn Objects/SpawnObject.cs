using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    [SerializeField]
    private GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            // Quaternion.identity - for no rotation.
          //  Instantiate(cube, Vector3.zero, Quaternion.identity);

             //Quaternion.Euler - for specific rotation.
            Instantiate(cube, Vector3.zero, Quaternion.Euler(0,45,0));
        }
    }
}
