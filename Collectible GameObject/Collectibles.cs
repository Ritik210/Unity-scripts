using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectibles : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            // you can give any options for power up like points add or speed increase etc.
            Destroy(this.gameObject);

        }
    }
}
