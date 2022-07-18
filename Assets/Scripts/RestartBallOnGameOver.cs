using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class RestartBallOnGameOver : MonoBehaviour
{
    [SerializeField] private GameEvent restartEvent;
    [SerializeField] private FloatReference timeToRestart;
    private Rigidbody2D _rigidbody;
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    public void ResetBallPosition()
    {
        transform.position = Vector3.zero;
        _rigidbody.velocity = Vector2.zero;
        _rigidbody.angularVelocity = 0f;
        StartCoroutine(RestartBall());
    }

    private IEnumerator RestartBall()
    {
        yield return new WaitForSeconds(timeToRestart.value);
        restartEvent.Raise();
    }
}
