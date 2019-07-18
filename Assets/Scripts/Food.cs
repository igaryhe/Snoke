using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        var bc = other.gameObject.GetComponent<BodyController>();
        if (bc == null) return;
        for (int i =0; i<3; i++)
        {
            bc.Increase();
        }
        FindObjectOfType<Generator>().Generate();
        Destroy(gameObject);
    }
}
