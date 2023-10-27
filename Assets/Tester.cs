using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tester : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.LogWarning(collision.gameObject);
    }
}
