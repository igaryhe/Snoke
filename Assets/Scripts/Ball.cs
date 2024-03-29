﻿using UnityEngine;

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
    }

    public void Reposition()
    {
        t = 0f;
        gameObject.transform.position = Vector3.zero;
        _rb.velocity = Vector2.zero;
        speed = 2;
        head1.GetComponent<BodyController>().Restart();
        head2.GetComponent<BodyController>().Restart();
    }
}
