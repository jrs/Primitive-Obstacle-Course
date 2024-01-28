using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    public float rotationSpeedX = 0f;
    public float rotationSpeedY = 0f;
    public float rotationSpeedZ = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(rotationSpeedX, rotationSpeedY, rotationSpeedZ);
        transform.Rotate(Vector3.forward, rotationSpeedZ * Time.deltaTime);
    }
}
