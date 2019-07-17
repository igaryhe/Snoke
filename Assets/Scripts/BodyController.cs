using System.Collections.Generic;
using UnityEngine;

public class BodyController : MonoBehaviour
{
    public GameObject part;
    private const int len = 10;
    private List<Transform> body;
    private Vector3[] vels;

    private void Start()
    {
        body = new List<Transform>();
        InitBody(body);
    }
    
    private float overTime = 0.2f;

    private void FixedUpdate()
    {
        UpdateBody(body);
    }

    private void InitBody(ICollection<Transform> b)
    {
        vels = new Vector3[len];
        for (var i = 0; i != len; i++)
        {
            var instance = Instantiate(part, transform.position, Quaternion.identity);
            instance.GetComponent<SpriteRenderer>().color = gameObject.GetComponent<SpriteRenderer>().color;
            b.Add(instance.transform);
        }
    }

    private void UpdateBody(IReadOnlyList<Transform> b)
    {
        for (var i = 0; i != len; i++)
        {
            if (i == 0)
            {
                b[i].position =
                    Vector3.SmoothDamp(b[i].position, transform.position, 
                        ref vels[i], overTime);
            }
            else
            {
                b[i].position = Vector3.SmoothDamp(b[i].position,
                    b[i - 1].position,
                    ref vels[i], overTime);
            }
        }
    }

    public void Increase()
    {
        body.Add(Instantiate(part, transform.position, Quaternion.identity).transform);
    }
}
