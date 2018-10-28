using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinMotor : MonoBehaviour
{
    public float speed = 1;

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(transform.position, new Vector3(0, -1, 0), speed * Time.deltaTime);
    }
}