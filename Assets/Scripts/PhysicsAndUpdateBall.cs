using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsAndUpdateBall : MonoBehaviour
{
    private Vector3 _moveDirection;

    [SerializeField] private float speed;

    protected virtual void Awake()
    {
        Vector2 randomVector = Random.insideUnitCircle.normalized;
        _moveDirection = new Vector3(randomVector.x, 0, randomVector.y);
    }

    private void Update()
    {
        transform.position += _moveDirection * (speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        _moveDirection = Vector3.Reflect(_moveDirection, collision.GetContact(0).normal);
    }
}
