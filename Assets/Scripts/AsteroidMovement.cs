using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMovement : MonoBehaviour
{
    public float forwardSpeed;

    public float rotationSpeed;

    void Start()
    {
        GetComponent<Rigidbody>().velocity = transform.forward * forwardSpeed;

        GetComponent<Rigidbody>().angularVelocity = new Vector3(0.0f, Random.value, 0.0f) * rotationSpeed;
    }
}
