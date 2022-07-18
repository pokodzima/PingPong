using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetBoxColliderSize : MonoBehaviour
{
    [SerializeField] private Vector3Reference size;

    private void Awake()
    {
        GetComponent<BoxCollider2D>().size = size.value;
    }
}
