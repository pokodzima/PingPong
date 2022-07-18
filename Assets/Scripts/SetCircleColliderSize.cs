using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCircleColliderSize : MonoBehaviour
{
    [SerializeField] private Vector3Reference size;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<CircleCollider2D>().radius = (size.value.x + size.value.y) / 4;
    }

    // Update is called once per frame
    void Update()
    {
    }
}