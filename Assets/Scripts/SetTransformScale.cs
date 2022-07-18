using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetTransformScale : MonoBehaviour
{
    [SerializeField] private Vector3Reference size;

    private void Awake()
    {
        transform.localScale = size.value;
    }
}
