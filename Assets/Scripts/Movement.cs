using UnityEngine;
using Vector2 = UnityEngine.Vector2;

public class Movement : MonoBehaviour
{
    private Rigidbody2D _rb;
    private const float Speed = 2.5f;
    private float _x;
    private float _y;
    public string horizontal;
    public string vertical;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        // _rb.velocity = Vector2.up * Speed;
    }

    private void Update()
    {
        _x = Input.GetAxis(horizontal);
        _y = Input.GetAxis(vertical);
        if (_x == 0f && _y == 0f) return;
        transform.up = new Vector3(_x, _y, 0f);
        _rb.velocity = transform.up * Speed;
    }
}
