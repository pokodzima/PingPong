using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class AdjustBallVelocityOnCollision : MonoBehaviour
{
    [SerializeField] private FloatReference ballSpeed;
    private Rigidbody2D _rigidbody;
    private const string BallTag = "Ball";

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag(BallTag))
        {
            var ballRigidbody = col.gameObject.GetComponent<Rigidbody2D>();
            var vel = ballRigidbody.velocity;
            vel.x = vel.x / 2 + _rigidbody.velocity.x / 2;
            vel = vel.normalized * ballSpeed.value;
            ballRigidbody.velocity = vel;
        }
    }
}