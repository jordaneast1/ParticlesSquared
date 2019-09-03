using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]

public class SinePosition : MonoBehaviour
{

    public float xRate;
    public float yRate;
    public float zRate;
    public float rateMult;
    public float xAmp, yAmp, zAmp;

    private float x, y, z;

    private void Start()
    {
        x = transform.position.x;
        y = transform.position.y;
        z = transform.position.z;
        Debug.Log(xRate);
    }

    // Update is called once per frame
    void Update()
    {
        x += xRate;
        y += yRate;
        z += zRate;
       Vector3 newPos = new Vector3(
            Mathf.Sin(x * rateMult) *xAmp,
            Mathf.Sin(y * rateMult) *yAmp,
            Mathf.Cos(z * rateMult) * zAmp
            );
        transform.position = newPos;
        //Debug.Log(transform.position);
    }
}
