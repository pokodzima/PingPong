using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TouchInput : MonoBehaviour
{
    [SerializeField] private FloatReference movingInput;

    private GameActions _gameActions;
    
    // Start is called before the first frame update
    void Start()
    {
        _gameActions = new GameActions();
        _gameActions.PingPong.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        movingInput.value = _gameActions.PingPong.Moving.ReadValue<Vector2>().x;
    }
}
