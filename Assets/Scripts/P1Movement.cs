using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Plugins.PS4;

public class P1Movement : Movement
{
    private void Awake()
    {
        _controls = new InputMaster();
        _controls.devices = new[] { Gamepad.all[0] };
        _controls.Player1.Movement.performed += ctx => Move(ctx.ReadValue<Vector2>());
    }
}