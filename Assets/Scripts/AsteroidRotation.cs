using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidRotation : MonoBehaviour
{
    public float rotationSpeed;

    void Start()
    {
        GetComponent<Rigidbody>().angularVelocity = new Vector3(0.0f, Random.value, 0.0f) * rotationSpeed;
    }
}
