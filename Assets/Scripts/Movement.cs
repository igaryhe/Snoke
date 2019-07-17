using UnityEngine;

public class Movement : MonoBehaviour
{
    private const float Speed = 2.5f;
    private Rigidbody2D _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _rb.velocity = Vector2.up * Speed;
    }

    protected void Move(Vector2 vel)
    {
        // _rb.velocity = vel.normalized * Speed;
        transform.up = new Vector3(vel.x, vel.y, 0f);
        _rb.velocity = transform.up * Speed;
    }
}