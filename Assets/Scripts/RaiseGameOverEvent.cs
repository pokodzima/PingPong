using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaiseGameOverEvent : MonoBehaviour
{
    [SerializeField] private GameEvent gameOverEvent;

    private const string BallTag = "Ball";

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag(BallTag))
        {
            gameOverEvent.Raise();
        }
    }
}
