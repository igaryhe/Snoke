using UnityEngine;

public class Movement : MonoBehaviour
{
    private const float Speed = 2.5f;
    private Rigidbody2D _rb;
    protected InputMaster _controls;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _rb.velocity = Vector2.up * Speed;
    }

    protected void Move(Vector2 vel)
    {
        _rb.velocity = vel.normalized * Speed;
    }

    private void OnEnable()
    {
        _controls.Enable();
    }

    private void OnDisable()
    {
        _controls.Disable();
    }
}