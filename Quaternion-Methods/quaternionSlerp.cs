using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quaternionSlerp : MonoBehaviour
{
    // quaternionSlerp - for smooth rotation towards target
    [SerializeField]
    private Transform enemy;

    // Update is called once per frame
    void Update()
    {
        Vector3 directionToFace = enemy.position - transform.position;

        //To see how the distance calculates
        Debug.DrawRay(transform.position, directionToFace, Color.green);

        // it locks the enemy direction.
        Quaternion targetRotation = Quaternion.LookRotation(directionToFace);

        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime* 1); // 1 is time

    }
}
