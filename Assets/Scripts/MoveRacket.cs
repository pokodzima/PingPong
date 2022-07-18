using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class MoveRacket : MonoBehaviour
{
    [SerializeField] private FloatReference input;

    [SerializeField] private FloatReference speed;
    

    private Rigidbody2D _rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _rigidbody.velocity = new Vector2(input.value * speed.value, 0f);
    }
}