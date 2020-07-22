using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMovement : MonoBehaviour
{
    public float forwardSpeed;

    void Start()
    {
        GetComponent<Rigidbody>().velocity = transform.forward * forwardSpeed;
    }
}
