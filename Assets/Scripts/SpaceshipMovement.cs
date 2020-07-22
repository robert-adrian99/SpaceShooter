using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipMovement : MonoBehaviour
{
    public float speed = 10;

    public float xMax, xMin, zMax, zMin;

    public GameObject shot;
    public Transform shotTransform;

    public float shotRate = 0.1f;
    public float nextShot = 0.0f;

    void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        
        Vector3 direction = new Vector3
        (
            mousePosition.x - transform.position.x,
            0.0f,
            mousePosition.z - transform.position.z
        );

        transform.forward = direction;

        if (Input.GetButtonDown("Fire1") && Time.time > nextShot)
        {
            nextShot = Time.time + shotRate;
            GameObject shotClone = Instantiate(shot, shotTransform.position, shotTransform.rotation) as GameObject;
        }
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        GetComponent<Rigidbody>().velocity = new Vector3(moveHorizontal, 0.0f, moveVertical) * speed;

        GetComponent<Rigidbody>().position = new Vector3
        (
            Mathf.Clamp(GetComponent<Rigidbody>().position.x, xMin, xMax),
            0.0f, 
            Mathf.Clamp(GetComponent<Rigidbody>().position.z, zMin, zMax)
        );
    }
}
