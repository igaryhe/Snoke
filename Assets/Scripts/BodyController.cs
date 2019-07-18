using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class BodyController : MonoBehaviour
{
    public GameObject part;
    private int len = 10;
    private List<GameObject> body;
    private List<Vector3> vels;
    public int player;
    private float distant = 0.2f;

    private void Start()
    {
        body = new List<GameObject>();
        InitBody(body);
    }
    
    private void LateUpdate()
    {
        UpdateBody(body);
    }

    private void InitBody(ICollection<GameObject> b)
    {
        vels = new List<Vector3>();
        for (var i = 0; i != len; i++)
        {
            var instance = Instantiate(part, transform.position, Quaternion.identity);
            if (player == -1) instance.layer = 15;
            else instance.layer = 16;
            instance.GetComponentInChildren<SpriteRenderer>().color = gameObject.GetComponent<SpriteRenderer>().color;
            b.Add(instance);
            vels.Add(Vector3.zero);
        }
    }

    private void UpdateBody(List<GameObject> b)
    {
        for (var i = 0; i != len; i++)
        {
            //b[i].position = Vector3.Lerp(b[i].position, i == 0 ? transform.position : b[i - 1].position, overTime);
            if (i != 0)
            {
                b[i].transform.up = (b[i - 1].transform.position - b[i - 1].transform.up * 0.15f - b[i].transform.position).normalized;

                b[i].transform.position = b[i - 1].transform.position - b[i - 1].transform.up * 0.15f - (b[i - 1].transform.position - b[i - 1].transform.up * 0.15f - b[i].transform.position).normalized * distant;
            }
            else if(i == 0)
            {
                b[i].transform.up = (transform.position - transform.up * 0.15f - b[i].transform.position).normalized;
                b[i].transform.position = transform.position - transform.up * 0.15f - (transform.position - transform.up * 0.15f - b[i].transform.position).normalized * distant;
            }
        }
    }

    public void Increase()
    {
        var instance = Instantiate(part, body[len - 1].transform.position, Quaternion.identity);
        instance.GetComponentInChildren<SpriteRenderer>().color = gameObject.GetComponent<SpriteRenderer>().color;
        body.Add(instance);
        vels.Add(Vector3.zero);
        len++;
    }

    public void Restart()
    {
        len = 10;
        foreach (var b in body)
        {
            Destroy(b);
        }
        body.Clear();
        vels.Clear();
        transform.position = new Vector3(7 * player, 0, 0);
        InitBody(body);
    }
}
