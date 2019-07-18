using UnityEngine;
using UnityEngine.UI;
using Vector2 = UnityEngine.Vector2;

public class Movement : MonoBehaviour
{
    private Rigidbody2D _rb;
    public float speed = 3f;
    private float _x;
    private float _y;
    public string horizontal;
    public string vertical;
    public float rotateSpeed = 200f;
    private float deltaAngle;
    private Vector3 dir;
    private bool disableCtrl = false;
    private float disableDuring = 0.5f;
    private float t = 0f;
    private float d = 0f;
    private float rotAdj = 1;
    private float durAdj = 1;
    private float spdAdj = 1;

    public int player;
    private KeyCode sprint;
    private KeyCode sprintCtrl;
    public Slider bar;
    private float stamina = 1f;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        // _rb.velocity = Vector2.up * Speed;
        if (player == 0) sprint = KeyCode.LeftShift;
        if (player == 1) sprint = KeyCode.RightShift;
    }

    private void Update()
    {
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!disableCtrl)
        {
            disableCtrl = true;
            dir = collision.contacts[0].normal;
            d = Vector3.SignedAngle(transform.up, dir, Vector3.forward);
            if (collision.gameObject.tag == "Ball")
            {
                rotAdj = 0f;
                spdAdj = 0.3f;
                durAdj = 0.3f;
            }
            else if (collision.gameObject.tag == "Body")
            {
                rotAdj = 0.8f;
                spdAdj = 1f;
                durAdj = 0.1f;
            }
            else
            {
                rotAdj = 1;
            }
        }
    }

    private void LateUpdate()
    {
        _x = Input.GetAxis(horizontal);
        _y = Input.GetAxis(vertical);
        if (_x != 0f || _y != 0f && !disableCtrl)
        {
            dir = new Vector3(_x, _y, 0);
        }
        deltaAngle = Vector3.SignedAngle(transform.up, dir, Vector3.forward);

        if (disableCtrl)
        {
            if (t >= disableDuring * durAdj) 
            {
                t = 0;
                spdAdj = 1f;
                durAdj = 1f;
                disableCtrl = false;
            }
            else
            {
                //transform.Rotate(Vector3.forward, Time.deltaTime * 400);
                if (d > 0)
                {
                    transform.Rotate(Vector3.forward, Time.deltaTime * 400 * rotAdj);
                }
                else if (d < 0)
                {
                    transform.Rotate(Vector3.forward, Time.deltaTime * -400 * rotAdj);
                }
                t += Time.deltaTime;
            }
        }
        if (deltaAngle > 0 && !disableCtrl)
        {
            //rotateSpeed = Mathf.Lerp(0, rotateSpeed, deltaAngle / 12f);
            transform.Rotate(Vector3.forward, Time.deltaTime * rotateSpeed);
        }
        else if (deltaAngle < 0 && !disableCtrl)
        {
            //rotateSpeed = Mathf.Lerp(0, rotateSpeed, deltaAngle / 12f);
            transform.Rotate(Vector3.forward, Time.deltaTime * -rotateSpeed);
        }

        //transform.up = Vector3.Lerp(transform.up, new Vector3(_x, _y, 0), Time.deltaTime * rotateSpeed);

        //transform.up = dir;
        _rb.velocity = transform.up * speed * spdAdj;
        if (Input.GetKey(sprint) || Input.GetKey("joystick " + (player + 1) + " button 1") && stamina >= 0f)
        {
            speed = 4.5f;
            stamina -= Time.deltaTime;
        }
        else
        {
            speed = 3f;
        }

        bar.value = stamina;
    }

    public void SpeedUp()
    {
        if (stamina < 0.5)
        {
            stamina += 0.5f;
        }
        else
        {
            stamina = 1f;
        }
    }
}