using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D _rb;

    private float speed = 2;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _rb.velocity = Vector2.zero;
    }

    // Update is called once per frame
    void Update()
    {
        if (_rb.velocity.magnitude == 0) return;
        // _rb.velocity = _rb.velocity.normalized * speed;
        _rb.velocity = _rb.velocity.normalized * speed;
        speed += Time.deltaTime * 0.2f;
    }

    public void Reposition()
    {
        gameObject.transform.position = Vector3.zero;
        _rb.velocity = Vector2.zero;
        speed = 2;
    }
}
