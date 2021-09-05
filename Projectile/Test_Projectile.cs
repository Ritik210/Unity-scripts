using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Projectile : MonoBehaviour
{
    public Transform startPoint;
    public Transform endPoint;
    public Transform centrePoint;

    public float zRadius;
    public float yRadius;

    public float angle;
    public float throwTime;

    private void Start()
    {
        centrePoint.position = (startPoint.position + endPoint.position) / 2;
        centrePoint.LookAt(endPoint);
        transform.SetParent(centrePoint);
        transform.position = startPoint.position;
        transform.localRotation = Quaternion.identity;
        zRadius = Vector3.Distance(transform.position, centrePoint.position);

        StartCoroutine(Throw_());
        
    }

    IEnumerator Throw_()
    {
        float time = 0;

        float initialValue = 3.14f;
        float finalValue = 0;

        while(time < 1)
        {
            time += Time.deltaTime / throwTime;

            angle = Mathf.Lerp(initialValue, finalValue, time);
            transform.localPosition = new Vector3(0, yRadius * Mathf.Sin(angle), zRadius * Mathf.Cos(angle));

            yield return null;
        }
    }
}
