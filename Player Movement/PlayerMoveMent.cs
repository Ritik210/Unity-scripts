using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveMent : MonoBehaviour
{
    [SerializeField]
    private float _speed;

    [SerializeField]
    private float horizontal;
    [SerializeField]
    private float vertical;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(horizontal, 0, 0) * _speed * Time.deltaTime);

        vertical = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(0,vertical, 0) * _speed * Time.deltaTime);
    }
}
