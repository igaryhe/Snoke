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
        // _rb.velocity = _rb.velocity.normalized * speed;
    }

    public void Reposition()
    {
        gameObject.transform.position = Vector3.zero;
        _rb.velocity = Vector2.zero;
    }
}
