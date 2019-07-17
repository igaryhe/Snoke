using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Plugins.PS4;
using Vector2 = UnityEngine.Vector2;

public class P2Movement : Movement
{
    private void Awake()
    {
        _controls = new InputMaster();
        _controls.devices = new[] { Gamepad.all[1] };
        _controls.Player2.Movement.performed += ctx => Move(ctx.ReadValue<Vector2>());
    }
}
