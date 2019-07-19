using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    private Rigidbody2D _rb;
    public GameObject head1, head2;

    private float t = 0f;
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
        //if (_rb.velocity.magnitude == 0) return;
        //_rb.velocity = _rb.velocity.normalized * speed;
        //t += Time.deltaTime;
        //speed = Mathf.Pow(t, 0.5f) + 2.0f;
        _rb.velocity += Time.deltaTime * _rb.velocity.normalized * 0.2f;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GetComponent<Rigidbody2D>().velocity = collision.transform.up
                                                 * Mathf.Clamp(collision.gameObject.GetComponent<Rigidbody2D>().velocity.magnitude, 3f, 6f);
            Debug.Log("ball_v:" + GetComponent<Rigidbody2D>().velocity);
        }
    }

    public void Reposition()
    {
        t = 0f;
        gameObject.transform.position = Vector3.zero;
        _rb.velocity = Vector2.zero;
        speed = 2;
        head1.GetComponent<BodyController>().Restart();
        head2.GetComponent<BodyController>().Restart();
        head1.GetComponent<Movement>().stamina = 1f;
        head2.GetComponent<Movement>().stamina = 1f;
    }
}
