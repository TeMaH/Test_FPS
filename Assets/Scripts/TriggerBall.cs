using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBall : MonoBehaviour
{

    private Vector3 _moveDirection;

    [SerializeField] private float speed;

    protected virtual void Awake()
    {
        Vector2 randomVector = Random.insideUnitCircle.normalized;
        _moveDirection = new Vector3(randomVector.x, 0, randomVector.y) * speed;
    }

    private void Update()
    {
        transform.position += _moveDirection * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        _moveDirection = Vector3.Reflect(_moveDirection, other.transform.forward);
    }
}
