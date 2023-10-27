using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsBall : MonoBehaviour
{
    [SerializeField] private float speed = 1000.0f;
    private void Awake()
    {
        Vector2 randomVector = Random.insideUnitCircle.normalized;
        Vector3 _moveDirection = new Vector3(randomVector.x, 0.0f, randomVector.y);
        GetComponent<Rigidbody>().AddForce(_moveDirection * speed, ForceMode.Acceleration);
    }
}
