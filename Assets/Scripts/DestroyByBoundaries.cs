using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByBoundaries : MonoBehaviour
{
    void OnTriggerExit(Collider other)
    {
        Destroy(other.gameObject);
    }
}
