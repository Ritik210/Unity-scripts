using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quaternionLookrotation : MonoBehaviour
{
    [SerializeField]
    private Transform enemy;
   
    // Update is called once per frame
    void Update()
    {
        Vector3 directionToFace = enemy.position - transform.position;

        //To see how the distance calculates
        Debug.DrawRay(transform.position, directionToFace, Color.green);

        // it locks the enemy direction.
        transform.rotation = Quaternion.LookRotation(directionToFace);
        
    }
}
