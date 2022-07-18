using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class SetInitialVelocity : MonoBehaviour
{
    [SerializeField] private FloatReference initialSpeed;

    private Rigidbody2D _rigidbody;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        SetRandomVelocity();
    }

    public void SetRandomVelocity()
    {
        var angle = Random.Range(0f, 359f);
        _rigidbody.velocity = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle)) * initialSpeed.value;
    }
}